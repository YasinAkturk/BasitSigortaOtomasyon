
namespace SigortaOtomasyon
{
    partial class MusteriBolumu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.MusteriKapa = new System.Windows.Forms.Button();
            this.lbl_menuadi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_musteri = new System.Windows.Forms.TextBox();
            this.txt_mustel = new System.Windows.Forms.TextBox();
            this.txt_musadres = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.MusteriListe = new System.Windows.Forms.DataGridView();
            this.musteri_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.MusteriKapa);
            this.panel1.Controls.Add(this.lbl_menuadi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(696, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MusteriKapa
            // 
            this.MusteriKapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MusteriKapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusteriKapa.FlatAppearance.BorderSize = 0;
            this.MusteriKapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MusteriKapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriKapa.ForeColor = System.Drawing.Color.White;
            this.MusteriKapa.Location = new System.Drawing.Point(744, 10);
            this.MusteriKapa.Margin = new System.Windows.Forms.Padding(4);
            this.MusteriKapa.Name = "MusteriKapa";
            this.MusteriKapa.Size = new System.Drawing.Size(40, 28);
            this.MusteriKapa.TabIndex = 7;
            this.MusteriKapa.Tag = "";
            this.MusteriKapa.Text = "X";
            this.MusteriKapa.UseVisualStyleBackColor = false;
            this.MusteriKapa.Click += new System.EventHandler(this.MusteriKapa_Click);
            // 
            // lbl_menuadi
            // 
            this.lbl_menuadi.AutoSize = true;
            this.lbl_menuadi.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_menuadi.ForeColor = System.Drawing.Color.White;
            this.lbl_menuadi.Location = new System.Drawing.Point(16, 11);
            this.lbl_menuadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_menuadi.Name = "lbl_menuadi";
            this.lbl_menuadi.Size = new System.Drawing.Size(95, 25);
            this.lbl_menuadi.TabIndex = 0;
            this.lbl_menuadi.Text = "Menü Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(39, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(104, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri Tel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(80, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Müşteri Adres:";
            // 
            // txt_musteri
            // 
            this.txt_musteri.Location = new System.Drawing.Point(228, 80);
            this.txt_musteri.Name = "txt_musteri";
            this.txt_musteri.Size = new System.Drawing.Size(188, 22);
            this.txt_musteri.TabIndex = 0;
            // 
            // txt_mustel
            // 
            this.txt_mustel.Location = new System.Drawing.Point(228, 117);
            this.txt_mustel.MaxLength = 11;
            this.txt_mustel.Name = "txt_mustel";
            this.txt_mustel.Size = new System.Drawing.Size(188, 22);
            this.txt_mustel.TabIndex = 1;
            this.txt_mustel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mustel_KeyPress);
            // 
            // txt_musadres
            // 
            this.txt_musadres.AcceptsReturn = true;
            this.txt_musadres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_musadres.Location = new System.Drawing.Point(228, 156);
            this.txt_musadres.Multiline = true;
            this.txt_musadres.Name = "txt_musadres";
            this.txt_musadres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_musadres.Size = new System.Drawing.Size(476, 114);
            this.txt_musadres.TabIndex = 2;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.White;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Yu Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.ForeColor = System.Drawing.Color.MediumPurple;
            this.btn_ekle.Location = new System.Drawing.Point(229, 287);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(151, 56);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.White;
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Yu Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.MediumPurple;
            this.btn_guncelle.Location = new System.Drawing.Point(391, 287);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(151, 56);
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.White;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Yu Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.ForeColor = System.Drawing.Color.MediumPurple;
            this.btn_sil.Location = new System.Drawing.Point(553, 287);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(151, 56);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // MusteriListe
            // 
            this.MusteriListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MusteriListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusteriListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteri_id,
            this.musteri_adsoyad,
            this.musteri_tel,
            this.musteri_adres});
            this.MusteriListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MusteriListe.Location = new System.Drawing.Point(0, 375);
            this.MusteriListe.Name = "MusteriListe";
            this.MusteriListe.RowHeadersWidth = 50;
            this.MusteriListe.RowTemplate.Height = 25;
            this.MusteriListe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MusteriListe.Size = new System.Drawing.Size(800, 225);
            this.MusteriListe.TabIndex = 100;
            this.MusteriListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MusteriListe_CellDoubleClick);
            // 
            // musteri_id
            // 
            this.musteri_id.DataPropertyName = "musteri_id";
            this.musteri_id.HeaderText = "Müşteri ID";
            this.musteri_id.MinimumWidth = 6;
            this.musteri_id.Name = "musteri_id";
            this.musteri_id.Width = 125;
            // 
            // musteri_adsoyad
            // 
            this.musteri_adsoyad.DataPropertyName = "musteri_adsoyad";
            this.musteri_adsoyad.HeaderText = "Adı ve Soyadı";
            this.musteri_adsoyad.MinimumWidth = 6;
            this.musteri_adsoyad.Name = "musteri_adsoyad";
            this.musteri_adsoyad.Width = 150;
            // 
            // musteri_tel
            // 
            this.musteri_tel.DataPropertyName = "musteri_tel";
            this.musteri_tel.HeaderText = "Telefon Numarası";
            this.musteri_tel.MinimumWidth = 6;
            this.musteri_tel.Name = "musteri_tel";
            this.musteri_tel.Width = 125;
            // 
            // musteri_adres
            // 
            this.musteri_adres.DataPropertyName = "musteri_adres";
            this.musteri_adres.HeaderText = "Adres Bilgisi";
            this.musteri_adres.MinimumWidth = 300;
            this.musteri_adres.Name = "musteri_adres";
            this.musteri_adres.Width = 300;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(526, 118);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(188, 22);
            this.txt_id.TabIndex = 0;
            this.txt_id.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(488, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "İD";
            this.label5.Visible = false;
            // 
            // MusteriBolumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.MusteriListe);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_musadres);
            this.Controls.Add(this.txt_mustel);
            this.Controls.Add(this.txt_musteri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriBolumu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriBolumu";
            this.Load += new System.EventHandler(this.MusteriBolumu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_menuadi;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button MusteriKapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_musteri;
        private System.Windows.Forms.TextBox txt_mustel;
        private System.Windows.Forms.TextBox txt_musadres;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView MusteriListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_adres;
    }
}