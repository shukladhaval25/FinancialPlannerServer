using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer.EmailJob
{
    public partial class EmailScheduleInfo : Form
    {
        public EmailScheduleInfo()
        {
            InitializeComponent();
        }

        private void cmbRecurrence_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRecurrence.Text == "Daily")
            {
                grpWeekly.Visible = false;
                grpMonthly.Visible = false;
            }
            else if (cmbRecurrence.Text == "Monthly")
            {
                grpWeekly.Visible = false;
                grpMonthly.Visible = true;
            }
            else if (cmbRecurrence.Text == "Weekly")
            {
                grpWeekly.Visible = true;
                grpMonthly.Visible = false;
            }
        }

        private void EmailScheduleInfo_Load(object sender, EventArgs e)
        {
            fillupEmailArticleGroup();
        }

        private void fillupEmailArticleGroup()
        {
            
        }

        private void lnkArticles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if (lnkArticles.Text == "Show Articles")
            {
                lnkArticles.Text = "Hide Articles";
                grpEmailArticles.Visible = true;
            }
            else
            {
                lnkArticles.Text = "Show Articles";
                grpEmailArticles.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
