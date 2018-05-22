namespace yazYapım
{
    partial class form_story
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_story));
            this.label5 = new System.Windows.Forms.Label();
            this.pnlcstories = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlcnotstarted = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlcinprogress = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlcdone = new DevExpress.XtraEditors.PanelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.sbtncikis = new DevExpress.XtraEditors.SimpleButton();
            this.sbtngeri = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlcstories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlcnotstarted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlcinprogress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlcdone)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Buxton Sketch", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(335, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 45);
            this.label5.TabIndex = 5;
            this.label5.Text = "   Scrum Board  ";
            // 
            // pnlcstories
            // 
            this.pnlcstories.AllowDrop = true;
            this.pnlcstories.Location = new System.Drawing.Point(12, 92);
            this.pnlcstories.Name = "pnlcstories";
            this.pnlcstories.Size = new System.Drawing.Size(211, 579);
            this.pnlcstories.TabIndex = 7;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(76, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stories";
            // 
            // pnlcnotstarted
            // 
            this.pnlcnotstarted.AllowDrop = true;
            this.pnlcnotstarted.Location = new System.Drawing.Point(229, 92);
            this.pnlcnotstarted.Name = "pnlcnotstarted";
            this.pnlcnotstarted.Size = new System.Drawing.Size(260, 579);
            this.pnlcnotstarted.TabIndex = 8;
            this.pnlcnotstarted.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlcnotstarted_DragDrop);
            this.pnlcnotstarted.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlcnotstarted_DragOver);
        
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(283, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Not Started";
            // 
            // pnlcinprogress
            // 
            this.pnlcinprogress.AllowDrop = true;
            this.pnlcinprogress.Location = new System.Drawing.Point(495, 92);
            this.pnlcinprogress.Name = "pnlcinprogress";
            this.pnlcinprogress.Size = new System.Drawing.Size(260, 579);
            this.pnlcinprogress.TabIndex = 9;
            this.pnlcinprogress.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlcinprogress_DragDrop);
            this.pnlcinprogress.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlcinprogress_DragOver);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(548, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "In Progress";
            // 
            // pnlcdone
            // 
            this.pnlcdone.AllowDrop = true;
            this.pnlcdone.Location = new System.Drawing.Point(761, 92);
            this.pnlcdone.Name = "pnlcdone";
            this.pnlcdone.Size = new System.Drawing.Size(260, 579);
            this.pnlcdone.TabIndex = 10;
            this.pnlcdone.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlcdone_DragDrop);
            this.pnlcdone.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlcdone_DragOver);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Buxton Sketch", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(831, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Done";
            // 
            // sbtncikis
            // 
            this.sbtncikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtncikis.ImageOptions.Image")));
            this.sbtncikis.Location = new System.Drawing.Point(979, 6);
            this.sbtncikis.Name = "sbtncikis";
            this.sbtncikis.Size = new System.Drawing.Size(42, 42);
            this.sbtncikis.TabIndex = 16;
            this.sbtncikis.Click += new System.EventHandler(this.sbtncikis_Click);
            // 
            // sbtngeri
            // 
            this.sbtngeri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtngeri.ImageOptions.Image")));
            this.sbtngeri.Location = new System.Drawing.Point(931, 7);
            this.sbtngeri.Name = "sbtngeri";
            this.sbtngeri.Size = new System.Drawing.Size(42, 41);
            this.sbtngeri.TabIndex = 17;
            this.sbtngeri.Click += new System.EventHandler(this.sbtngeri_Click);
            // 
            // form_story
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1032, 683);
            this.Controls.Add(this.sbtngeri);
            this.Controls.Add(this.sbtncikis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlcdone);
            this.Controls.Add(this.pnlcinprogress);
            this.Controls.Add(this.pnlcnotstarted);
            this.Controls.Add(this.pnlcstories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_story";
            this.Load += new System.EventHandler(this.form_story_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlcstories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlcnotstarted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlcinprogress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlcdone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.PanelControl pnlcstories;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl pnlcnotstarted;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl pnlcinprogress;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PanelControl pnlcdone;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton sbtncikis;
        private DevExpress.XtraEditors.SimpleButton sbtngeri;
    }
}