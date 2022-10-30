using System.Data;
using System.Windows.Forms;

namespace SQLViewer
{
    public partial class SelectForm : Form
    {
        public SelectForm(DataTable dataTable)
        {
            InitializeComponent();
            Init(dataTable);
        }

        private void Init(DataTable dataTable)
        {
            Text = dataTable.TableName;
            DgResults.DataSource = dataTable;
        }
    }
}
