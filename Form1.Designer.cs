namespace WaterSprinkler
{
    partial class Form1
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
            this.btn_Sched = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Tabs = new System.Windows.Forms.Panel();
            this.btn_Simulate = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.pnl_Insertsched = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_Water = new System.Windows.Forms.TextBox();
            this.btn_Insertimg = new System.Windows.Forms.Button();
            this.btn_Remimg = new System.Windows.Forms.Button();
            this.imagePlant = new System.Windows.Forms.PictureBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbx_Day = new System.Windows.Forms.GroupBox();
            this.chk_Fri = new System.Windows.Forms.CheckBox();
            this.chk_Sat = new System.Windows.Forms.CheckBox();
            this.chk_Thu = new System.Windows.Forms.CheckBox();
            this.chk_Wed = new System.Windows.Forms.CheckBox();
            this.chk_Tue = new System.Windows.Forms.CheckBox();
            this.chk_Mon = new System.Windows.Forms.CheckBox();
            this.chk_Sun = new System.Windows.Forms.CheckBox();
            this.tbx_Min = new System.Windows.Forms.TextBox();
            this.cbx_Modula = new System.Windows.Forms.ComboBox();
            this.tbx_Hour = new System.Windows.Forms.TextBox();
            this.tbx_Pname = new System.Windows.Forms.TextBox();
            this.pnl_Schedule = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pnl_Tabs.SuspendLayout();
            this.pnl_Insertsched.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlant)).BeginInit();
            this.gbx_Day.SuspendLayout();
            this.pnl_Schedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sched
            // 
            this.btn_Sched.Location = new System.Drawing.Point(15, 94);
            this.btn_Sched.Name = "btn_Sched";
            this.btn_Sched.Size = new System.Drawing.Size(146, 42);
            this.btn_Sched.TabIndex = 0;
            this.btn_Sched.Text = "Insert Schedule";
            this.btn_Sched.UseVisualStyleBackColor = true;
            this.btn_Sched.Click += new System.EventHandler(this.btn_Sched_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "6oLD3N 5#oW3r";
            // 
            // pnl_Tabs
            // 
            this.pnl_Tabs.Controls.Add(this.btn_Simulate);
            this.pnl_Tabs.Controls.Add(this.btn_Edit);
            this.pnl_Tabs.Controls.Add(this.label1);
            this.pnl_Tabs.Controls.Add(this.btn_Sched);
            this.pnl_Tabs.Location = new System.Drawing.Point(-1, 1);
            this.pnl_Tabs.Name = "pnl_Tabs";
            this.pnl_Tabs.Size = new System.Drawing.Size(727, 148);
            this.pnl_Tabs.TabIndex = 2;
            // 
            // btn_Simulate
            // 
            this.btn_Simulate.Location = new System.Drawing.Point(338, 94);
            this.btn_Simulate.Name = "btn_Simulate";
            this.btn_Simulate.Size = new System.Drawing.Size(146, 42);
            this.btn_Simulate.TabIndex = 3;
            this.btn_Simulate.Text = "Simulation";
            this.btn_Simulate.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(176, 94);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(146, 42);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Schedule Manager";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // pnl_Insertsched
            // 
            this.pnl_Insertsched.Controls.Add(this.pnl_Schedule);
            this.pnl_Insertsched.Controls.Add(this.label7);
            this.pnl_Insertsched.Controls.Add(this.label6);
            this.pnl_Insertsched.Controls.Add(this.label5);
            this.pnl_Insertsched.Controls.Add(this.label4);
            this.pnl_Insertsched.Controls.Add(this.label3);
            this.pnl_Insertsched.Controls.Add(this.tbx_Water);
            this.pnl_Insertsched.Controls.Add(this.btn_Insertimg);
            this.pnl_Insertsched.Controls.Add(this.btn_Remimg);
            this.pnl_Insertsched.Controls.Add(this.imagePlant);
            this.pnl_Insertsched.Controls.Add(this.btn_Confirm);
            this.pnl_Insertsched.Controls.Add(this.btn_Clear);
            this.pnl_Insertsched.Controls.Add(this.label2);
            this.pnl_Insertsched.Controls.Add(this.gbx_Day);
            this.pnl_Insertsched.Controls.Add(this.tbx_Min);
            this.pnl_Insertsched.Controls.Add(this.cbx_Modula);
            this.pnl_Insertsched.Controls.Add(this.tbx_Hour);
            this.pnl_Insertsched.Controls.Add(this.tbx_Pname);
            this.pnl_Insertsched.Location = new System.Drawing.Point(2, 149);
            this.pnl_Insertsched.Name = "pnl_Insertsched";
            this.pnl_Insertsched.Size = new System.Drawing.Size(722, 428);
            this.pnl_Insertsched.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(225, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "mL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Amount of Water:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Time/Day:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Plant Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Schedule Info:";
            // 
            // tbx_Water
            // 
            this.tbx_Water.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Water.Location = new System.Drawing.Point(70, 295);
            this.tbx_Water.Name = "tbx_Water";
            this.tbx_Water.Size = new System.Drawing.Size(141, 26);
            this.tbx_Water.TabIndex = 21;
            // 
            // btn_Insertimg
            // 
            this.btn_Insertimg.Location = new System.Drawing.Point(540, 287);
            this.btn_Insertimg.Name = "btn_Insertimg";
            this.btn_Insertimg.Size = new System.Drawing.Size(100, 29);
            this.btn_Insertimg.TabIndex = 20;
            this.btn_Insertimg.Text = "Insert";
            this.btn_Insertimg.UseVisualStyleBackColor = true;
            // 
            // btn_Remimg
            // 
            this.btn_Remimg.Location = new System.Drawing.Point(423, 287);
            this.btn_Remimg.Name = "btn_Remimg";
            this.btn_Remimg.Size = new System.Drawing.Size(100, 29);
            this.btn_Remimg.TabIndex = 19;
            this.btn_Remimg.Text = "Remove";
            this.btn_Remimg.UseVisualStyleBackColor = true;
            // 
            // imagePlant
            // 
            this.imagePlant.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagePlant.Location = new System.Drawing.Point(423, 33);
            this.imagePlant.Name = "imagePlant";
            this.imagePlant.Size = new System.Drawing.Size(217, 236);
            this.imagePlant.TabIndex = 18;
            this.imagePlant.TabStop = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(211, 352);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(117, 42);
            this.btn_Confirm.TabIndex = 17;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(70, 352);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(118, 42);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = ":";
            // 
            // gbx_Day
            // 
            this.gbx_Day.Controls.Add(this.chk_Fri);
            this.gbx_Day.Controls.Add(this.chk_Sat);
            this.gbx_Day.Controls.Add(this.chk_Thu);
            this.gbx_Day.Controls.Add(this.chk_Wed);
            this.gbx_Day.Controls.Add(this.chk_Tue);
            this.gbx_Day.Controls.Add(this.chk_Mon);
            this.gbx_Day.Controls.Add(this.chk_Sun);
            this.gbx_Day.Location = new System.Drawing.Point(72, 211);
            this.gbx_Day.Name = "gbx_Day";
            this.gbx_Day.Size = new System.Drawing.Size(269, 46);
            this.gbx_Day.TabIndex = 15;
            this.gbx_Day.TabStop = false;
            // 
            // chk_Fri
            // 
            this.chk_Fri.AutoSize = true;
            this.chk_Fri.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Fri.Location = new System.Drawing.Point(197, 4);
            this.chk_Fri.Name = "chk_Fri";
            this.chk_Fri.Size = new System.Drawing.Size(22, 31);
            this.chk_Fri.TabIndex = 13;
            this.chk_Fri.Text = "Fri";
            this.chk_Fri.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chk_Fri.UseVisualStyleBackColor = true;
            // 
            // chk_Sat
            // 
            this.chk_Sat.AutoSize = true;
            this.chk_Sat.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Sat.Location = new System.Drawing.Point(231, 4);
            this.chk_Sat.Name = "chk_Sat";
            this.chk_Sat.Size = new System.Drawing.Size(27, 31);
            this.chk_Sat.TabIndex = 12;
            this.chk_Sat.Text = "Sat";
            this.chk_Sat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chk_Sat.UseVisualStyleBackColor = true;
            // 
            // chk_Thu
            // 
            this.chk_Thu.AutoSize = true;
            this.chk_Thu.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Thu.Location = new System.Drawing.Point(156, 4);
            this.chk_Thu.Name = "chk_Thu";
            this.chk_Thu.Size = new System.Drawing.Size(30, 31);
            this.chk_Thu.TabIndex = 11;
            this.chk_Thu.Text = "Thu";
            this.chk_Thu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chk_Thu.UseVisualStyleBackColor = true;
            // 
            // chk_Wed
            // 
            this.chk_Wed.AutoSize = true;
            this.chk_Wed.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Wed.Location = new System.Drawing.Point(116, 4);
            this.chk_Wed.Name = "chk_Wed";
            this.chk_Wed.Size = new System.Drawing.Size(34, 31);
            this.chk_Wed.TabIndex = 10;
            this.chk_Wed.Text = "Wed";
            this.chk_Wed.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chk_Wed.UseVisualStyleBackColor = true;
            // 
            // chk_Tue
            // 
            this.chk_Tue.AutoSize = true;
            this.chk_Tue.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Tue.Location = new System.Drawing.Point(80, 4);
            this.chk_Tue.Name = "chk_Tue";
            this.chk_Tue.Size = new System.Drawing.Size(30, 31);
            this.chk_Tue.TabIndex = 9;
            this.chk_Tue.Text = "Tue";
            this.chk_Tue.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chk_Tue.UseVisualStyleBackColor = true;
            // 
            // chk_Mon
            // 
            this.chk_Mon.AutoSize = true;
            this.chk_Mon.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Mon.Location = new System.Drawing.Point(42, 4);
            this.chk_Mon.Name = "chk_Mon";
            this.chk_Mon.Size = new System.Drawing.Size(32, 31);
            this.chk_Mon.TabIndex = 8;
            this.chk_Mon.Text = "Mon";
            this.chk_Mon.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chk_Mon.UseVisualStyleBackColor = true;
            // 
            // chk_Sun
            // 
            this.chk_Sun.AutoSize = true;
            this.chk_Sun.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_Sun.Location = new System.Drawing.Point(6, 4);
            this.chk_Sun.Name = "chk_Sun";
            this.chk_Sun.Size = new System.Drawing.Size(30, 31);
            this.chk_Sun.TabIndex = 7;
            this.chk_Sun.Text = "Sun";
            this.chk_Sun.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chk_Sun.UseVisualStyleBackColor = true;
            // 
            // tbx_Min
            // 
            this.tbx_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Min.Location = new System.Drawing.Point(164, 177);
            this.tbx_Min.Name = "tbx_Min";
            this.tbx_Min.Size = new System.Drawing.Size(66, 26);
            this.tbx_Min.TabIndex = 14;
            // 
            // cbx_Modula
            // 
            this.cbx_Modula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Modula.FormattingEnabled = true;
            this.cbx_Modula.Location = new System.Drawing.Point(260, 177);
            this.cbx_Modula.Name = "cbx_Modula";
            this.cbx_Modula.Size = new System.Drawing.Size(68, 28);
            this.cbx_Modula.TabIndex = 5;
            // 
            // tbx_Hour
            // 
            this.tbx_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Hour.Location = new System.Drawing.Point(70, 177);
            this.tbx_Hour.Name = "tbx_Hour";
            this.tbx_Hour.Size = new System.Drawing.Size(66, 26);
            this.tbx_Hour.TabIndex = 4;
            // 
            // tbx_Pname
            // 
            this.tbx_Pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Pname.Location = new System.Drawing.Point(70, 115);
            this.tbx_Pname.Name = "tbx_Pname";
            this.tbx_Pname.Size = new System.Drawing.Size(258, 26);
            this.tbx_Pname.TabIndex = 0;
            // 
            // pnl_Schedule
            // 
            this.pnl_Schedule.Controls.Add(this.radioButton1);
            this.pnl_Schedule.Location = new System.Drawing.Point(-3, 0);
            this.pnl_Schedule.Name = "pnl_Schedule";
            this.pnl_Schedule.Size = new System.Drawing.Size(727, 428);
            this.pnl_Schedule.TabIndex = 26;
            this.pnl_Schedule.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(62, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 577);
            this.Controls.Add(this.pnl_Insertsched);
            this.Controls.Add(this.pnl_Tabs);
            this.Name = "Form1";
            this.Text = "Water Sprinker";
            this.pnl_Tabs.ResumeLayout(false);
            this.pnl_Tabs.PerformLayout();
            this.pnl_Insertsched.ResumeLayout(false);
            this.pnl_Insertsched.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlant)).EndInit();
            this.gbx_Day.ResumeLayout(false);
            this.gbx_Day.PerformLayout();
            this.pnl_Schedule.ResumeLayout(false);
            this.pnl_Schedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Sched;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Tabs;
        private System.Windows.Forms.Button btn_Simulate;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Panel pnl_Insertsched;
        private System.Windows.Forms.TextBox tbx_Hour;
        private System.Windows.Forms.TextBox tbx_Pname;
        private System.Windows.Forms.ComboBox cbx_Modula;
        private System.Windows.Forms.CheckBox chk_Sun;
        private System.Windows.Forms.CheckBox chk_Wed;
        private System.Windows.Forms.CheckBox chk_Tue;
        private System.Windows.Forms.CheckBox chk_Mon;
        private System.Windows.Forms.CheckBox chk_Thu;
        private System.Windows.Forms.CheckBox chk_Fri;
        private System.Windows.Forms.CheckBox chk_Sat;
        private System.Windows.Forms.TextBox tbx_Min;
        private System.Windows.Forms.GroupBox gbx_Day;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.PictureBox imagePlant;
        private System.Windows.Forms.TextBox tbx_Water;
        private System.Windows.Forms.Button btn_Insertimg;
        private System.Windows.Forms.Button btn_Remimg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl_Schedule;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

