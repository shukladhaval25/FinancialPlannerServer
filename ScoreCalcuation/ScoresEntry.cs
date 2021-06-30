using DevExpress.XtraEditors;
using FinancialPlanner.Common.Model.ScoreCalculation;
using FinancialPlannerServer.ScoreEntryCalcuation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FinancialPlannerServer.ScoreCalcuation
{
    public partial class ScoresEntry : XtraForm
    {
        List<Score> scores;
        DataTable dtScoreMasterValue;
        DataTable dtStandardScore;
        DataTable dtPTScoreEntry;
        public ScoresEntry()
        {
            InitializeComponent();
        }

        private void ScoresEntry_Load(object sender, EventArgs e)
        {
            scores = new ScoreInfo().GetScoreInfo();
            setScoreMasterTable();
            gridMasterScore.DataSource = dtScoreMasterValue;

            setStandardScoreTable();
            displayScoreEntries();
        }

        private void displayScoreEntries()
        {
            ScoreEntryInfo scoreEntryInfo = new ScoreEntryInfo();
            DataTable dtScoreEntries = scoreEntryInfo.GetScoreEntryInfo();
            dtPTScoreEntry = new DataTable();
            createPivotTableStructure(dtPTScoreEntry);
            convertToPivotTable(dtPTScoreEntry, dtScoreEntries);
            gridControlScore.DataSource = dtPTScoreEntry;
        }

        private void convertToPivotTable(DataTable dtPT, DataTable dtScoreEntries)
        {
            DataTable dtUniqView = dtScoreEntries.DefaultView.ToTable(true, new string[] { "EntryDate" });
            foreach (DataRow drUniquRow in dtUniqView.Rows)
            {
                DataRow[] drScoreEntries = dtScoreEntries.Select("EntryDate = '" + drUniquRow[0].ToString() + "'");
                DataRow newRow = dtPT.NewRow();
                newRow["Date"] = drUniquRow[0].ToString();
                foreach (DataRow drScoreEntry in drScoreEntries)
                {
                    newRow[drScoreEntry["Title"].ToString().Trim()] = drScoreEntry["Value"].ToString();
                }
                dtPT.Rows.Add(newRow);
            }
        }

        private void createPivotTableStructure(DataTable dtPT)
        {
            dtPT.Columns.Add("Date", typeof(DateTime));
            foreach (Score score in scores)
            {
                dtPT.Columns.Add(score.Title.Trim(), typeof(Double));
            }
            dtPT.Columns.Add("Interest", typeof(Double));
            foreach (Score score in scores)
            {
                dtPT.Columns.Add("STD " + score.Title.Trim(), typeof(Double));
            }
            dtPT.Columns.Add("Score", typeof(Double));
        }

        private void setStandardScoreTable()
        {
            dtStandardScore = new DataTable();
            dtStandardScore.Columns.Add("Title");
            dtStandardScore.Columns.Add("Value", Type.GetType("System.Double"));
            double totalWeightage = 0;
            foreach (Score score in scores)
            {
                DataRow dr = dtStandardScore.NewRow();
                dr["Title"] = "STD " + score.Title.Trim();
                DataRow[] drs = dtScoreMasterValue.Select("Title ='" + score.Title.Trim() + "'");
                if (drs.Length > 0)
                {
                    if (!string.IsNullOrEmpty(drs[0]["Value"].ToString()))
                    {
                        dr["Value"] = Math.Round(((double.Parse(drs[0]["Value"].ToString()) / score.MinValue) * 100));
                    }
                    else
                    {
                        dr["Value"] = 0;
                    }
                }
                else
                {
                    dr["Value"] = 0;
                }
                totalWeightage = totalWeightage + double.Parse(dr["Value"].ToString()) * (score.Weightage / 100);
                dtStandardScore.Rows.Add(dr);
            }
            DataRow drScore = dtStandardScore.NewRow();
            drScore["Title"] = "Score";
            drScore["Value"] = Math.Round(totalWeightage);
            dtStandardScore.Rows.Add(drScore);
            gridControlStdScore.DataSource = dtStandardScore;
        }

        private void setScoreMasterTable()
        {
            if (dtStandardScore == null)
            {
                dtScoreMasterValue = new DataTable();
            }
            else
            {
                dtScoreMasterValue.Clear();
            }
            dtScoreMasterValue.Columns.Add("Title");
            dtScoreMasterValue.Columns.Add("Value", Type.GetType("System.Double"));
            foreach (Score score in scores)
            {
                DataRow dr = dtScoreMasterValue.NewRow();
                dr["Title"] = score.Title.Trim();
                dtScoreMasterValue.Rows.Add(dr);
            }
            DataRow drInterest = dtScoreMasterValue.NewRow();
            drInterest["Title"] = "Interest";
            dtScoreMasterValue.Rows.Add(drInterest);

        }

        private void btnCloseClientGoal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void calculateStandardScore()
        {

        }

        private void gridViewScoreMaster_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            setStandardScoreTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtScoreDate.Tag = "0";
            dtScoreDate.Text = "";
            foreach (DataRow dr in dtScoreMasterValue.Rows)
            {
                dr["Value"] = 0;
            }
            setStandardScoreTable();
            grpScoreEntry.Enabled = true;
        }

        private void btnSaveClientGoal_Click(object sender, EventArgs e)
        {

            List<ScoreEntry> scoreEntries = new List<ScoreEntry>();
            foreach (DataRow dr in dtScoreMasterValue.Rows)
            {
                ScoreEntry scoreEntry = new ScoreEntry();
                scoreEntry.EntryDate = dtScoreDate.DateTime.Date;
                scoreEntry.Title = dr["Title"].ToString();
                scoreEntry.Value = float.Parse(dr["Value"].ToString());
                scoreEntries.Add(scoreEntry);
            }
            foreach (DataRow dr in dtStandardScore.Rows)
            {
                ScoreEntry scoreEntry = new ScoreEntry();
                scoreEntry.EntryDate = dtScoreDate.DateTime.Date;
                scoreEntry.Title = dr["Title"].ToString();
                scoreEntry.Value = float.Parse(dr["Value"].ToString());
                scoreEntries.Add(scoreEntry);
            }
            ScoreEntryInfo scoreEntryInfo = new ScoreEntryInfo();
            bool blnSave = false;
            if (dtScoreDate.Tag.ToString() == "0")
            {
                blnSave = scoreEntryInfo.Add(scoreEntries);
            }
            else
            {
                blnSave = scoreEntryInfo.Update(scoreEntries);
            }
            if (blnSave)
            {
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayScoreEntries();
            }
        }

        private void gridViewScore_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName.StartsWith("STD") || e.Column.FieldName.Equals("Score"))
            {
                e.Appearance.BackColor = Color.LightPink;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewScore.GetFocusedDataSourceRowIndex() >= 0)
                {
                    DataRow[] dataRows = dtPTScoreEntry.Select("Date ='" + gridViewScore.GetFocusedRowCellValue("Date").ToString() + "'");
                    dtScoreDate.Text = dataRows[0]["Date"].ToString();
                    dtScoreDate.Tag = "1";
                    for (int columnIndex = 0; columnIndex <= dtPTScoreEntry.Columns.Count - 1; columnIndex++)
                    {
                        foreach (DataRow dataRow in dtScoreMasterValue.Rows)
                        {
                            if (dataRow[0].ToString().Equals(dtPTScoreEntry.Columns[columnIndex].ToString()))
                            {
                                dataRow[1] = (dataRows[0][dtPTScoreEntry.Columns[columnIndex].ToString()] != DBNull.Value ? dataRows[0][dtPTScoreEntry.Columns[columnIndex].ToString()].ToString() : "0");
                                break;
                            }
                        }

                        foreach (DataRow dataRow in dtStandardScore.Rows)
                        {
                            if (dataRow[0].ToString().Equals(dtPTScoreEntry.Columns[columnIndex].Caption))
                            {
                                dataRow[1] = (dataRows[0][dtPTScoreEntry.Columns[columnIndex].Caption] != DBNull.Value ?
                                float.Parse(dataRows[0][dtPTScoreEntry.Columns[columnIndex].Caption].ToString()) :
                                0);
                                break;
                            }
                        }
                    }
                    grpScoreEntry.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewScore_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewScore.GetFocusedDataSourceRowIndex() >= 0)
                {
                    if (XtraMessageBox.Show("Are you sure, you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ScoreEntry scoreEntry = new ScoreEntry();
                        scoreEntry.EntryDate = DateTime.Parse(gridViewScore.GetFocusedRowCellValue("Date").ToString());
                        ScoreEntryInfo scoreEntryInfo = new ScoreEntryInfo();
                        scoreEntryInfo.Delete(scoreEntry);
                        displayScoreEntries();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}