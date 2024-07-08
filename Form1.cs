using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Code_Tolentino_Francesz_Inv
{
    public partial class frmMain : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\\169_Tolentino_Francesz_SC\\dbSchoolSupplies.accdb");
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            grid();
        }

        private void btnPurchh_Click(object sender, EventArgs e)
        {

        }
        void grid()
        {
            String query = "SELECT * FROM product order by prodID asc";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProducts.DataSource = dt;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            frmRecordMgmt frm = new frmRecordMgmt();
            frm.ShowDialog();
        }
    }
}
