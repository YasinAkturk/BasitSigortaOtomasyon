
namespace SigortaOtomasyon
{
    partial class PoliceBolumu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_menuadi = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.ben_guncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.baslangic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bitis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PoliceListe = new System.Windows.Forms.DataGridView();
            this.police_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigorta_turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.police_baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.police_bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.police_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterisec = new System.Windows.Forms.ComboBox();
            this.sigortaturu = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.sigortaDBDataSet = new SigortaOtomasyon.SigortaDBDataSet();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter = new SigortaOtomasyon.SigortaDBDataSetTableAdapters.MusteriTableAdapter();
            this.sigortaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sigortaTableAdapter = new SigortaOtomasyon.SigortaDBDataSetTableAdapters.SigortaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PoliceListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_menuadi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 1;
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
            this.button2.TabIndex = 2;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(744, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 28);
            this.button1.TabIndex = 1;
            this.button1.Tag = "";
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.White;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Yu Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.ForeColor = System.Drawing.Color.MediumPurple;
            this.btn_sil.Location = new System.Drawing.Point(478, 228);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(234, 56);
            this.btn_sil.TabIndex = 20;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // ben_guncelle
            // 
            this.ben_guncelle.BackColor = System.Drawing.Color.White;
            this.ben_guncelle.FlatAppearance.BorderSize = 0;
            this.ben_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ben_guncelle.Font = new System.Drawing.Font("Yu Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ben_guncelle.ForeColor = System.Drawing.Color.MediumPurple;
            this.ben_guncelle.Location = new System.Drawing.Point(478, 158);
            this.ben_guncelle.Name = "ben_guncelle";
            this.ben_guncelle.Size = new System.Drawing.Size(234, 56);
            this.ben_guncelle.TabIndex = 19;
            this.ben_guncelle.Text = "Güncelle";
            this.ben_guncelle.UseVisualStyleBackColor = false;
            this.ben_guncelle.Click += new System.EventHandler(this.ben_guncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(148, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = " Müsteri Seç";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.White;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Yu Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.ForeColor = System.Drawing.Color.MediumPurple;
            this.btn_ekle.Location = new System.Drawing.Point(478, 88);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(234, 56);
            this.btn_ekle.TabIndex = 16;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(141, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sigorta Türü:";
            // 
            // baslangic
            // 
            this.baslangic.Location = new System.Drawing.Point(273, 176);
            this.baslangic.Name = "baslangic";
            this.baslangic.Size = new System.Drawing.Size(188, 22);
            this.baslangic.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(53, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Poliçe Başlangıç Tarihi:";
            // 
            // bitis
            // 
            this.bitis.Location = new System.Drawing.Point(273, 220);
            this.bitis.Name = "bitis";
            this.bitis.Size = new System.Drawing.Size(188, 22);
            this.bitis.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(103, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Poliçe Bitiş Tarihi";
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(273, 264);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(188, 22);
            this.fiyat.TabIndex = 28;
            this.fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fiyat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(204, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fiyat:";
            // 
            // PoliceListe
            // 
            this.PoliceListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PoliceListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PoliceListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PoliceListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.police_id,
            this.musteri,
            this.sigorta_turu,
            this.police_baslangic,
            this.police_bitis,
            this.police_fiyat});
            this.PoliceListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PoliceListe.Location = new System.Drawing.Point(0, 351);
            this.PoliceListe.Name = "PoliceListe";
            this.PoliceListe.RowHeadersWidth = 51;
            this.PoliceListe.RowTemplate.Height = 24;
            this.PoliceListe.Size = new System.Drawing.Size(800, 249);
            this.PoliceListe.TabIndex = 29;
            this.PoliceListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PoliceListe_CellDoubleClick);
            // 
            // police_id
            // 
            this.police_id.DataPropertyName = "police_id";
            this.police_id.HeaderText = "Poliçe ID";
            this.police_id.MinimumWidth = 6;
            this.police_id.Name = "police_id";
            this.police_id.Width = 125;
            // 
            // musteri
            // 
            this.musteri.DataPropertyName = "musteri";
            this.musteri.HeaderText = "Müşteri";
            this.musteri.MinimumWidth = 6;
            this.musteri.Name = "musteri";
            this.musteri.Width = 150;
            // 
            // sigorta_turu
            // 
            this.sigorta_turu.DataPropertyName = "sigorta_turu";
            this.sigorta_turu.HeaderText = "Sigorta Türü";
            this.sigorta_turu.MinimumWidth = 6;
            this.sigorta_turu.Name = "sigorta_turu";
            this.sigorta_turu.Width = 125;
            // 
            // police_baslangic
            // 
            this.police_baslangic.DataPropertyName = "police_baslangic";
            this.police_baslangic.HeaderText = "Başlangıç Tarihi";
            this.police_baslangic.MinimumWidth = 6;
            this.police_baslangic.Name = "police_baslangic";
            this.police_baslangic.Width = 125;
            // 
            // police_bitis
            // 
            this.police_bitis.DataPropertyName = "police_bitis";
            this.police_bitis.HeaderText = "Bitiş Tarihi";
            this.police_bitis.MinimumWidth = 6;
            this.police_bitis.Name = "police_bitis";
            this.police_bitis.Width = 125;
            // 
            // police_fiyat
            // 
            this.police_fiyat.DataPropertyName = "police_fiyat";
            this.police_fiyat.HeaderText = "Fiyat";
            this.police_fiyat.MinimumWidth = 6;
            this.police_fiyat.Name = "police_fiyat";
            this.police_fiyat.Width = 125;
            // 
            // musterisec
            // 
            this.musterisec.DataSource = this.musteriBindingSource;
            this.musterisec.DisplayMember = "musteri_adsoyad";
            this.musterisec.FormattingEnabled = true;
            this.musterisec.Location = new System.Drawing.Point(274, 84);
            this.musterisec.Name = "musterisec";
            this.musterisec.Size = new System.Drawing.Size(187, 24);
            this.musterisec.TabIndex = 30;
            this.musterisec.ValueMember = "musteri_adsoyad";
            // 
            // sigortaturu
            // 
            this.sigortaturu.DataSource = this.sigortaBindingSource;
            this.sigortaturu.DisplayMember = "sigorta_turu";
            this.sigortaturu.FormattingEnabled = true;
            this.sigortaturu.Location = new System.Drawing.Point(273, 132);
            this.sigortaturu.Name = "sigortaturu";
            this.sigortaturu.Size = new System.Drawing.Size(187, 24);
            this.sigortaturu.TabIndex = 31;
            this.sigortaturu.ValueMember = "sigorta_turu";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID.ForeColor = System.Drawing.Color.MediumPurple;
            this.ID.Location = new System.Drawing.Point(232, 300);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 25);
            this.ID.TabIndex = 32;
            this.ID.Text = "ID";
            this.ID.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(306, 304);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(188, 22);
            this.txt_id.TabIndex = 33;
            this.txt_id.Visible = false;
            // 
            // sigortaDBDataSet
            // 
            this.sigortaDBDataSet.DataSetName = "SigortaDBDataSet";
            this.sigortaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.sigortaDBDataSet;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // sigortaBindingSource
            // 
            this.sigortaBindingSource.DataMember = "Sigorta";
            this.sigortaBindingSource.DataSource = this.sigortaDBDataSet;
            // 
            // sigortaTableAdapter
            // 
            this.sigortaTableAdapter.ClearBeforeFill = true;
            // 
            // PoliceBolumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.sigortaturu);
            this.Controls.Add(this.musterisec);
            this.Controls.Add(this.PoliceListe);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bitis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.baslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.ben_guncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PoliceBolumu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoliceGiris";
            this.Load += new System.EventHandler(this.PoliceKapa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PoliceListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigortaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_menuadi;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button ben_guncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox baslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bitis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView PoliceListe;
        private System.Windows.Forms.ComboBox sigortaturu;
        public System.Windows.Forms.ComboBox musterisec;
        private System.Windows.Forms.DataGridViewTextBoxColumn police_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigorta_turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn police_baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn police_bitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn police_fiyat;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txt_id;
        private SigortaDBDataSet sigortaDBDataSet;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private SigortaDBDataSetTableAdapters.MusteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.BindingSource sigortaBindingSource;
        private SigortaDBDataSetTableAdapters.SigortaTableAdapter sigortaTableAdapter;
    }
}