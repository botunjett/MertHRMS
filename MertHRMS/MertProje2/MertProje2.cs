using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;
using System.Resources;
using System.Threading;


namespace MertProje2
{
    public partial class MertProje2 : Form
    {
        
        public MertProje2()
        {
            
            
            InitializeComponent();
        }
        ResourceManager res_man;
        CultureInfo cul;
        private void tslKisi_Click(object sender, EventArgs e)
        {

            
            Kisiler mod = new Kisiler();
            
            

                Panel.Controls.Clear();

            

            
            
                mod.TopLevel = false;
                mod.AutoScroll = true;
                mod.FormBorderStyle = FormBorderStyle.None;
                Panel.Controls.Add(mod);



                mod.Show();
            
            
            
            
            
            
 
            
            
        }

        private void tslProje_Click(object sender, EventArgs e)
        {
            Panel.Controls.Clear();

            
            
            Projeler mod1 = new Projeler();
            
            
           
            mod1.TopLevel = false;
            mod1.AutoScroll = true;
            mod1.FormBorderStyle = FormBorderStyle.None;
            Panel.Controls.Add(mod1);
            
            mod1.Show();
            
            
        }

        private void tslVerim_Click(object sender, EventArgs e)
        {
            Panel.Controls.Clear();
            
            Verim mod2 = new Verim();
            
            
            mod2.TopLevel = false;
            mod2.AutoScroll = true;
            mod2.FormBorderStyle = FormBorderStyle.None;
            Panel.Controls.Add(mod2);
            mod2.Show();
            
            
        }

        

        private void MertProje2_Load(object sender, EventArgs e)
        {
            

        }

        private void tslCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
