using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStock
{
    public partial class frmSatısListele : Form
    {
        public frmSatısListele()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9E5P6SH;Initial Catalog=StockDb;Integrated Security=True;");
        DataSet dataSet = new DataSet();
        private void SatisListele()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Satis", connection);
            adapter.Fill(dataSet, "Satis");
            dataGridView1.DataSource = dataSet.Tables["Satis"];
            
            connection.Close();
        }
        private void frmSatısListele_Load(object sender, EventArgs e)
        {
            SatisListele();
        }
    }
}
