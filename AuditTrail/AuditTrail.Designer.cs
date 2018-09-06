namespace FinancialPlannerServer.AuditTrail
{
    partial class AuditTrail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtGridAuditTrail = new System.Windows.Forms.DataGridView();
            this.TypeImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.StatusImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblAuditTrail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAuditTrail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridAuditTrail
            // 
            this.dtGridAuditTrail.AllowUserToAddRows = false;
            this.dtGridAuditTrail.AllowUserToDeleteRows = false;
            this.dtGridAuditTrail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridAuditTrail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridAuditTrail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAuditTrail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeImg,
            this.StatusImg});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridAuditTrail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridAuditTrail.Location = new System.Drawing.Point(12, 52);
            this.dtGridAuditTrail.MultiSelect = false;
            this.dtGridAuditTrail.Name = "dtGridAuditTrail";
            this.dtGridAuditTrail.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridAuditTrail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridAuditTrail.RowHeadersVisible = false;
            this.dtGridAuditTrail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridAuditTrail.Size = new System.Drawing.Size(651, 338);
            this.dtGridAuditTrail.TabIndex = 3;
            this.dtGridAuditTrail.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtGridAuditTrail_CellFormatting);
            // 
            // TypeImg
            // 
            this.TypeImg.HeaderText = "";
            this.TypeImg.Name = "TypeImg";
            this.TypeImg.ReadOnly = true;
            this.TypeImg.Width = 30;
            // 
            // StatusImg
            // 
            this.StatusImg.HeaderText = "";
            this.StatusImg.Name = "StatusImg";
            this.StatusImg.ReadOnly = true;
            this.StatusImg.Width = 30;
            // 
            // lblAuditTrail
            // 
            this.lblAuditTrail.AutoSize = true;
            this.lblAuditTrail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditTrail.Location = new System.Drawing.Point(50, 20);
            this.lblAuditTrail.Name = "lblAuditTrail";
            this.lblAuditTrail.Size = new System.Drawing.Size(110, 17);
            this.lblAuditTrail.TabIndex = 2;
            this.lblAuditTrail.Text = "Activities Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinancialPlannerServer.Properties.Resources.AuditTrail_30;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 34);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AuditTrail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtGridAuditTrail);
            this.Controls.Add(this.lblAuditTrail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuditTrail";
            this.ShowInTaskbar = false;
            this.Text = "AuditTrail";
            this.Load += new System.EventHandler(this.AuditTrail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAuditTrail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridAuditTrail;
        private System.Windows.Forms.Label lblAuditTrail;
        private System.Windows.Forms.DataGridViewImageColumn TypeImg;
        private System.Windows.Forms.DataGridViewImageColumn StatusImg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}