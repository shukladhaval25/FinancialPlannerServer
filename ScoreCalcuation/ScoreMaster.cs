using DevExpress.XtraEditors;
using FinancialPlanner.Common.Model.ScoreCalculation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer.ScoreCalcuation
{
    public partial class ScoreMaster : XtraForm
    {
        DataTable dtScore = new DataTable();
       
        public ScoreMaster()
        {
            InitializeComponent();
        }

        private void ScoreMaster_Load(object sender, EventArgs e)
        {
            dtScore = new ScoreInfo().GetScore();
            vGridScope.DataSource = dtScore;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vGridScope.AddNewRecord();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Score> scores = new List<Score>();
            foreach(DataRow dataRow in dtScore.Rows)
            {
                Score score = new Score();
                score.Id = (dataRow["Id"] != DBNull.Value ) ? int.Parse(dataRow["Id"].ToString()) : 0;
                score.Title = dataRow["Title"].ToString();
                score.MaxValue = float.Parse(dataRow["MaxValue"].ToString());
                score.MinValue = float.Parse(dataRow["MinValue"].ToString());
                score.Weightage = float.Parse(dataRow["Weightage"].ToString());
                scores.Add(score);
            }
            ScoreInfo scoreInfo = new ScoreInfo();
            bool blnSave = scoreInfo.Add(scores);
            if (blnSave)
            {
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayScores();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = vGridScope.FocusedRecord;
            if (XtraMessageBox.Show("Are you sure, you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (vGridScope.GetCellValue(vGridScope.GetRowByFieldName("Id"), rowIndex) != null)
                {
                    int Id = int.Parse(vGridScope.GetCellValue(vGridScope.GetRowByFieldName("Id"), rowIndex).ToString());
                    Score score = new Score();
                    score.Id = Id;
                    ScoreInfo scoreInfo = new ScoreInfo();
                    scoreInfo.Delete(score);
                    displayScores();
                }
            }

        }

        private void displayScores()
        {
            dtScore = new ScoreInfo().GetScore();
            vGridScope.DataSource = dtScore;
        }
    }
}
