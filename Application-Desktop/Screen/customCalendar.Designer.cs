namespace Application_Desktop.Screen
{
    partial class customCalendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dayContainer = new FlowLayoutPanel();
            btnNext = new Button();
            btnPrev = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblDate = new Label();
            SuspendLayout();
            // 
            // dayContainer
            // 
            dayContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dayContainer.BackColor = SystemColors.ButtonFace;
            dayContainer.Location = new Point(10, 88);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(770, 462);
            dayContainer.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(255, 128, 0);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = SystemColors.ControlLight;
            btnNext.Location = new Point(705, 556);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPrev.BackColor = Color.FromArgb(255, 128, 0);
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.ForeColor = SystemColors.ControlLight;
            btnPrev.Location = new Point(594, 556);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 23);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "Previous";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 55);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 3;
            label1.Text = "Sunday";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 55);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 4;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(351, 55);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 6;
            label3.Text = "Wednesday";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(253, 55);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 5;
            label4.Text = "Tuesday";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(594, 55);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 8;
            label5.Text = "Friday";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(471, 55);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 7;
            label6.Text = "Thursday";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(688, 55);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 9;
            label7.Text = "Saturday";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDate.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(199, 9);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(396, 36);
            lblDate.TabIndex = 10;
            lblDate.Text = "MONTH YEAR";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(793, 593);
            Controls.Add(lblDate);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(dayContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "customCalendar";
            Text = "customCalendar";
            Load += customCalendar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel dayContainer;
        private Button btnNext;
        private Button btnPrev;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblDate;
    }
}