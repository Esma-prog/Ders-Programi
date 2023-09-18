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
    public partial class DersProgramı : Form
    {
        public DersProgramı()
        {
            InitializeComponent();
        }

        private void DersProgramı_Load(object sender, EventArgs e)
        {// datagrıdde saatı combobxtan seçme
            SqlConnection bag2 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql3 = "select *  from Saat;";
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, bag2);
            DataTable tablo3 = new DataTable();
            da3.Fill(tablo3);
            saatp.DataSource = tablo3;
            saatp.DisplayMember = "SAAT";
            saatp.ValueMember = "SAAT_ID";

            // vt daki gün bilgileri combobxta gelmesini sağlayan kod
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql1 = "select * from GUN ;";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, bag);
            DataTable tablo1 = new DataTable();
            da1.Fill(tablo1);
            guncbx.DataSource = tablo1;
            guncbx.ValueMember = tablo1.Columns[0].ToString();
            guncbx.DisplayMember = tablo1.Columns[1].ToString();
           
            ogrgetir();// ogretmen verilerini load olayında cbxa getiren kod
            sınıfgetir();// sınıf verilerini load olayında cbxa getiren kod
            saatgetir();    // saat verilerini load olayında cbxa getiren kod
            Pazartesi_Click(sender, e);// pzt gununkı dersleri gride getiren kod
            Salı_Click(sender, e);// -salı gununkı dersleri gride getiren kod
            Çarşamba_Click(sender, e);//carsamba gununkı dersleri gride getiren kod
            Perşembe_Click(sender, e);// persembe gununkı dersleri gride getiren kod
            Cuma_Click(sender, e);// cuma gununkı dersleri gride getiren kod
            Öğretmenler_Click(sender, e);// ögretmenler bilgilerini load olayında grıde getirmesini sağlar.
            button1_Click(sender, e);//sınıflar load olayında getirmesini sağlar.

            //Veri tabanı bağlantı bilgileri
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True";
            //SQL sorgusu
            string query1 = "SELECT * FROM SINIF";
            string query2 = "SELECT * FROM OGRETMEN";
            string query3 = "SELECT * FROM GUN";
            string query4 = "SELECT * FROM SAAT";
            //Veri tabanı bağlantısı
            SqlConnection connection = new SqlConnection(connectionString);
            //SQL komutları
            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlCommand command2 = new SqlCommand(query2, connection);
            SqlCommand command3 = new SqlCommand(query3, connection);
            SqlCommand command4 = new SqlCommand(query4, connection);
            //Veri adaptörleri
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            SqlDataAdapter adapter3 = new SqlDataAdapter(command3);
            SqlDataAdapter adapter4 = new SqlDataAdapter(command4);
            //Veri tabloları
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            DataTable table4 = new DataTable();
            //Verileri adaptörlerden tablolara aktarma
            adapter1.Fill(table1);
            adapter2.Fill(table2);
            adapter3.Fill(table3);
            adapter4.Fill(table4);
            //ComboBox'ların veri kaynaklarını tablolar yapma
            sınıfcb1.DataSource = table1;
            ogrcb1.DataSource = table2;
            guncbx.DataSource = table3;
            saatcbx.DataSource = table4;

            //ComboBox'ların görüntüleyeceği kolonları belirleme
            sınıfcb1.DisplayMember = "SINIF_ADI";
            ogrcb1.DisplayMember = "OGR_ADI";
            guncbx.DisplayMember = "GÜN_ADI";
            saatcbx.DisplayMember = "SAAT";
            //ComboBox'ların değer olarak alacağı kolonları belirleme
            sınıfcb1.ValueMember = "SINIF_ADI";
            ogrcb1.ValueMember = "OGR_ID";
            guncbx.ValueMember = "GÜN_ID";
            saatcbx.ValueMember = "SAAT_ID";

        }
        public void sınıfgetir()
        {//combobox a sınıfın bilgilerinin gelmesini sağlar
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "select * from SINIF S";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            sınıfcb1.DataSource = tablo;
            sınıfcb1.DisplayMember = "SINIF_ADI";
            sınıfcb1.ValueMember = "SINIF_ADI";
        }
        public void ogrgetir()
        {
            //ÖĞRETMEN verilerini bilgilerini comboboxa gelmesını sağlar . verilerin hangısını gelmesını ıstersenız secebılırısnız.
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql2 = "select OGR_ID,OGR_ADI  from OGRETMEN O;";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, bag);
            DataTable tablo2 = new DataTable();
            da2.Fill(tablo2);
            ogrcb1.DataSource = tablo2;
            ogrcb1.ValueMember = tablo2.Columns[0].ToString();
            ogrcb1.DisplayMember = tablo2.Columns[1].ToString();

        }
        public void saatgetir()
        {
            //COMBOBOXA SAAT VERİLERİNİ GELMESİNİ SAĞLAR.
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql3 = "select Saat_ID,Saat  from Saat;";
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, bag);
            DataTable tablo3 = new DataTable();
            da3.Fill(tablo3);
            saatcbx.DataSource = tablo3;
            saatcbx.DisplayMember = tablo3.Columns[1].ToString();
            saatcbx.ValueMember = tablo3.Columns[0].ToString();

        }
        public void sqlgetirme()
        {
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
        }
        private void dersprogramıbtn_Click(object sender, EventArgs e)
        {
            //dersprogramın butonuna basınca click olayların hepsinin çalışmasını sağlar.
            Pazartesi_Click(sender, e);
            Salı_Click(sender, e);
            Çarşamba_Click(sender, e);
            Perşembe_Click(sender, e);
            Cuma_Click(sender, e);
        }

        private void cıkısbutton_Click(object sender, EventArgs e)
        {
            //çıkış butona basınca çıkışı sağlar.
            Application.Exit();
        }

        private void sınıfcb1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Pazartesi_Click(object sender, EventArgs e)
        {
            //butona basınca comboboxda seçili sınıfın pazartesigunu hangı dersi ve saatlerini getirir.
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "select D.DERS_ADI,SINIF_ADI FROM DERSPROGRAM DP,DERS D, SINIF SN WHERE (DP.SINIF_ID=SN.SINIF_ID)  AND (D.DERS_ID=DP.DERS_ID) AND (SN.SINIF_ADI=@prm1) AND DP.GÜN_ID=1";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", sınıfcb1.SelectedValue);
            DataTable dt = new DataTable();
            da.Fill(dt);
            pazartesidgv.DataSource = dt;

            DersProgramı frm1 = new DersProgramı();
            frm1.sınıfgetir();

            DersProgramı frm2 = new DersProgramı();
            frm2.ogrgetir();
        }

        private void Salı_Click(object sender, EventArgs e)
        { //butona basınca comboboxda seçili sınıfının salı gunu hangı dersi ve saatlerini getirir.
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "select S.SAAT,D.DERS_ADI, SINIF_ADI FROM DERSPROGRAM DP,DERS D,SAAT S, SINIF SN WHERE (DP.SINIF_ID=SN.SINIF_ID) AND (DP.SAAT_ID=S.SAAT_ID) AND (D.DERS_ID=DP.DERS_ID) AND (SN.SINIF_ADI=@prm1)  AND DP.GÜN_ID=2";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", sınıfcb1.SelectedValue);
            DataTable dt = new DataTable();
            da.Fill(dt);
            salıdgv.DataSource = dt;

            DersProgramı frm1 = new DersProgramı();
            frm1.sınıfgetir();

            DersProgramı frm2 = new DersProgramı();
            frm2.ogrgetir();

        }

        private void Çarşamba_Click(object sender, EventArgs e)
        { //butona basınca comboboxda seçili sınıfın çarşamba gunu hangı dersi ve saatlerini getirir.
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = " select S.SAAT,D.DERS_ADI, SINIF_ADI FROM DERSPROGRAM DP,DERS D,SAAT S, SINIF SN WHERE (DP.SINIF_ID=SN.SINIF_ID) AND (DP.SAAT_ID=S.SAAT_ID) AND (D.DERS_ID=DP.DERS_ID) AND (SN.SINIF_ADI=@prm1) AND DP.GÜN_ID=3";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", sınıfcb1.SelectedValue);
            DataTable dt = new DataTable();
            da.Fill(dt);
            çarşambadgv.DataSource = dt;

            DersProgramı frm1 = new DersProgramı();
            frm1.sınıfgetir();

            DersProgramı frm2 = new DersProgramı();
            frm2.ogrgetir();
        }

        private void Perşembe_Click(object sender, EventArgs e)
        { //butona basınca comboboxda seçili sınıfın perşembe gunu hangı dersi ve saatlerini getirir.
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "select S.SAAT,D.DERS_ADI, SINIF_ADI FROM DERSPROGRAM DP,DERS D,SAAT S, SINIF SN WHERE (DP.SINIF_ID=SN.SINIF_ID) AND (DP.SAAT_ID=S.SAAT_ID) AND (D.DERS_ID=DP.DERS_ID) AND (SN.SINIF_ADI=@prm1)  AND DP.GÜN_ID=4";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", sınıfcb1.SelectedValue);
            DataTable dt = new DataTable();
            da.Fill(dt);
            perşembedgv.DataSource = dt;

            DersProgramı frm1 = new DersProgramı();
            frm1.sınıfgetir();

            DersProgramı frm2 = new DersProgramı();
            frm2.ogrgetir();
        }

        private void Cuma_Click(object sender, EventArgs e)
        { //butona basınca comboboxda seçili sınıfın cuma gunu hangı dersi ve saatlerini getirir.
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "select S.SAAT,D.DERS_ADI, SINIF_ADI FROM DERSPROGRAM DP,DERS D,SAAT S, SINIF SN WHERE (DP.SINIF_ID=SN.SINIF_ID) AND (DP.SAAT_ID=S.SAAT_ID) AND (D.DERS_ID=DP.DERS_ID) AND (SN.SINIF_ADI=@prm1) AND DP.GÜN_ID=5";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", sınıfcb1.SelectedValue);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cumadgv.DataSource = dt;

            DersProgramı frm1 = new DersProgramı();
            frm1.sınıfgetir();

            DersProgramı frm2 = new DersProgramı();
            frm2.ogrgetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Öğretmenler_Click(object sender, EventArgs e)
        {
            // oğretmenler tablosundakı verilerin hepsini gride  getirir.
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "select * from OGRETMEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ogrsilbtn_Click(object sender, EventArgs e)
        { //ogretmen sil formunun form acıldıgından burdan bağlanarak açılmasını sağlayan kod
            ogrsil ogrsiil = new ogrsil();
            ogrsiil.Show();
            this.Hide();    
        }

        private void ogrgncbtn_Click(object sender, EventArgs e)
        {
            //ürün güncelleme formunu açma butonu
            ogrgnc ogrgnc = new ogrgnc();
            ogrgnc.Show();
            this.Hide();
        }

        private void ogreklebtn_Click(object sender, EventArgs e)
        {
            //öğretmen ekleme formunu açma butonu
            ogrekle ogrekle = new ogrekle();
            ogrekle.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrsil ogrsil = new ogrsil();
            ogrsil.Show();
            this.Hide();
        }

        private void snfeklebtn_Click(object sender, EventArgs e)
        {//sınıf ekleme formunun form acıldıgından burdan bağlanarak açılmasını sağlayan kod
            snıfekle sınıfekle = new snıfekle();
            sınıfekle.Show();   
            this.Hide();
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {// sınıflar butonuna tıklayarak sınıf verılerını gridde gelmesini sağlayan kod
            SqlConnection bag = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=dersprogramı;Integrated Security=True");
            string sql = "select * from SINIF";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guncbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {//YAZDIR BUTONU  

            //ComboBox'tan seçilen kitap id'sini almak
            int SINIF_ADI = Convert.ToInt32(sınıfcb1.SelectedValue);
            //ComboBox'tan seçilen yazar id'sini almak
            int OGR_ID = Convert.ToInt32(ogrcb1.SelectedValue);
            //ComboBox'tan seçilen yazar id'sini almak
            int GÜN_ID = Convert.ToInt32(guncbx.SelectedValue);
            //ComboBox'tan seçilen yazar id'sini almak
            int SAAT_ID = Convert.ToInt32(saatcbx.SelectedValue);

            //Seçilen id'leri ekrana yazdırmak
            MessageBox.Show("SINIF ADI: " + SINIF_ADI + "\nOGRETMEN ID: " + OGR_ID+ "\nGÜN ID: " + GÜN_ID + "\nSAAT ID:" + SAAT_ID );

            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pazartesidgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sınıfsilbtn_Click(object sender, EventArgs e)
        {// sınıflar butonuna tıklayarak sınıf verılerını silinmesini sağlayan kod
            snfsil sınıfsil = new snfsil();
            sınıfsil.Show();
            this.Hide();
        }

        private void sınıfgncbtn_Click(object sender, EventArgs e)
        {// sınıflar butonuna tıklayarak sınıf verılerını guncellenmesını sağlayan kod
            sınıfgnc sınıfgncc = new sınıfgnc();
            sınıfgncc.Show();
            this.Hide();
        }

        private void saatcbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
