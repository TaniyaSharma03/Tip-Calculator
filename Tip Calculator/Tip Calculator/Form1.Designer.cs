namespace Tip_Calculator
{
    partial class Tip_Calculator
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Bill = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.Label();
            this.People = new System.Windows.Forms.Label();
            this.bill_amount = new System.Windows.Forms.TextBox();
            this.tip_amount = new System.Windows.Forms.TextBox();
            this.no_of_people = new System.Windows.Forms.TextBox();
            this.tip_decrease = new System.Windows.Forms.Button();
            this.people_decrease = new System.Windows.Forms.Button();
            this.tip_increase = new System.Windows.Forms.Button();
            this.people_increase = new System.Windows.Forms.Button();
            this.tip_per_person = new System.Windows.Forms.Label();
            this.amount_per_person = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tip_amount_per_person = new System.Windows.Forms.TextBox();
            this.Total_amount_per_person = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(280, 303);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // Bill
            // 
            this.Bill.AutoSize = true;
            this.Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bill.Location = new System.Drawing.Point(36, 36);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(34, 24);
            this.Bill.TabIndex = 1;
            this.Bill.Text = "Bill";
            // 
            // Tip
            // 
            this.Tip.AutoSize = true;
            this.Tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tip.Location = new System.Drawing.Point(36, 120);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(57, 24);
            this.Tip.TabIndex = 2;
            this.Tip.Text = "Tip %";
            // 
            // People
            // 
            this.People.AutoSize = true;
            this.People.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.People.Location = new System.Drawing.Point(36, 197);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(164, 24);
            this.People.TabIndex = 3;
            this.People.Text = "Number of People";
            // 
            // bill_amount
            // 
            this.bill_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_amount.Location = new System.Drawing.Point(41, 71);
            this.bill_amount.MaxLength = 8;
            this.bill_amount.Name = "bill_amount";
            this.bill_amount.Size = new System.Drawing.Size(196, 29);
            this.bill_amount.TabIndex = 4;
            this.bill_amount.Text = "0.00";
            this.bill_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bill_amount.Click += new System.EventHandler(this.bill_clear);
            this.bill_amount.TextChanged += new System.EventHandler(this.tip_calculate);
            this.bill_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keys);
            // 
            // tip_amount
            // 
            this.tip_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_amount.Location = new System.Drawing.Point(40, 156);
            this.tip_amount.MaxLength = 3;
            this.tip_amount.Name = "tip_amount";
            this.tip_amount.Size = new System.Drawing.Size(196, 29);
            this.tip_amount.TabIndex = 5;
            this.tip_amount.Text = "0";
            this.tip_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tip_amount.Click += new System.EventHandler(this.Clear_tip);
            this.tip_amount.TextChanged += new System.EventHandler(this.tip_calculate);
            // 
            // no_of_people
            // 
            this.no_of_people.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_people.Location = new System.Drawing.Point(40, 237);
            this.no_of_people.Name = "no_of_people";
            this.no_of_people.Size = new System.Drawing.Size(196, 29);
            this.no_of_people.TabIndex = 6;
            this.no_of_people.Text = "1";
            this.no_of_people.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.no_of_people.TextChanged += new System.EventHandler(this.tip_calculate);
            // 
            // tip_decrease
            // 
            this.tip_decrease.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tip_decrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_decrease.Location = new System.Drawing.Point(40, 156);
            this.tip_decrease.Name = "tip_decrease";
            this.tip_decrease.Size = new System.Drawing.Size(29, 29);
            this.tip_decrease.TabIndex = 7;
            this.tip_decrease.Text = "-";
            this.tip_decrease.UseVisualStyleBackColor = false;
            this.tip_decrease.Click += new System.EventHandler(this.tip_decrease_Click);
            // 
            // people_decrease
            // 
            this.people_decrease.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.people_decrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.people_decrease.Location = new System.Drawing.Point(40, 237);
            this.people_decrease.Name = "people_decrease";
            this.people_decrease.Size = new System.Drawing.Size(29, 29);
            this.people_decrease.TabIndex = 8;
            this.people_decrease.Text = "-";
            this.people_decrease.UseVisualStyleBackColor = false;
            this.people_decrease.Click += new System.EventHandler(this.people_decrease_Click);
            // 
            // tip_increase
            // 
            this.tip_increase.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tip_increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_increase.Location = new System.Drawing.Point(207, 156);
            this.tip_increase.Name = "tip_increase";
            this.tip_increase.Size = new System.Drawing.Size(29, 29);
            this.tip_increase.TabIndex = 9;
            this.tip_increase.Text = "+";
            this.tip_increase.UseVisualStyleBackColor = false;
            this.tip_increase.Click += new System.EventHandler(this.tip_increase_Click);
            // 
            // people_increase
            // 
            this.people_increase.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.people_increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.people_increase.Location = new System.Drawing.Point(208, 237);
            this.people_increase.Name = "people_increase";
            this.people_increase.Size = new System.Drawing.Size(29, 29);
            this.people_increase.TabIndex = 10;
            this.people_increase.Text = "+";
            this.people_increase.UseVisualStyleBackColor = false;
            this.people_increase.Click += new System.EventHandler(this.people_increase_Click);
            // 
            // tip_per_person
            // 
            this.tip_per_person.AutoSize = true;
            this.tip_per_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_per_person.Location = new System.Drawing.Point(315, 73);
            this.tip_per_person.Name = "tip_per_person";
            this.tip_per_person.Size = new System.Drawing.Size(49, 29);
            this.tip_per_person.TabIndex = 11;
            this.tip_per_person.Text = "Tip";
            // 
            // amount_per_person
            // 
            this.amount_per_person.AutoSize = true;
            this.amount_per_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_per_person.Location = new System.Drawing.Point(315, 176);
            this.amount_per_person.Name = "amount_per_person";
            this.amount_per_person.Size = new System.Drawing.Size(68, 29);
            this.amount_per_person.TabIndex = 12;
            this.amount_per_person.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(317, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "per person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(317, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "per person";
            // 
            // tip_amount_per_person
            // 
            this.tip_amount_per_person.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tip_amount_per_person.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tip_amount_per_person.Enabled = false;
            this.tip_amount_per_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_amount_per_person.ForeColor = System.Drawing.Color.Black;
            this.tip_amount_per_person.Location = new System.Drawing.Point(414, 76);
            this.tip_amount_per_person.Name = "tip_amount_per_person";
            this.tip_amount_per_person.Size = new System.Drawing.Size(222, 33);
            this.tip_amount_per_person.TabIndex = 15;
            this.tip_amount_per_person.Text = "$0.00";
            this.tip_amount_per_person.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Total_amount_per_person
            // 
            this.Total_amount_per_person.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Total_amount_per_person.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Total_amount_per_person.Enabled = false;
            this.Total_amount_per_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_amount_per_person.ForeColor = System.Drawing.Color.Black;
            this.Total_amount_per_person.Location = new System.Drawing.Point(414, 176);
            this.Total_amount_per_person.Name = "Total_amount_per_person";
            this.Total_amount_per_person.Size = new System.Drawing.Size(222, 40);
            this.Total_amount_per_person.TabIndex = 16;
            this.Total_amount_per_person.Text = "$0.00";
            this.Total_amount_per_person.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tip_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(669, 303);
            this.Controls.Add(this.Total_amount_per_person);
            this.Controls.Add(this.tip_amount_per_person);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amount_per_person);
            this.Controls.Add(this.tip_per_person);
            this.Controls.Add(this.people_increase);
            this.Controls.Add(this.tip_increase);
            this.Controls.Add(this.people_decrease);
            this.Controls.Add(this.tip_decrease);
            this.Controls.Add(this.no_of_people);
            this.Controls.Add(this.tip_amount);
            this.Controls.Add(this.bill_amount);
            this.Controls.Add(this.People);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.Bill);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tip_Calculator";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label Bill;
        private System.Windows.Forms.Label Tip;
        private System.Windows.Forms.Label People;
        private System.Windows.Forms.TextBox bill_amount;
        private System.Windows.Forms.TextBox tip_amount;
        private System.Windows.Forms.TextBox no_of_people;
        private System.Windows.Forms.Button tip_decrease;
        private System.Windows.Forms.Button people_decrease;
        private System.Windows.Forms.Button tip_increase;
        private System.Windows.Forms.Button people_increase;
        private System.Windows.Forms.Label tip_per_person;
        private System.Windows.Forms.Label amount_per_person;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tip_amount_per_person;
        private System.Windows.Forms.TextBox Total_amount_per_person;
    }
}

