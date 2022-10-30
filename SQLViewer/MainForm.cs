using SQLViewer.DAL;
using SQLViewer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SQLViewer
{
    public partial class MainForm : Form
    {
        private const string FileFilter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
        private const string FileName = "{0}.xml";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());
        }

        private void CbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            LbTables.DataSource = (CbDatabases.SelectedItem as Database).Tables;
            LbViews.DataSource = (CbDatabases.SelectedItem as Database).Views;
            LbProcedures.DataSource = (CbDatabases.SelectedItem as Database).Procedures;
        }

        private void Clear()
        {
            LbTableColumns.DataSource = null;
            LbViewColumns.DataSource = null;
            LbProcedureParameters.DataSource = null;
            TbProcedureDefinition.Text = string.Empty;
        }

        private void LbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbTableColumns.DataSource = (LbTables.SelectedItem as DatabaseEntity).Columns;
        }

        private void LbViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbViewColumns.DataSource = (LbViews.SelectedItem as DatabaseEntity).Columns;
        }

        private void LbProcedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbProcedureDefinition.Text = (LbProcedures.SelectedItem as Procedure).Definition;
            LbProcedureParameters.DataSource = (LbProcedures.SelectedItem as Procedure).Parameters;
        }

        private void BtnXMLClick(object sender, EventArgs e)
        {
            DatabaseEntity databaseEntity;

            switch ((sender as Button).Name)
            {
                case nameof(BtnXMLTables):
                    databaseEntity = LbTables.SelectedItem as DatabaseEntity;
                    break;
                case nameof(BtnXMLViews):
                    databaseEntity = LbViews.SelectedItem as DatabaseEntity;
                    break;
                default:
                    throw new Exception("Wrong wiring");
            }

            var dialog = new SaveFileDialog()
            {
                FileName = string.Format(FileName, databaseEntity.Name),
                Filter = FileFilter
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataSet dataSet = RepositoryFactory.GetRepository().CreateDataset(databaseEntity); 
                dataSet.WriteXml(dialog.FileName, XmlWriteMode.WriteSchema);
            }
        }

        private void BtnSelectClick(object sender, EventArgs e)
        {
            DatabaseEntity databaseEntity;

            switch ((sender as Button).Name)
            {
                case nameof(BtnSelectTables):
                    databaseEntity = LbTables.SelectedItem as DatabaseEntity;
                    break;
                case nameof(BtnSelectViews):
                    databaseEntity = LbViews.SelectedItem as DatabaseEntity;
                    break;
                default:
                    throw new Exception("Wrong wiring");
            }

            DataSet dataSet = RepositoryFactory.GetRepository().CreateDataset(databaseEntity);
            new SelectForm(dataSet.Tables[0]).ShowDialog();
        }
    }
}
