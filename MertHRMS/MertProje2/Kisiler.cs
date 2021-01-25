using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MertProje2
{
    public partial class Kisiler : Form
    {
        public Kisiler()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        int id = 0;
        int rowindex = 0;
        #region Grid Doldurma
        public void GridDoldur()
        {
            Kisiler kisi = new Kisiler();


            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MertData"].ConnectionString;
            con.Open();
            string AllList = "select * from Kisiler";
            SqlCommand cmd = new SqlCommand(AllList, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gKisiler.DataSource = dt;
            con.Close();
            gKisiler.Columns[0].Visible = false;



        }
        
        public void Kisiler_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        #endregion
        #region Arama
        private void arama(string aranacak)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MertData"].ConnectionString;
            string AllList = "select * FROM Kisiler WHERE AdSoyad Like '" + aranacak + "%" + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(AllList, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gKisiler.DataSource = dt;
        }
        private void txtKArama_TextChanged(object sender, EventArgs e)
        {
            arama(txtKArama.Text);
        }
        #endregion 
        #region Kişi Ekleme
        private void btnKEkle_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "" || txtTelefon.Text == "" || txtMail.Text == "" || txtAdres.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz!");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["MertData"].ConnectionString;
                string AllList = "insert into Kisiler (AdSoyad,Tel,Email,Adres) values (@AdSoyad,@Tel,@Email,@Adres)";
                SqlCommand cmd = new SqlCommand(AllList, con);
                cmd.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@Tel", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@Email", txtMail.Text);
                cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GridDoldur();
                
                txtBosalt1();
            }
        }
        #endregion
        #region Text Boşaltma
        private void txtBosalt1()
        {
            txtAdSoyad.Text = "";
            txtTelefon.Text = "";
            txtMail.Text = "";
            txtAdres.Text = "";
        }
        #endregion
        #region Kişi Güncelleme
        private void Guncelle(int ID)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MertData"].ConnectionString;
            con.Open();
            string AllList = "update Kisiler SET AdSoyad = @AdSoyad, Tel=@Tel, Email=@Email, Adres=@Adres where ID="+ID;
            SqlCommand cmd = new SqlCommand(AllList,con);
            cmd.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@Tel", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@Email", txtMail.Text);
            cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        

        private void btnKGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle(id);
            GridDoldur();
            txtBosalt1();
        }
        private void txtDoldur(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MertData"].ConnectionString;
            string AllList = "select AdSoyad,Tel,Email,Adres from Kisiler where ID=" + id;
            SqlCommand cmd = new SqlCommand(AllList, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow row = dt.Rows[0];
            txtAdSoyad.Text = row["AdSoyad"].ToString();
            txtTelefon.Text = row["Tel"].ToString();
            txtMail.Text = row["Email"].ToString();
            txtAdres.Text = row["Adres"].ToString();

        }
        #endregion


        private void gKisiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            id = Convert.ToInt32(gKisiler.Rows[rowindex].Cells[0].Value.ToString());
            txtDoldur(id);
        }
        #region Kişi Silme

        private void btnKSil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MertData"].ConnectionString;
            string AllList = "DELETE FROM Kisiler where ID=@id";
            SqlCommand cmd = new SqlCommand(AllList, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
            txtBosalt1();


        }
        #endregion

        private void grpKisiler_Enter(object sender, EventArgs e)
        {

        }

    }
}
