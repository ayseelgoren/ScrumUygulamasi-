using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yazYapım
{
    public partial class form_anasayfa : Form
    {
        public form_anasayfa()
        {
            InitializeComponent();
        }
        public static string p_adi, p_sorumlusu;

        SqlConnection baglanti = new SqlConnection("Data Source=PC;Initial Catalog=VeriTabani_Scrum;Integrated Security=True");
        private void btnprojeolustur_Click(object sender, EventArgs e)
        {
           //PROJE OLUŞTURULUYOR.
            if(baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand Proje = new SqlCommand();
                Proje.Connection = baglanti;
                if (txtprojeadi.Text != null && txtprojesorumlusu.Text != null)
                {
                    p_adi = txtprojeadi.Text;
                    p_sorumlusu = txtprojesorumlusu.Text;                   
                    Proje.CommandText = " INSERT INTO Proje(adi,sorumlusu) VALUES('" + txtprojeadi.Text + "', '" + txtprojesorumlusu.Text + "' )";
                    Proje.ExecuteNonQuery();
                    Proje.Dispose();
                    baglanti.Close();
                    form_proje proje = new form_proje();
                    proje.Show();
                    this.Hide();
                    
                }
                else
                    MessageBox.Show("Projeye adını ve sorumlusunu giriniz...");
            
            }
          
            txtprojeadi.Clear();
            txtprojesorumlusu.Clear();
        }
        private void sbtnsil_Click(object sender, EventArgs e)
        {
            //DATAGRİDDEN SEÇİLLEN PROJE SİİNİYOR.
            foreach (DataGridViewRow drow in dtgridprojeler.SelectedRows)  //Seçili Satırları Silme
            {
                int proje_id = Convert.ToInt32(drow.Cells[0].Value);
                KayitSil(proje_id);
            }
            gridprojedoldur();
        }
        void gridprojedoldur()
        {

            baglanti.Open();
            string kayit = "SELECT * from Proje";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter data = new SqlDataAdapter(komut); //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
           DataSet dtset = new DataSet();
            data.Fill(dtset,"Proje"); //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dtgridprojeler.DataSource = dtset.Tables["Proje"];//Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }

      void  KayitSil(int proje_id)
        {
            string sql = "DELETE FROM Proje WHERE proje_id=@proje_id";
            SqlCommand  komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@proje_id", proje_id);
            baglanti.Open();
            komut.ExecuteNonQuery();
           baglanti.Close();
           MessageBox.Show(proje_id+" nolu Proje Silinmiştir.");
        }  
      private void sbtncikis_Click(object sender, EventArgs e)
      {
          this.Close();
      }

      private void sbtnyeniproje_Click(object sender, EventArgs e)
      {
          grbxyeniproje.Visible = true;
          pnlprojetakibi.Visible = false;
      }

      private void sbtnprojeler_Click(object sender, EventArgs e)
      {
          pnlprojetakibi.Visible = true;
          dtgridprojeler.Visible = true;
          grbxyeniproje.Visible = false;
          sbtnsil.Visible = true;
          gridprojedoldur();
      }

      private void sbtnscrumtablosu_Click(object sender, EventArgs e)
      {
          form_story story = new form_story();
          story.Show();
          this.Hide();
      }

      private void sbtnilerle_Click(object sender, EventArgs e)
      {
          foreach (DataGridViewRow drow in dtgridprojeler.SelectedRows)  //Seçili Satırları Silme
          {
              int proje_id = Convert.ToInt32(drow.Cells[0].Value);
              gridstorydoldur(proje_id);
          }
          
      }

      void gridstorydoldur(int proje_id)
      {

          baglanti.Open();
          string kayit = "SELECT * from Story  WHERE proje_id='"+proje_id+"'";
          SqlCommand komut = new SqlCommand(kayit, baglanti);
          SqlDataAdapter data_adap = new SqlDataAdapter(komut);
          DataSet dataset = new DataSet();
          data_adap.Fill(dataset, "Story");
          dtgridprojeler.ClearSelection(); 
          dtgridprojeler.DataSource = dataset.Tables["Story"];
          baglanti.Close();
      }

      private void sbtngeri_Click(object sender, EventArgs e)
      {
          gridprojedoldur();
      }

     
   
    
    }
}
