namespace MertProje2
{
    partial class MertProje2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MertProje2));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tslKisi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslProje = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslVerim = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslCikis = new System.Windows.Forms.ToolStripButton();
            this.Panel = new System.Windows.Forms.Panel();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            resources.ApplyResources(this.tsMenu, "tsMenu");
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tslKisi,
            this.tslProje,
            this.toolStripSeparator2,
            this.tslVerim,
            this.toolStripSeparator3,
            this.tslCikis});
            this.tsMenu.Name = "tsMenu";
            // 
            // tslKisi
            // 
            resources.ApplyResources(this.tslKisi, "tslKisi");
            this.tslKisi.Image = global::MertProje2.Properties.Resources.listing_icon_seat;
            this.tslKisi.Name = "tslKisi";
            this.tslKisi.Click += new System.EventHandler(this.tslKisi_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // tslProje
            // 
            resources.ApplyResources(this.tslProje, "tslProje");
            this.tslProje.Image = global::MertProje2.Properties.Resources.project;
            this.tslProje.Name = "tslProje";
            this.tslProje.Click += new System.EventHandler(this.tslProje_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // tslVerim
            // 
            resources.ApplyResources(this.tslVerim, "tslVerim");
            this.tslVerim.Image = global::MertProje2.Properties.Resources.graph_32;
            this.tslVerim.Name = "tslVerim";
            this.tslVerim.Click += new System.EventHandler(this.tslVerim_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // tslCikis
            // 
            resources.ApplyResources(this.tslCikis, "tslCikis");
            this.tslCikis.Image = global::MertProje2.Properties.Resources.to_exit__system_icon_42706;
            this.tslCikis.Name = "tslCikis";
            this.tslCikis.Click += new System.EventHandler(this.tslCikis_Click);
            // 
            // Panel
            // 
            resources.ApplyResources(this.Panel, "Panel");
            this.Panel.Name = "Panel";
            // 
            // MertProje2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.tsMenu);
            this.IsMdiContainer = true;
            this.Name = "MertProje2";
            this.Load += new System.EventHandler(this.MertProje2_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tslProje;
        private System.Windows.Forms.ToolStripButton tslVerim;
        private System.Windows.Forms.ToolStripButton tslCikis;
        private System.Windows.Forms.ToolStripButton tslKisi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel Panel;
    }
}

