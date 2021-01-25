namespace MertProje2
{
    partial class Kisiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kisiler));
            this.grpKisiler = new System.Windows.Forms.GroupBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtKArama = new System.Windows.Forms.TextBox();
            this.lblKArama = new System.Windows.Forms.Label();
            this.btnKEkle = new System.Windows.Forms.Button();
            this.btnKGuncelle = new System.Windows.Forms.Button();
            this.btnKSil = new System.Windows.Forms.Button();
            this.gKisiler = new System.Windows.Forms.DataGridView();
            this.grpKisiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gKisiler)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKisiler
            // 
            resources.ApplyResources(this.grpKisiler, "grpKisiler");
            this.grpKisiler.Controls.Add(this.lblAdres);
            this.grpKisiler.Controls.Add(this.lblMail);
            this.grpKisiler.Controls.Add(this.lblTelefon);
            this.grpKisiler.Controls.Add(this.lblAdSoyad);
            this.grpKisiler.Controls.Add(this.txtAdres);
            this.grpKisiler.Controls.Add(this.txtMail);
            this.grpKisiler.Controls.Add(this.txtTelefon);
            this.grpKisiler.Controls.Add(this.txtAdSoyad);
            this.grpKisiler.Name = "grpKisiler";
            this.grpKisiler.TabStop = false;
            this.grpKisiler.Enter += new System.EventHandler(this.grpKisiler_Enter);
            // 
            // lblAdres
            // 
            resources.ApplyResources(this.lblAdres, "lblAdres");
            this.lblAdres.Name = "lblAdres";
            // 
            // lblMail
            // 
            resources.ApplyResources(this.lblMail, "lblMail");
            this.lblMail.Name = "lblMail";
            // 
            // lblTelefon
            // 
            resources.ApplyResources(this.lblTelefon, "lblTelefon");
            this.lblTelefon.Name = "lblTelefon";
            // 
            // lblAdSoyad
            // 
            resources.ApplyResources(this.lblAdSoyad, "lblAdSoyad");
            this.lblAdSoyad.Name = "lblAdSoyad";
            // 
            // txtAdres
            // 
            resources.ApplyResources(this.txtAdres, "txtAdres");
            this.txtAdres.Name = "txtAdres";
            // 
            // txtMail
            // 
            resources.ApplyResources(this.txtMail, "txtMail");
            this.txtMail.Name = "txtMail";
            // 
            // txtTelefon
            // 
            resources.ApplyResources(this.txtTelefon, "txtTelefon");
            this.txtTelefon.Name = "txtTelefon";
            // 
            // txtAdSoyad
            // 
            resources.ApplyResources(this.txtAdSoyad, "txtAdSoyad");
            this.txtAdSoyad.Name = "txtAdSoyad";
            // 
            // txtKArama
            // 
            resources.ApplyResources(this.txtKArama, "txtKArama");
            this.txtKArama.Name = "txtKArama";
            this.txtKArama.TextChanged += new System.EventHandler(this.txtKArama_TextChanged);
            // 
            // lblKArama
            // 
            resources.ApplyResources(this.lblKArama, "lblKArama");
            this.lblKArama.Name = "lblKArama";
            // 
            // btnKEkle
            // 
            resources.ApplyResources(this.btnKEkle, "btnKEkle");
            this.btnKEkle.Name = "btnKEkle";
            this.btnKEkle.UseVisualStyleBackColor = true;
            this.btnKEkle.Click += new System.EventHandler(this.btnKEkle_Click);
            // 
            // btnKGuncelle
            // 
            resources.ApplyResources(this.btnKGuncelle, "btnKGuncelle");
            this.btnKGuncelle.Name = "btnKGuncelle";
            this.btnKGuncelle.UseVisualStyleBackColor = true;
            this.btnKGuncelle.Click += new System.EventHandler(this.btnKGuncelle_Click);
            // 
            // btnKSil
            // 
            resources.ApplyResources(this.btnKSil, "btnKSil");
            this.btnKSil.Name = "btnKSil";
            this.btnKSil.UseVisualStyleBackColor = true;
            this.btnKSil.Click += new System.EventHandler(this.btnKSil_Click);
            // 
            // gKisiler
            // 
            resources.ApplyResources(this.gKisiler, "gKisiler");
            this.gKisiler.AllowUserToAddRows = false;
            this.gKisiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gKisiler.Name = "gKisiler";
            this.gKisiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gKisiler_CellClick);
            // 
            // Kisiler
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.gKisiler);
            this.Controls.Add(this.btnKSil);
            this.Controls.Add(this.btnKGuncelle);
            this.Controls.Add(this.btnKEkle);
            this.Controls.Add(this.lblKArama);
            this.Controls.Add(this.txtKArama);
            this.Controls.Add(this.grpKisiler);
            this.Name = "Kisiler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Kisiler_Load);
            this.grpKisiler.ResumeLayout(false);
            this.grpKisiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gKisiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKisiler;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtKArama;
        private System.Windows.Forms.Label lblKArama;
        private System.Windows.Forms.Button btnKEkle;
        private System.Windows.Forms.Button btnKGuncelle;
        private System.Windows.Forms.Button btnKSil;
        public System.Windows.Forms.DataGridView gKisiler;
    }
}