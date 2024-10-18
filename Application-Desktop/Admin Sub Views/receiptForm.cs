using Application_Desktop.Model;
using Application_Desktop.Screen;
using MaterialSkin.Controls;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Desktop.Admin_Sub_Views
{
    public partial class receiptForm : Form
    {
        public receiptForm()
        {
            InitializeComponent();
        }

        void AlertBox(Color backcolor, Color color, string title, string subtitle, Image icon)
        {
            alertBox alertbox = new alertBox();
            alertbox.BackColor = backcolor;
            alertbox.ColorAlertBox = color;
            alertbox.TitleAlertBox = title;
            alertbox.SubTitleAlertBox = subtitle;
            alertbox.IconAlertBox = icon;
            alertbox.Show();
        }

        public void SetReceiptDetails(ReceiptDetails receiptDetails)
        {
            // Assuming you have labels or text boxes in your form to display the details
            txtBranch.Text = receiptDetails.BranchName;
            txtFullname.Text = receiptDetails.UserName;
            txtServices.Text = receiptDetails.ServiceTitle;
            txtPrice.Text = receiptDetails.Price.ToString("C");
            txtStatus.Text = receiptDetails.Status;
        }

        private void receiptForm_Load(object sender, EventArgs e)
        {
            txtPrice.Enabled = false;
            txtTotal.Enabled = false;

            txtStatus.Enabled = false;
            txtBranch.Enabled = false;
            txtFullname.Enabled = false;
            txtServices.Enabled = false;
        }

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern bool OpenPrinter(string pPrinterName, out IntPtr phPrinter, IntPtr pDefault);

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, int Level, [In] DOCINFO pDocInfo);

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern bool WritePrinter(IntPtr hPrinter, byte[] pBuf, int cdBuf, out int pWritten);



        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct DOCINFO
        {
            public string pDocName;
            public string pOutputFile;
            public string pDatatype;
        }



        private void SendCommandToPrinter(string command)
        {
            IntPtr hPrinter;
            // Attempt to open the printer
            bool success = OpenPrinter("XP-58", out hPrinter, IntPtr.Zero);

            // Check if the printer was successfully opened
            if (!success || hPrinter == IntPtr.Zero)
            {
                AlertBox(Color.LightCoral, Color.Red, "Error", "Printer is not available. Please check the connection.", Properties.Resources.error);
                return;
            }

            // Prepare to print
            DOCINFO docInfo = new DOCINFO
            {
                pDocName = "My Print Job",
                pOutputFile = null,
                pDatatype = null
            };

            // Start the document
            if (!StartDocPrinter(hPrinter, 1, docInfo))
            {
                AlertBox(Color.LightCoral, Color.Red, "Error", "Could not start the print job.", Properties.Resources.error);
                ClosePrinter(hPrinter);
                return;
            }

            // Start the page
            if (!StartPagePrinter(hPrinter))
            {
                AlertBox(Color.LightCoral, Color.Red, "Error", "Could not start the print page.", Properties.Resources.error);
                EndDocPrinter(hPrinter);
                ClosePrinter(hPrinter);
                return;
            }

            // Convert string command to byte array
            byte[] bytes = Encoding.ASCII.GetBytes(command);
            int written;
            bool printSuccess = WritePrinter(hPrinter, bytes, bytes.Length, out written);

            // End the page and document
            EndPagePrinter(hPrinter);
            EndDocPrinter(hPrinter);
            ClosePrinter(hPrinter);

            // Check if printing was successful
            if (printSuccess && written > 0)
            {
                AlertBox(Color.LightGreen, Color.SeaGreen, "Print Receipt", "Thank you for Coming!", Properties.Resources.success);

            }
            else
            {
                AlertBox(Color.LightCoral, Color.Red, "Error", "Failed to print the receipt. Please check the printer.", Properties.Resources.error);
            }
        }


        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            string command = "\x1B\x40"; // ESC @ to initialize the printer

            // Add a header
            command += "         SMTC Dental Care      \n"; // Centered clinic name
            command += "       Ynares, DMJ Bldg, A.    \n";
            command += "      Mabini St, Rodriguez,    \n";
            command += "             Rizal             \n";
            command += "         0933 821 2439         \n";
            command += "                               \n";
            command += "     P4JR+4J4, L.M. Santos St  \n";
            command += "       Rosario, Rodriguez,     \n";
            command += "           1860 Rizal          \n";
            command += "         0933 821 2439         \n";
            command += "-------------------------------\n";

            string fullname = txtFullname.Text;
            string branch = txtBranch.Text;
            string services = txtServices.Text;
            string status = txtStatus.Text;

            command += $"Fullname            {fullname}\n";
            command += $"Branch              {branch}  \n";
            command += $"Service(s)          {services}\n";
            command += $"Status              {status}  \n";

            decimal price = 0;
            decimal extraFee = 0;

            if (!decimal.TryParse(txtPrice.Text.Replace("₱", "").Replace(",", "").Trim(), out price))
            {
                return;
            }

            if (!decimal.TryParse(txtExtraFee.Text.Replace("₱", "").Replace(",", "").Trim(), out extraFee))
            {
                AlertBox(Color.LightCoral, Color.Red, "Error Extra Fee Value", "Invalid extra fee value!", Properties.Resources.error);

                return;
            }

            // Add items dynamically (Price and Extra Fee)
            command += "-------------------------------\n";
            command += $"Price               P{price:N2}\n";
            command += $"Extra Fee           P{extraFee:N2}\n";
            command += "-------------------------------\n";

            // Add total dynamically
            decimal total = price + extraFee;
            command += $"Total               P{total:N2}\n";
            command += "-------------------------------\n";

            // Add footer
            command += "   Thank you for visiting!      \n";
            command += "      Please come again!        \n";
            command += "\n\n"; // Additional line breaks

            // Send to printer
            SendCommandToPrinter(command);
        }



        private void txtExtraFee_TextChanged(object sender, EventArgs e)
        {

            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                    return;

                int originalSelectionStart = textBox.SelectionStart;
                int originalLength = textBox.Text.Length;

                string rawText = textBox.Text.Replace("₱", "").Replace(",", "").Trim();

                if (decimal.TryParse(rawText, out decimal value))
                {
                    textBox.Text = "₱" + value.ToString("N2");

                    int newLength = textBox.Text.Length;
                    int lengthDifference = newLength - originalLength;

                    textBox.SelectionStart = originalSelectionStart + lengthDifference;
                }
                else
                {
                    textBox.Text = "₱";
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }

            decimal price = 0m;
            decimal extraFee = 0m;

            if (decimal.TryParse(txtPrice.Text.Replace("₱", "").Replace(",", "").Trim(), out price) &&
                decimal.TryParse(txtExtraFee.Text.Replace("₱", "").Replace(",", "").Trim(), out extraFee))
            {
                decimal total = price + extraFee;
                txtTotal.Text = "₱" + total.ToString("N2");
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for Price and Extra Fee.");
            }
        }

        private void txtExtraFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is MaterialSkin.Controls.MaterialTextBox textBox)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtExtraFee_Leave(object sender, EventArgs e)
        {
            if (sender is MaterialSkin.Controls.MaterialTextBox textBox)
            {
                string rawText = textBox.Text.Replace("₱", "").Replace(",", "").Trim();

                if (decimal.TryParse(rawText, out decimal value))
                {
                    textBox.Text = "₱" + value.ToString("N2");
                }
                else
                {
                    textBox.Text = "₱0.00";
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                    return;

                int originalSelectionStart = textBox.SelectionStart;
                int originalLength = textBox.Text.Length;

                // Remove peso symbol and commas for parsing
                string rawText = textBox.Text.Replace("₱", "").Replace(",", "").Trim();

                if (decimal.TryParse(rawText, out decimal price))
                {
                    // Reformat the input text with peso symbol and two decimal places
                    textBox.Text = "₱" + price.ToString("N2");

                    // Adjust cursor position after reformatting
                    int newLength = textBox.Text.Length;
                    int lengthDifference = newLength - originalLength;
                    textBox.SelectionStart = originalSelectionStart + lengthDifference;

                    // Now calculate the total (price + extra fee)
                    decimal extraFee = 0m;
                    // Parse the extra fee if available
                    if (decimal.TryParse(txtExtraFee.Text.Replace("₱", "").Replace(",", "").Trim(), out extraFee))
                    {
                        // Calculate the total
                        decimal total = price + extraFee;
                        txtTotal.Text = "₱" + total.ToString("N2");
                    }
                    else
                    {
                        // If extra fee is not a valid number, just show the price as total
                        txtTotal.Text = "₱" + price.ToString("N2");
                    }
                }
                else
                {
                    // If the input is invalid, reset the text and set cursor at the end
                    textBox.Text = "₱";
                    textBox.SelectionStart = textBox.Text.Length;
                    txtTotal.Text = "₱0.00"; // Reset total as well
                }
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is MaterialSkin.Controls.MaterialTextBox textBox)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (sender is MaterialSkin.Controls.MaterialTextBox textBox)
            {
                string rawText = textBox.Text.Replace("₱", "").Replace(",", "").Trim();

                if (decimal.TryParse(rawText, out decimal value))
                {
                    textBox.Text = "₱" + value.ToString("N2");
                }
                else
                {
                    textBox.Text = "₱0.00";
                }
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                    return;

                int originalSelectionStart = textBox.SelectionStart;
                int originalLength = textBox.Text.Length;

                string rawText = textBox.Text.Replace("₱", "").Replace(",", "").Trim();

                if (decimal.TryParse(rawText, out decimal value))
                {
                    textBox.Text = "₱" + value.ToString("N2");

                    int newLength = textBox.Text.Length;
                    int lengthDifference = newLength - originalLength;

                    textBox.SelectionStart = originalSelectionStart + lengthDifference;
                }
                else
                {
                    textBox.Text = "₱";
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is MaterialSkin.Controls.MaterialTextBox textBox)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            if (sender is MaterialSkin.Controls.MaterialTextBox textBox)
            {
                string rawText = textBox.Text.Replace("₱", "").Replace(",", "").Trim();

                if (decimal.TryParse(rawText, out decimal value))
                {
                    textBox.Text = "₱" + value.ToString("N2");
                }
                else
                {
                    textBox.Text = "₱0.00";
                }
            }
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
