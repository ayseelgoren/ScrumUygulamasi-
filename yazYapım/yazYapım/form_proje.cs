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
    public partial class form_proje : Form
    {
        public form_proje()
        {
            InitializeComponent();
        }

        form_anasayfa anasayfa = new form_anasayfa();
        SqlConnection baglanti = new SqlConnection("Data Source=PC;Initial Catalog=VeriTabani_Scrum;Integrated Security=True");
        public static int task_sayisi;
        int proje_id,story_id;
        private void txtrenk_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Renk Seçiniz Lütfen...");
        }     
     
        private void btntamam_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {

                baglanti.Open();
                SqlCommand Proje_id = new SqlCommand();
                Proje_id.Connection = baglanti;
                Proje_id.CommandText = "SELECT proje_id FROM Proje";
                Proje_id.CommandType = CommandType.Text;
                Proje_id.ExecuteNonQuery();
                SqlDataReader data = Proje_id.ExecuteReader();
                while (data.Read())
                {
                    proje_id = int.Parse(data["proje_id"].ToString());
                    break;
                }
                data.Close();
                baglanti.Close();
            }
            if (txtstoryaciklamasi.Text != null && txtstoryadi.Text != null && txttasksayisi.Text != null )
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand Story= new SqlCommand();
                    Story.Connection = baglanti;
                    Story.CommandText = " INSERT INTO Story(adi,aciklamasi,renk_A,renk_R,renk_G,renk_B,task_sayisi,proje_id) VALUES('" + txtstoryadi.Text + "', '" + txtstoryaciklamasi.Text + "','" + Renk.Color.A + "','" + Renk.Color.R + "','" + Renk.Color.G + "','" + Renk.Color.B + "','" + int.Parse(txttasksayisi.Text) + "' ,'"+proje_id+"')";
                    Story.ExecuteNonQuery();
                    Story.Dispose();
                    baglanti.Close();                  
                }  

                grbxtask.Enabled = true;  
            }
            else
                MessageBox.Show("Story Bilgilerini Giriniz...");
            

             if (baglanti.State == ConnectionState.Closed)
             {

                 baglanti.Open();
                 SqlCommand Task_sayisi = new SqlCommand();
                 Task_sayisi.Connection = baglanti;
                 Task_sayisi.CommandText = "SELECT task_sayisi FROM Story WHERE task_sayisi='"+txttasksayisi.Text+"' ";
                 Task_sayisi.CommandType = CommandType.Text;
                Task_sayisi.ExecuteNonQuery();
                 SqlDataReader data = Task_sayisi.ExecuteReader();
                 while (data.Read())
                 {
                     task_sayisi = int.Parse(data["task_sayisi"].ToString());
                     break;
                 }
                 data.Close();
                 baglanti.Close();
             }
             btntamam.Enabled = false;
        }
     public static   ColorDialog Renk = new ColorDialog();
        private void btnrenksec_Click(object sender, EventArgs e)
        {
            Renk.ShowDialog();
            txtrenk.BackColor = Renk.Color;
            txtrenk.Name = txtrenk.BackColor.Name.ToString();
          
        }
       
        int task_adet = 1;

        private void btntaskolustur_Click(object sender, EventArgs e)
        {
            dtpcbastarih.Format = DateTimePickerFormat.Custom;
            dtpcbastarih.CustomFormat = "yyyy-MM-dd ";
            dtpcbittarih.Format = DateTimePickerFormat.Custom;
            dtpcbittarih.CustomFormat = "yyyy-MM-dd ";

            if (baglanti.State == ConnectionState.Closed)
            {

                baglanti.Open();
                SqlCommand Story_id = new SqlCommand();
                Story_id.Connection = baglanti;
                Story_id.CommandText = "SELECT story_id FROM Story";
                Story_id.CommandType = CommandType.Text;
                Story_id.ExecuteNonQuery();
                SqlDataReader data = Story_id.ExecuteReader();
                while (data.Read())
                {
                    story_id = int.Parse(data["story_id"].ToString());
                    break;
                }
                data.Close();
                baglanti.Close();
            }
            string kayıt = " INSERT INTO Task (adi,sorumlusu,bas_tarihi,bit_tarihi,story_id) VALUES('" + txttaskadi.Text + "', '" + txttasksorumlusu.Text + "' ,'" + dtpcbastarih.Text + "','" + dtpcbittarih.Text + "','" + story_id + "')";
                if (task_adet <= task_sayisi || (task_adet == 1 && task_sayisi == 1))
                {
                    if (txttaskadi.Text != null && txttasksorumlusu.Text != null)
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                            SqlCommand Task = new SqlCommand(kayıt, baglanti);
                            Task.ExecuteNonQuery();
                            Task.Dispose();
                            baglanti.Close();
                        }

                    }

                }
            
           if(task_adet==task_sayisi)
            {
                MessageBox.Show("Task oluşumu istenilen adete ulaşmıştır...");
                btntaskolustur.Enabled = false;
            }
            task_adet++;
            txttaskadi.Clear();
            txttasksorumlusu.Clear();
                
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            anasayfa.Show();
            this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_proje_Load(object sender, EventArgs e)
        {
            txtprojeadi.Text = form_anasayfa.p_adi;
            txtprojesorumlusu.Text = form_anasayfa.p_sorumlusu;
            dtpcbastarih.Format = DateTimePickerFormat.Custom;
            dtpcbastarih.CustomFormat = "yyyy-MM-dd ";
            dtpcbittarih.Format = DateTimePickerFormat.Custom;
            dtpcbittarih.CustomFormat = "yyyy-MM-dd "; 
           
        }


      
        private void sbtncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbtngeri_Click(object sender, EventArgs e)
        {
            anasayfa.Show();
            this.Hide();
        }

        private void sbtnyenistory_Click(object sender, EventArgs e)
        {
            task_adet = 1;
            txtstoryaciklamasi.Clear();
            txtstoryadi.Clear();
            txttasksayisi.Clear();
            txtrenk.BackColor = Color.White;
            txttaskadi.Clear();
            txttasksorumlusu.Clear();
            btntaskolustur.Enabled = true;
            btntamam.Enabled = true;
            dtpcbastarih.Format = DateTimePickerFormat.Custom;
            dtpcbastarih.CustomFormat = "yyyy-MM-dd ";
            dtpcbittarih.Format = DateTimePickerFormat.Custom;
            dtpcbittarih.CustomFormat = "yyyy-MM-dd "; 
        }

        private void sbtnscrumtablosu_Click(object sender, EventArgs e)
        {
            form_story story = new form_story();
            story.Show();
            this.Hide();
        }

    
       
    }
}
