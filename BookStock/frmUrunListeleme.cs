using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStock
{
    public partial class frmUrunListeleme : Form
    {
        public frmUrunListeleme()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9E5P6SH;Initial Catalog=StockDb;Integrated Security=True;");
        DataSet dataSet = new DataSet();

        private void frmUrunListeleme_Load(object sender, EventArgs e)
        {
            UrunListele();
            // DataGridView sütun başlıklarını güzelleştirmek için
            dataGridView1.Columns["barkodno"].HeaderText = "Barkod No";
            dataGridView1.Columns["urunadi"].HeaderText = "Ürün Adı";
            dataGridView1.Columns["miktari"].HeaderText = "Miktarı";
            dataGridView1.Columns["alisfiyati"].HeaderText = "Alış Fiyatı";
            dataGridView1.Columns["satisfiyati"].HeaderText = "Satış Fiyatı";
        }

        private void UrunListele()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Urun", connection);
            adapter.Fill(dataSet, "Urun");
            dataGridView1.DataSource = dataSet.Tables["Urun"];
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNoTxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString(); 
            UrunAdiTxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            MiktarTxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            AlisFiyatTxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            SatisFiyatTxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update Urun set urunadi=@urunadi,miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno", connection);
            cmd.Parameters.AddWithValue("@barkodno", BarkodNoTxt.Text);
            cmd.Parameters.AddWithValue("@urunadi", UrunAdiTxt.Text);
            cmd.Parameters.AddWithValue("@miktari", int.Parse(MiktarTxt.Text));
            cmd.Parameters.AddWithValue("@alisfiyati", double.Parse(AlisFiyatTxt.Text));
            cmd.Parameters.AddWithValue("@satisfiyati", double.Parse(SatisFiyatTxt.Text));
            cmd.ExecuteNonQuery();
            connection.Close();
            dataSet.Tables["Urun"].Clear(); //önce tabloyu temizle, sonra tekrar listele....
            UrunListele();
            MessageBox.Show("Güncelleme Başarı bir şekilde Yapıldı");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGüncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            dataSet.Tables["Urun"].Clear(); //Tabloyu önce temizleyip sonra kayıdı göster
            UrunListele();
            MessageBox.Show("Ürün Silindi");
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *  from Urun where barkodno like '%" + txtBarkodNoAra.Text + "%'", connection); //% - arama yaptığında başta veya sonunda yazdığımın nokodu arıyor
            adtr.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
    }
}
