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
    public partial class ogrsil : Form
    {
        public ogrsil()
        {
            InitializeComponent();
        }

        private void ogrgnclabel_Click(object sender, EventArgs e)
        {

        }

        private void iptalbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            DersProgramı dersProgramı = new DersProgramı();
            dersProgramı.Show();
        }

        private void ogrsil_Load(object sender, EventArgs e)
        {
            //SİL formu açıldığında combobox 'a id lerin gelmesini sağlar
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
            silindilabel.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //id seçerek öğretmen bilgilerinin gelmesini sağlayan kod
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "select * from OGRETMEN where OGR_ID=@prm1";
            System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter(sql, bag);
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

        private void silindibutton_Click(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            bag.Open();
            string sql = "delete from OGRETMEN where OGR_ID=@prm1";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", comboBox1.SelectedItem);
            komut.ExecuteNonQuery();
            bag.Close();
            silindilabel.Text = "Başarılı Bir Şekilde Silindi.";

            DersProgramı frm1 = new DersProgramı();
            frm1.ogrgetir();

        }
    }
}
