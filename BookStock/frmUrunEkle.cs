using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BookStock
{
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9E5P6SH;Initial Catalog=StockDb;Integrated Security=True;");

        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Urun", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Eger veritabanında ayı barkodno varsa veya boş geçilirse ekleme yapma aksi takdirde hatayı göster.
                if (txtBarkodNo.Text == reader["barkodno"].ToString() || txtBarkodNo.Text == "")
                {
                    durum = false;
                }
            }
            connection.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void KategoriGetir()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from KategoriBilgileri", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboKategori.Items.Add(reader["kategori"].ToString());
            }
            connection.Close();
        }
        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboYazar.Items.Clear();
            comboYazar.Text = "";
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from MarkaBilgileri where kategori ='" + comboKategori.SelectedItem + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboKategori.Items.Add(reader["marka"].ToString());
            }
            connection.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into Urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values (@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", connection);
                cmd.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                cmd.Parameters.AddWithValue("@kategori", comboKategori.Text);
                cmd.Parameters.AddWithValue("@marka", comboYazar.Text);
                cmd.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
                cmd.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                cmd.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlisFiyat.Text));
                cmd.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyat.Text));
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));


                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ürün Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir BakodNo var zaten veya buton boş geçilemez", "Uyarı!");
            }

            comboYazar.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
                if (item is System.Windows.Forms.ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BarkodNoTxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNoTxt.Text == "")
            {
                lblMiktar.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is System.Windows.Forms.TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Urun where barkodno like'" + BarkodNoTxt.Text + "%'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) //kayıtlar okunduğu sürece döngü devam edecek
            {
                KategoriTxt.Text = reader["kategori"].ToString();
                YazarTxt.Text = reader["marka"].ToString();
                UrunAdiTxt.Text = reader["urunadi"].ToString();
                lblMiktar.Text = reader["miktari"].ToString();
                AlisFiyatTxt.Text = reader["alisfiyati"].ToString();
                SatisFiyatTxt.Text = reader["satisfiyati"].ToString();
            }
            connection.Close();

        }

        private void btnVarOlanaEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update Urun set miktari = miktari+ '" + int.Parse(MiktarTxt.Text) + "' where barkodno = '" + BarkodNoTxt.Text + "'", connection);
            cmd.ExecuteNonQuery();
            connection.Close();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var Olan Ürüne Ekleme Yapıldı");
        }
    }
}
