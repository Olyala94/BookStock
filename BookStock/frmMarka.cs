using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStock
{
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9E5P6SH;Initial Catalog=StockDb;Integrated Security=True;");

        bool durum;
        private void markaKontrol()
        {
            durum = true;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from MarkaBilgileri", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //kategori ve marka ikiside varsa (o kategoriye bağlı aynı marka varsa ekleme işlemi gerçekleştirme...veya textBox1 boş geçilirse veya comboBox1 boş geçilirse ekleme yapma!!!)
                if (comboBox1.Text==reader["kategori"].ToString() && textBox1.Text == reader["marka"].ToString() || comboBox1.Text=="" ||textBox1.Text == "")
                {
                    durum = false;
                }
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markaKontrol(); 
            if(durum == true)
            {
 connection.Open();
            SqlCommand cmd = new SqlCommand("insert into MarkaBilgileri(kategori, marka) values('"+comboBox1.Text+"','" + textBox1.Text + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close(); 
            MessageBox.Show("Yazar Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle Bir Kategori Ve Yazar Var veya Kategori Ve Yazar Boş Geçilemez");
            }
            textBox1.Text = "";
            comboBox1.Text = "";
           
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void KategoriGetir()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from KategoriBilgileri", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["kategori"].ToString());
            }
            connection.Close();
        }
    }
}
