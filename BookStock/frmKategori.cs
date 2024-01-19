using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStock
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9E5P6SH;Initial Catalog=StockDb;Integrated Security=True;");

        bool durum;
        private void kategoriKontrol()
        {
            durum = true;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from KategoriBilgileri", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (textBox1.Text == reader["kategori"].ToString() || textBox1.Text == "")
                {
                    durum = false;
                }
            }
            connection.Close();
        }

        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategoriKontrol();
            if (durum == true)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into KategoriBilgileri(kategori) values('" + textBox1.Text + "')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                textBox1.Text = "";
                MessageBox.Show("Kategori eklendi");
            }
            else
            {
                MessageBox.Show("Böyle Bir Kategori Var veya boş geçilemez", "Uyarı");
            }

        }
    }
}
