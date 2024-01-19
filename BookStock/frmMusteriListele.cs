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
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9E5P6SH;Initial Catalog=StockDb;Integrated Security=True;");
        DataSet dataSet = new DataSet();    
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            Kayit_Goster();
        }

        private void Kayit_Goster()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Musteri", connection);
            adapter.Fill(dataSet, "Musteri");
            dataGridView1.DataSource = dataSet.Tables["Musteri"];
            connection.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTC.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();    
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update Musteri set adsoyad=@adsoyad, telefon=@telefon, adres=@adres,email=@email where tc=@tc", connection);
            cmd.Parameters.AddWithValue("@tc", txtTC.Text);
            cmd.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            dataSet.Tables["Musteri"].Clear(); //Tabloyu önce temizleyip sonra kayıdı göster
            Kayit_Goster();
            MessageBox.Show("Müşteri kaydı Güncellendi");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox) //Eger bu item'ler TextBox'ise TextBox leri Sil
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Musteri where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() +"'",connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            dataSet.Tables["Musteri"].Clear(); //Tabloyu önce temizleyip sonra kayıdı göster
            Kayit_Goster();
            MessageBox.Show("Kayıt Silindi");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *  from Musteri where tc like '%"+txtTcAra.Text+"%'",connection);
            adtr.Fill(dataTable);
            dataGridView1.DataSource = dataTable;   
            connection.Close(); 
        }
    }
}
