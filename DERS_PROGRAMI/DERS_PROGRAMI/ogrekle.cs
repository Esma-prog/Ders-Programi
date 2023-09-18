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
    public partial class ogrekle : Form
    {
        public ogrekle()
        {
            InitializeComponent();
        }

        private void personeleklelabel_Click(object sender, EventArgs e)
        {

        }

        private void ogrekle_Load(object sender, EventArgs e)
        {
            kaydedildilabel.Text = "";
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
            //ekle butonu
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            bag.Open();
            string sql = "insert into OGRETMEN (OGR_ADI,OGR_SOYADI,OGR_DOĞUMTARIHI,OGR_TC,OGR_TELEFON,OGR_EPOSTA) values (@prm1,@prm2,@prm3,@prm4,@prm5,@prm6)";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", ogradıtxt.Text);
            komut.Parameters.AddWithValue("@prm2", ogrsoyadıtxt.Text);
            komut.Parameters.AddWithValue("@prm3", ogrdttxt.Text);
            komut.Parameters.AddWithValue("@prm4", ogrtctxt.Text);
            komut.Parameters.AddWithValue("@prm5", ogrgsmtxt.Text);
            komut.Parameters.AddWithValue("@prm6", ogrepostatxt.Text);
           
            komut.ExecuteNonQuery();
            bag.Close();
            kaydedildilabel.Text = "Başarılı Bir Şekilde Eklendi.";
            DersProgramı frm1 = new DersProgramı();
            frm1.ogrgetir();
        }
    }
}
