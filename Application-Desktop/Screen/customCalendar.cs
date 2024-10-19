using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Desktop.Screen
{
    public partial class customCalendar : Form
    {
        public customCalendar()
        {
            InitializeComponent();
        }

        private void customCalendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private int month = DateTime.Now.Month;
        private int year = DateTime.Now.Year;
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            LoadDaysForMonth(month, year);
        }
        private void LoadDaysForMonth(int month, int year)
        {
            try
            {
                DateTime startOfTheMonth = new DateTime(year, month, 1);
                int daysInMonth = DateTime.DaysInMonth(year, month);
                int dayOfWeek = (int)startOfTheMonth.DayOfWeek;

                dayContainer.Controls.Clear();

                int currentDay = DateTime.Now.Day;

                for (int i = 0; i < dayOfWeek; i++)
                {
                    days empty = new days();
                    dayContainer.Controls.Add(empty);
                }

                for (int i = 1; i <= daysInMonth; i++)
                {
                    UserControlDays ucDays = new UserControlDays();
                    ucDays.daysll(i);

                    if (i == currentDay && month == DateTime.Now.Month && year == DateTime.Now.Year)
                    {
                        ucDays.HighlightToday();
                    }

                    dayContainer.Controls.Add(ucDays);
                }

                string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lblDate.Text = monthname + " " + year;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Error loading days: {ex.Message}");
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }

            LoadDaysForMonth(month, year);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }

            LoadDaysForMonth(month, year);
        }
    }
}
