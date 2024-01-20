using System;
using System.Data;
using System.Data.SqlClient;
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

            // Sütun başlıklarını düzenli gözükmesi için
            dataGridView1.Columns["barkodno"].HeaderText = "Barkod No";
            dataGridView1.Columns["urunadi"].HeaderText = "Ürün Adı";
            dataGridView1.Columns["miktari"].HeaderText = "Miktarı";
            dataGridView1.Columns["satisfiyati"].HeaderText = "Satış Fiyatı";
            dataGridView1.Columns["toplamfiyati"].HeaderText = "Toplam Fiyat";
            dataGridView1.Columns["tarih"].HeaderText = "Tarih";

            connection.Close();
        }
        private void frmSatısListele_Load(object sender, EventArgs e)
        {
            SatisListele();
        }
    }
}
