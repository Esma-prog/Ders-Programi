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
    public partial class snıfekle : Form
    {
        public snıfekle()/*(ComboBox cbsinifekle )*/
        {
            InitializeComponent();
            //cbsnf = cbsinifekle;
        }

        //public ComboBox cbsnf;
        private void iptalbutton_Click(object sender, EventArgs e)
        {
            //iptal butonu
            this.Close();
            DersProgramı DersProgramı = new DersProgramı();
            DersProgramı.Show();
        }

        private void eklebutton_Click(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            bag.Open();
            string sql = "insert into SINIF (SINIF_ADI,SINIF_MEVCUDU) values (@prm1,@prm2)";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", snfadıtxt.Text);
            komut.Parameters.AddWithValue("@prm2", snfmevcuıtxt.Text);
            komut.ExecuteNonQuery();
            bag.Close();
            eklenildilabel.Text = "Başarılı Bir Şekilde Eklendi.";
            DersProgramı frm1 = new DersProgramı();
            frm1.sınıfgetir();
            //SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            //string sql2 = "select * from SINIF";
            //SqlDataAdapter da = new SqlDataAdapter(sql2, bag);
            //DataTable tablo = new DataTable();
            //da.Fill(tablo);
            //cbsnf.DataSource = tablo;
            //cbsnf.DisplayMember = "SINIF_ADI";
            //cbsnf.ValueMember = "SINIF_ADI";

        }

        private void snıfekle_Load(object sender, EventArgs e)
        {
          eklenildilabel.Text = "";

            
        }
    }
}
