﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStock
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9E5P6SH;Initial Catalog=StockDb;Integrated Security=True;");
        DataSet dataSet = new DataSet();
        private void SepetListele()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Sepet", connection);
            adapter.Fill(dataSet, "sepet");
            dataGridView1.DataSource = dataSet.Tables["Sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            connection.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmUrunEkle ekle = new frmUrunEkle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            SepetListele();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmUrunListeleme listeleme = new frmUrunListeleme();
            listeleme.ShowDialog();
        }

        private void hesapla()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select sum(toplamfiyati) from sepet",connection);
                lblGenelToplam.Text = cmd.ExecuteScalar()+"TL";
                connection.Close(); 

            }
            catch (Exception)
            {

                ;
            }
        }
        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From Musteri where tc like '" + txtTC.Text + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtAdSoyad.Text = reader["adsoyad"].ToString();
                txtAdSoyad.Text = reader["telefon"].ToString();
            }
            connection.Close();
        }
        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From Urun where barkodno like '" + txtBarkodNo.Text + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtUrunAdi.Text = reader["urunadi"].ToString();
                txtSatisFiyat.Text = reader["satisfiyati"].ToString();
            }
            connection.Close();
        }

        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktari)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }
        bool durum;
        private void BarkodControl()
        {
            durum = true;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select *  From Sepet", connection);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            BarkodControl();
            if (durum == true)
            {
                connection.Close();
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into Sepet(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", connection);
                cmd.Parameters.AddWithValue("@tc", txtTC.Text);
                cmd.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                cmd.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
                cmd.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                cmd.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyat.Text));
                cmd.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyat.Text));
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                connection.Close();
                connection.Open();
                SqlCommand cmd2 = new SqlCommand("Update Sepet Set miktari=miktari+'" + int.Parse(txtMiktari.Text) + "' where barkodno = '" + txtBarkodNo.Text + "'", connection);
                cmd2.ExecuteNonQuery();

                //miktari değiştiği zaman toplam fiyatında değişmesi için...
                SqlCommand cmd3 = new SqlCommand("Update Sepet Set toplamfiyati=miktari*satisfiyati where barkodno = '" + txtBarkodNo.Text + "'", connection);
                cmd3.ExecuteNonQuery();

                connection.Close();
            }
            
            txtMiktari.Text = "1";
            dataSet.Tables["Sepet"].Clear();
            SepetListele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktari)
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatisFiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtSatisFiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatisFiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Sepet where barkodno = '" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() +"'",connection);
            cmd.ExecuteNonQuery();
            connection.Close();        
            MessageBox.Show("Ürün Başarılı bir şekilde Sepetten Silindi");
            dataSet.Tables["Sepet"].Clear();
            SepetListele(); 
            hesapla();
        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Sepet", connection);
            cmd.ExecuteNonQuery();
            connection.Close();   
            MessageBox.Show("Ürün Sepetten Çıkarıldı");
            dataSet.Tables["Sepet"].Clear();
            SepetListele();
            hesapla();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSatısListele listele = new frmSatısListele();
            listele.ShowDialog();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                connection.Close();
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into Satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", connection);
                cmd.Parameters.AddWithValue("@tc", txtTC.Text);
                cmd.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                //kaçtane kayıt varsa onu barkodno sütünine aktar dedim 
                cmd.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                cmd.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                cmd.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                cmd.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                cmd.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
