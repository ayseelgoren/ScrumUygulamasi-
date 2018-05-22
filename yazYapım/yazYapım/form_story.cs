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
    public partial class form_story : Form
    {
        public form_story()
        {
            InitializeComponent();
        }
        form_anasayfa anasayfa = new form_anasayfa();

        SqlConnection baglanti = new SqlConnection("Data Source=PC;Initial Catalog=VeriTabani_Scrum;Integrated Security=True");
        string kayit_story = "SELECT * FROM Story ";
        string kayit_task = "SELECT * FROM Task t inner join Story s on t.story_id=s.story_id";
        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        void c_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            b.DoDragDrop(b, DragDropEffects.Move);
           
        }
        int story_i = 0, task_i = 0;
        private void form_story_Load(object sender, EventArgs e)
        {
            //Story Oluşumunu panele ekliyor.
             if (baglanti.State == ConnectionState.Closed)
             {

                 baglanti.Open();
                 SqlCommand Story = new SqlCommand(kayit_story,baglanti);                
                 SqlDataAdapter data_Story=new SqlDataAdapter(kayit_story,baglanti);
                 DataTable dtable = new DataTable();
                 data_Story.Fill(dtable);
                 foreach (DataRow drRow in dtable.Rows)
               {
                   story_i++;
                     Button btn_story = new Button();                   
                     btn_story.Location = new System.Drawing.Point(20, story_i * 60);
                     btn_story.Size = new System.Drawing.Size(100, 60);
                     btn_story.Font = new Font("Buxton Sketch",10);
                     btn_story.Text = " # "+drRow["adi"].ToString()+"\n"+drRow["aciklamasi"].ToString();
                     btn_story.AllowDrop=true;
                     btn_story.BackColor = Color.FromArgb(Convert.ToInt32(drRow["renk_A"]), Convert.ToInt32(drRow["renk_R"]), Convert.ToInt32(drRow["renk_G"]), Convert.ToInt32(drRow["renk_B"]));
                    this.pnlcstories.Controls.Add(btn_story);
               }
                 data_Story.Dispose();
                 baglanti.Close();
                 
             }
            //Task oluşumu panele ekleme
             if (baglanti.State == ConnectionState.Closed)
             {
                 baglanti.Open();
                 SqlCommand Task = new SqlCommand(kayit_task, baglanti);
                 SqlDataAdapter data_task = new SqlDataAdapter(kayit_task, baglanti);
                 DataTable dtable_task = new DataTable();
                 data_task.Fill(dtable_task);
                 foreach (DataRow drRow in dtable_task.Rows)
                 {
                     task_i++;
                     Button btn_task = new Button();
                     btn_task.Location = new System.Drawing.Point(20,task_i *60 );
                     btn_task.Size = new System.Drawing.Size(100, 60);
                     btn_task.Font = new Font("Buxton Sketch", 10);
                     btn_task.Text = "# " + drRow["adi"].ToString() + "\n" + drRow["sorumlusu"].ToString();
                     btn_task.AllowDrop = true;
                     btn_task.BackColor = Color.FromArgb(Convert.ToInt32(drRow["renk_A"]), Convert.ToInt32(drRow["renk_R"]), Convert.ToInt32(drRow["renk_G"]), Convert.ToInt32(drRow["renk_B"]));
                     this.pnlcnotstarted.Controls.Add(btn_task);
                 }
                 data_task.Dispose();
                 baglanti.Close();

             }
             //panellere surukle-bırak oluşumunun özellikleri ekleniyor.
             foreach (Button b in this.pnlcnotstarted.Controls)
             {
                 b.MouseDown += new MouseEventHandler(c_MouseDown);
             }
             foreach (Button b in this.pnlcinprogress.Controls)
             {
                 b.MouseDown += new MouseEventHandler(c_MouseDown);
             }
             foreach (Button b in this.pnlcdone.Controls)
             {
                 b.MouseDown += new MouseEventHandler(c_MouseDown);
             }
     
             this.pnlcnotstarted.DragOver += new DragEventHandler(pnlcnotstarted_DragOver);
             this.pnlcnotstarted.DragDrop += new DragEventHandler(pnlcnotstarted_DragDrop);
             this.pnlcinprogress.DragOver += new DragEventHandler(pnlcinprogress_DragOver);
             this.pnlcinprogress.DragDrop += new DragEventHandler(pnlcinprogress_DragDrop);
             this.pnlcdone.DragOver += new DragEventHandler(pnlcdone_DragOver);
             this.pnlcdone.DragDrop += new DragEventHandler(pnlcdone_DragDrop);

        }


        private void pnlcnotstarted_DragDrop(object sender, DragEventArgs e)
        {

            Button b = e.Data.GetData(e.Data.GetFormats()[0]) as Button;
            if (b != null)
            {
                b.Location = this.pnlcnotstarted.PointToClient(new Point(e.X, e.Y));
                this.pnlcnotstarted.Controls.Add(b);
            }
        }

        private void pnlcnotstarted_DragOver(object sender, DragEventArgs e)
        {
             e.Effect = DragDropEffects.Move;
        }

        private void pnlcinprogress_DragDrop(object sender, DragEventArgs e)
        {
            Button b = e.Data.GetData(e.Data.GetFormats()[0]) as Button;
            if (b != null)
            {
                b.Location = this.pnlcinprogress.PointToClient(new Point(e.X, e.Y));
                this.pnlcinprogress.Controls.Add(b);
            }
        }

        private void pnlcinprogress_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pnlcdone_DragDrop(object sender, DragEventArgs e)
        {
            Button b = e.Data.GetData(e.Data.GetFormats()[0]) as Button;
            if (b != null)
            {
                b.Location = this.pnlcdone.PointToClient(new Point(e.X, e.Y));
                this.pnlcdone.Controls.Add(b);
            }
        }

        private void pnlcdone_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
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

      
       }
    }

