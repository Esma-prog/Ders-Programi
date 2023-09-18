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
    public partial class ogrgnc : Form
    {
        public ogrgnc()
        {
            InitializeComponent();
        }

        private void iptalbutton_Click(object sender, EventArgs e)
        {
            //iptal butonu
            this.Close();
            DersProgramı DersProgramı = new DersProgramı();
            DersProgramı.Show();
        }

        private void eklebutton_Click(object sender, EventArgs e)
        {

            //güncelle butonu
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "update OGRETMEN set OGR_ADI=@prm2,OGR_SOYADI=@prm3,OGR_DOĞUMTARIHI=@prm4,OGR_TC=@prm5,OGR_TELEFON=@prm6,OGR_EPOSTA=@prm7 where OGR_ID=@prm1";
            bag.Open();
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", comboBox1.SelectedItem);
            komut.Parameters.AddWithValue("@prm2", ogradıtxt.Text);
            komut.Parameters.AddWithValue("@prm3", ogrsoyadıtxt.Text);
            komut.Parameters.AddWithValue("@prm4", ogrdttxt.Text);
            komut.Parameters.AddWithValue("@prm5", ogrtctxt.Text);
            komut.Parameters.AddWithValue("@prm6", ogrgsmtxt.Text);
            komut.Parameters.AddWithValue("@prm7", ogrepostatxt.Text);
            komut.ExecuteNonQuery();
            bag.Close();
            kaydedildilabel.Text = "Başarılı Bir Şekilde Güncellendi.";

            DersProgramı frm1 = new DersProgramı();
            frm1.ogrgetir();
        }

        private void ogrgnc_Load(object sender, EventArgs e)
        {
            //güncelle formu açıldığında combobox 'a id lerin gelmesini sağlar
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "select OGR_ID from OGRETMEN";
            SqlCommand komut = new SqlCommand(sql, bag);
            bag.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["OGR_ID"]);
            }
            bag.Close();
            kaydedildilabel.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //id seçerek öğretmen bilgilerinin gelmesini sağlayan kod
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "select * from OGRETMEN where OGR_ID=@prm1";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", comboBox1.SelectedItem);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ogradıtxt.Text = dt.Rows[0][1].ToString();
            ogrsoyadıtxt.Text = dt.Rows[0][2].ToString();
            ogrdttxt.Text = dt.Rows[0][3].ToString();
            ogrtctxt.Text = dt.Rows[0][4].ToString();
            ogrgsmtxt.Text = dt.Rows[0][5].ToString();
            ogrepostatxt.Text = dt.Rows[0][6].ToString();
        }
    }
}
