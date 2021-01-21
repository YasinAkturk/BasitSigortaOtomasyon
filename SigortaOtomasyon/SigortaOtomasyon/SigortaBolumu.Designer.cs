
namespace SigortaOtomasyon
{
    partial class SigortaBolumu
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
            this.SigortaKapa = new System.Windows.Forms.Button();
            this.lbl_menuadi = new System.Windows.Forms.Label();
            this.SigortaListe = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_sigturu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ben_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sigorta_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigorta_turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SigortaListe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.SigortaKapa);
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
            // SigortaKapa
            // 
            this.SigortaKapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SigortaKapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SigortaKapa.FlatAppearance.BorderSize = 0;
            this.SigortaKapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SigortaKapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SigortaKapa.ForeColor = System.Drawing.Color.White;
            this.SigortaKapa.Location = new System.Drawing.Point(744, 10);
            this.SigortaKapa.Margin = new System.Windows.Forms.Padding(4);
            this.SigortaKapa.Name = "SigortaKapa";
            this.SigortaKapa.Size = new System.Drawing.Size(40, 28);
            this.SigortaKapa.TabIndex = 1;
            this.SigortaKapa.Tag = "";
            this.SigortaKapa.Text = "X";
            this.SigortaKapa.UseVisualStyleBackColor = false;
            this.SigortaKapa.Click += new System.EventHandler(this.SigortaKapa_Click);
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
            // SigortaListe
            // 
            this.SigortaListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SigortaListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SigortaListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SigortaListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sigorta_id,
            this.sigorta_turu});
            this.SigortaListe.Dock = System.Windows.Forms.DockStyle.Right;
            this.SigortaListe.Location = new System.Drawing.Point(447, 47);
            this.SigortaListe.Name = "SigortaListe";
            this.SigortaListe.RowHeadersWidth = 51;
            this.SigortaListe.RowTemplate.Height = 24;
            this.SigortaListe.Size = new System.Drawing.Size(353, 553);
            this.SigortaListe.TabIndex = 2;
            this.SigortaListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SigortaListe_CellDoubleClick);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.White;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Yu Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.ForeColor = System.Drawing.Color.MediumPurple;
            this.btn_ekle.Location = new System.Drawing.Point(69, 252);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(315, 56);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_sigturu
            // 
            this.txt_sigturu.Location = new System.Drawing.Point(196, 178);
            this.txt_sigturu.Name = "txt_sigturu";
            this.txt_sigturu.Size = new System.Drawing.Size(188, 22);
            this.txt_sigturu.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(64, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sigorta Türü:";
            // 
            // ben_guncelle
            // 
            this.ben_guncelle.BackColor = System.Drawing.Color.White;
            this.ben_guncelle.FlatAppearance.BorderSize = 0;
            this.ben_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ben_guncelle.Font = new System.Drawing.Font("Yu Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ben_guncelle.ForeColor = System.Drawing.Color.MediumPurple;
            this.ben_guncelle.Location = new System.Drawing.Point(69, 324);
            this.ben_guncelle.Name = "ben_guncelle";
            this.ben_guncelle.Size = new System.Drawing.Size(315, 56);
            this.ben_guncelle.TabIndex = 14;
            this.ben_guncelle.Text = "Güncelle";
            this.ben_guncelle.UseVisualStyleBackColor = false;
            this.ben_guncelle.Click += new System.EventHandler(this.ben_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.White;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Yu Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.ForeColor = System.Drawing.Color.MediumPurple;
            this.btn_sil.Location = new System.Drawing.Point(69, 396);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(315, 56);
            this.btn_sil.TabIndex = 15;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(196, 103);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(188, 22);
            this.txt_id.TabIndex = 17;
            this.txt_id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(64, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "id";
            this.label1.Visible = false;
            // 
            // sigorta_id
            // 
            this.sigorta_id.DataPropertyName = "sigorta_id";
            this.sigorta_id.HeaderText = "Sigorta ID";
            this.sigorta_id.MinimumWidth = 6;
            this.sigorta_id.Name = "sigorta_id";
            // 
            // sigorta_turu
            // 
            this.sigorta_turu.DataPropertyName = "sigorta_turu";
            this.sigorta_turu.HeaderText = "Sigorta Türü";
            this.sigorta_turu.MinimumWidth = 6;
            this.sigorta_turu.Name = "sigorta_turu";
            this.sigorta_turu.Width = 200;
            // 
            // SigortaBolumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.ben_guncelle);
            this.Controls.Add(this.txt_sigturu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.SigortaListe);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SigortaBolumu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigortaBolumu";
            this.Load += new System.EventHandler(this.SigortaBolumu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SigortaListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SigortaKapa;
        private System.Windows.Forms.Label lbl_menuadi;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_sigturu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ben_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView SigortaListe;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigorta_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigorta_turu;
    }
}