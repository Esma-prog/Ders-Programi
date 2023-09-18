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

namespace DERS_PROGRAMI
{
    public partial class snfsil : Form
    {
        public snfsil()
        {
            InitializeComponent();
        }

        private void snfsil_Load(object sender, EventArgs e)
        {
            //güncelle formu açıldığında combobox 'a id lerin gelmesini sağlar
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "select Sınıf_ID from Sınıf";
            SqlCommand komut = new SqlCommand(sql, bag);
            bag.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Sınıf_ID"]);
            }
            bag.Close();
            silindilabel.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //id seçerek sınıf bilgilerinin gelmesini sağlayan kod
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "select * from Sınıf where Sınıf_Adı=@prm1";
            System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", comboBox1.SelectedItem);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sınıfadıtxt.Text = dt.Rows[0][1].ToString();
            sınıfmvcdtxt.Text = dt.Rows[0][2].ToString();
            
        }

        private void silindibutton_Click(object sender, EventArgs e)
        {
            // silindi butonunua tıklayarak verilerin silinmesini sağlar
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            bag.Open();
            string sql = "delete from Sınıf where Sınıf_Adı=@prm1";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", comboBox1.SelectedItem);
            komut.ExecuteNonQuery();
            bag.Close();
            silindilabel.Text = "Başarılı Bir Şekilde Silindi.";

            DersProgramı frm1 = new DersProgramı();
            frm1.sınıfgetir();
        }

        private void iptalbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            DersProgramı dersProgramı = new DersProgramı();
            dersProgramı.Show();
        }
    }
}
