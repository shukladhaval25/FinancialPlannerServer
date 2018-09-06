namespace FinancialPlannerServer.EmailJob
{
    partial class EmailScheduleInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailScheduleInfo));
            this.grpEmailSchedule = new System.Windows.Forms.GroupBox();
            this.grpEmailArticles = new System.Windows.Forms.GroupBox();
            this.lstArticles = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtStarDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.grpMonthly = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numMonthDay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.grpWeekly = new System.Windows.Forms.GroupBox();
            this.chkSunday = new System.Windows.Forms.CheckBox();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.cmbRecurrence = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkArticles = new System.Windows.Forms.LinkLabel();
            this.cmbArticleGroup = new System.Windows.Forms.ComboBox();
            this.lblArticleGroup = new System.Windows.Forms.Label();
            this.txtScheduleName = new System.Windows.Forms.TextBox();
            this.lblScheduleNameTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.imgCollection16x16 = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.grpEmailSchedule.SuspendLayout();
            this.grpEmailArticles.SuspendLayout();
            this.grpMonthly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthDay)).BeginInit();
            this.grpWeekly.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmailSchedule
            // 
            this.grpEmailSchedule.Controls.Add(this.grpEmailArticles);
            this.grpEmailSchedule.Controls.Add(this.dateTimePicker1);
            this.grpEmailSchedule.Controls.Add(this.label5);
            this.grpEmailSchedule.Controls.Add(this.dtStarDate);
            this.grpEmailSchedule.Controls.Add(this.label4);
            this.grpEmailSchedule.Controls.Add(this.grpMonthly);
            this.grpEmailSchedule.Controls.Add(this.grpWeekly);
            this.grpEmailSchedule.Controls.Add(this.cmbRecurrence);
            this.grpEmailSchedule.Controls.Add(this.label1);
            this.grpEmailSchedule.Controls.Add(this.lnkArticles);
            this.grpEmailSchedule.Controls.Add(this.cmbArticleGroup);
            this.grpEmailSchedule.Controls.Add(this.lblArticleGroup);
            this.grpEmailSchedule.Controls.Add(this.txtScheduleName);
            this.grpEmailSchedule.Controls.Add(this.lblScheduleNameTitle);
            this.grpEmailSchedule.Location = new System.Drawing.Point(13, 13);
            this.grpEmailSchedule.Name = "grpEmailSchedule";
            this.grpEmailSchedule.Size = new System.Drawing.Size(722, 255);
            this.grpEmailSchedule.TabIndex = 0;
            this.grpEmailSchedule.TabStop = false;
            this.grpEmailSchedule.Text = "Email Schedule Info";
            // 
            // grpEmailArticles
            // 
            this.grpEmailArticles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpEmailArticles.Controls.Add(this.lstArticles);
            this.grpEmailArticles.Location = new System.Drawing.Point(454, 19);
            this.grpEmailArticles.Name = "grpEmailArticles";
            this.grpEmailArticles.Size = new System.Drawing.Size(262, 230);
            this.grpEmailArticles.TabIndex = 13;
            this.grpEmailArticles.TabStop = false;
            this.grpEmailArticles.Text = "Email Articles";
            this.grpEmailArticles.Visible = false;
            // 
            // lstArticles
            // 
            this.lstArticles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstArticles.FormattingEnabled = true;
            this.lstArticles.Location = new System.Drawing.Point(6, 20);
            this.lstArticles.Name = "lstArticles";
            this.lstArticles.Size = new System.Drawing.Size(250, 199);
            this.lstArticles.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2018, 7, 27, 10, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start Time:";
            // 
            // dtStarDate
            // 
            this.dtStarDate.Location = new System.Drawing.Point(132, 89);
            this.dtStarDate.Name = "dtStarDate";
            this.dtStarDate.Size = new System.Drawing.Size(187, 20);
            this.dtStarDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start Date:";
            // 
            // grpMonthly
            // 
            this.grpMonthly.Controls.Add(this.label3);
            this.grpMonthly.Controls.Add(this.numMonthDay);
            this.grpMonthly.Controls.Add(this.label2);
            this.grpMonthly.Location = new System.Drawing.Point(131, 169);
            this.grpMonthly.Name = "grpMonthly";
            this.grpMonthly.Size = new System.Drawing.Size(317, 47);
            this.grpMonthly.TabIndex = 8;
            this.grpMonthly.TabStop = false;
            this.grpMonthly.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Of:";
            // 
            // numMonthDay
            // 
            this.numMonthDay.Location = new System.Drawing.Point(41, 14);
            this.numMonthDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numMonthDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonthDay.Name = "numMonthDay";
            this.numMonthDay.Size = new System.Drawing.Size(55, 20);
            this.numMonthDay.TabIndex = 7;
            this.numMonthDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Day ";
            // 
            // grpWeekly
            // 
            this.grpWeekly.Controls.Add(this.chkSunday);
            this.grpWeekly.Controls.Add(this.chkSaturday);
            this.grpWeekly.Controls.Add(this.chkFriday);
            this.grpWeekly.Controls.Add(this.chkThursday);
            this.grpWeekly.Controls.Add(this.chkWednesday);
            this.grpWeekly.Controls.Add(this.chkTuesday);
            this.grpWeekly.Controls.Add(this.chkMonday);
            this.grpWeekly.Location = new System.Drawing.Point(131, 169);
            this.grpWeekly.Name = "grpWeekly";
            this.grpWeekly.Size = new System.Drawing.Size(317, 68);
            this.grpWeekly.TabIndex = 7;
            this.grpWeekly.TabStop = false;
            this.grpWeekly.Visible = false;
            // 
            // chkSunday
            // 
            this.chkSunday.AutoSize = true;
            this.chkSunday.Location = new System.Drawing.Point(150, 42);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(62, 17);
            this.chkSunday.TabIndex = 6;
            this.chkSunday.Text = "Sunday";
            this.chkSunday.UseVisualStyleBackColor = true;
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.Location = new System.Drawing.Point(76, 42);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(68, 17);
            this.chkSaturday.TabIndex = 5;
            this.chkSaturday.Text = "Saturday";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // chkFriday
            // 
            this.chkFriday.AutoSize = true;
            this.chkFriday.Location = new System.Drawing.Point(6, 42);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(54, 17);
            this.chkFriday.TabIndex = 4;
            this.chkFriday.Text = "Friday";
            this.chkFriday.UseVisualStyleBackColor = true;
            // 
            // chkThursday
            // 
            this.chkThursday.AutoSize = true;
            this.chkThursday.Location = new System.Drawing.Point(238, 19);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(70, 17);
            this.chkThursday.TabIndex = 3;
            this.chkThursday.Text = "Thursday";
            this.chkThursday.UseVisualStyleBackColor = true;
            // 
            // chkWednesday
            // 
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Location = new System.Drawing.Point(149, 19);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(83, 17);
            this.chkWednesday.TabIndex = 2;
            this.chkWednesday.Text = "Wednesday";
            this.chkWednesday.UseVisualStyleBackColor = true;
            // 
            // chkTuesday
            // 
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Location = new System.Drawing.Point(76, 19);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(67, 17);
            this.chkTuesday.TabIndex = 1;
            this.chkTuesday.Text = "Tuesday";
            this.chkTuesday.UseVisualStyleBackColor = true;
            // 
            // chkMonday
            // 
            this.chkMonday.AutoSize = true;
            this.chkMonday.Location = new System.Drawing.Point(6, 19);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(64, 17);
            this.chkMonday.TabIndex = 0;
            this.chkMonday.Text = "Monday";
            this.chkMonday.UseVisualStyleBackColor = true;
            // 
            // cmbRecurrence
            // 
            this.cmbRecurrence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecurrence.FormattingEnabled = true;
            this.cmbRecurrence.Items.AddRange(new object[] {
            "Daily",
            "Monthly",
            "Weekly"});
            this.cmbRecurrence.Location = new System.Drawing.Point(131, 141);
            this.cmbRecurrence.Name = "cmbRecurrence";
            this.cmbRecurrence.Size = new System.Drawing.Size(187, 21);
            this.cmbRecurrence.TabIndex = 6;
            this.cmbRecurrence.SelectedIndexChanged += new System.EventHandler(this.cmbRecurrence_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recurrence:";
            // 
            // lnkArticles
            // 
            this.lnkArticles.AutoSize = true;
            this.lnkArticles.Location = new System.Drawing.Point(325, 70);
            this.lnkArticles.Name = "lnkArticles";
            this.lnkArticles.Size = new System.Drawing.Size(71, 13);
            this.lnkArticles.TabIndex = 4;
            this.lnkArticles.TabStop = true;
            this.lnkArticles.Text = "Show Articles";
            this.lnkArticles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkArticles_LinkClicked);
            // 
            // cmbArticleGroup
            // 
            this.cmbArticleGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticleGroup.FormattingEnabled = true;
            this.cmbArticleGroup.Location = new System.Drawing.Point(132, 62);
            this.cmbArticleGroup.Name = "cmbArticleGroup";
            this.cmbArticleGroup.Size = new System.Drawing.Size(187, 21);
            this.cmbArticleGroup.TabIndex = 3;
            // 
            // lblArticleGroup
            // 
            this.lblArticleGroup.AutoSize = true;
            this.lblArticleGroup.Location = new System.Drawing.Point(27, 65);
            this.lblArticleGroup.Name = "lblArticleGroup";
            this.lblArticleGroup.Size = new System.Drawing.Size(99, 13);
            this.lblArticleGroup.TabIndex = 2;
            this.lblArticleGroup.Text = "Email Article Group:";
            // 
            // txtScheduleName
            // 
            this.txtScheduleName.Location = new System.Drawing.Point(132, 36);
            this.txtScheduleName.Name = "txtScheduleName";
            this.txtScheduleName.Size = new System.Drawing.Size(187, 20);
            this.txtScheduleName.TabIndex = 1;
            // 
            // lblScheduleNameTitle
            // 
            this.lblScheduleNameTitle.AutoSize = true;
            this.lblScheduleNameTitle.Location = new System.Drawing.Point(26, 39);
            this.lblScheduleNameTitle.Name = "lblScheduleNameTitle";
            this.lblScheduleNameTitle.Size = new System.Drawing.Size(86, 13);
            this.lblScheduleNameTitle.TabIndex = 0;
            this.lblScheduleNameTitle.Text = "Schedule Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.ImageKey = "icons8-cancel-16.png";
            this.btnCancel.ImageList = this.imgCollection16x16;
            this.btnCancel.Location = new System.Drawing.Point(660, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // imgCollection16x16
            // 
            this.imgCollection16x16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCollection16x16.ImageStream")));
            this.imgCollection16x16.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCollection16x16.Images.SetKeyName(0, "Add-Action.png");
            this.imgCollection16x16.Images.SetKeyName(1, "delete.png");
            this.imgCollection16x16.Images.SetKeyName(2, "deleteline.png");
            this.imgCollection16x16.Images.SetKeyName(3, "drop-add.gif");
            this.imgCollection16x16.Images.SetKeyName(4, "Edit.png");
            this.imgCollection16x16.Images.SetKeyName(5, "icons8-search-16.png");
            this.imgCollection16x16.Images.SetKeyName(6, "icons8-cancel-16.png");
            this.imgCollection16x16.Images.SetKeyName(7, "icons8-save-close-16.png");
            this.imgCollection16x16.Images.SetKeyName(8, "icons8-magazine-30.png");
            this.imgCollection16x16.Images.SetKeyName(9, "icons8-automation-30.png");
            this.imgCollection16x16.Images.SetKeyName(10, "Run-1.png");
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.ImageKey = "icons8-save-close-16.png";
            this.btnSave.ImageList = this.imgCollection16x16;
            this.btnSave.Location = new System.Drawing.Point(579, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // EmailScheduleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 305);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpEmailSchedule);
            this.MinimizeBox = false;
            this.Name = "EmailScheduleInfo";
            this.Text = "Email Schedule";
            this.Load += new System.EventHandler(this.EmailScheduleInfo_Load);
            this.grpEmailSchedule.ResumeLayout(false);
            this.grpEmailSchedule.PerformLayout();
            this.grpEmailArticles.ResumeLayout(false);
            this.grpMonthly.ResumeLayout(false);
            this.grpMonthly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthDay)).EndInit();
            this.grpWeekly.ResumeLayout(false);
            this.grpWeekly.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmailSchedule;
        private System.Windows.Forms.GroupBox grpMonthly;
        private System.Windows.Forms.NumericUpDown numMonthDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpWeekly;
        private System.Windows.Forms.CheckBox chkSunday;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.ComboBox cmbRecurrence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkArticles;
        private System.Windows.Forms.ComboBox cmbArticleGroup;
        private System.Windows.Forms.Label lblArticleGroup;
        private System.Windows.Forms.TextBox txtScheduleName;
        private System.Windows.Forms.Label lblScheduleNameTitle;
        private System.Windows.Forms.DateTimePicker dtStarDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpEmailArticles;
        private System.Windows.Forms.ListBox lstArticles;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ImageList imgCollection16x16;
    }
}