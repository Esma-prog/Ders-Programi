using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DERS_PROGRAMI
{
    public partial class GIRIS : Form
    {
        public GIRIS()
        {
            InitializeComponent();
        }

        private void GIRIS_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void kapatlabel_Click(object sender, EventArgs e)
        {
            //çıkış butonu
            Application.Exit();
        }

        private void minilabel_Click(object sender, EventArgs e)
        {
            //minimalize butonu
            this.WindowState = FormWindowState.Minimized;
        }

        private void girisbuton_Click(object sender, EventArgs e)
        {
            //giriş butonu
            if (kullanıcıtextbox.Text == "esma" && sifretextbox.Text == "esma")
            {
                label1.Text = "Giriş başarılı.";
                MessageBox.Show("Yönlendiriliyorsunuz.", "Giriş Başarılı");
                DersProgramı arizali_Urun_Takip = new DersProgramı();
                this.Hide();
                arizali_Urun_Takip.Show();
            }
            else
            {
                if (kullanıcıtextbox.Text == "esma")

                {
                    MessageBox.Show("Şifre hatalı");
                }
                else
                {
                    if (sifretextbox.Text == "esma")
                    {
                        MessageBox.Show("Kullanıcı adı hatalı");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ve şifre hatalı");
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //şifreyi göster gizle checkboxı
            if (checkBox1.Checked)
            {
                sifretextbox.PasswordChar = '\0';
            }
            else
            {
                sifretextbox.PasswordChar = '*';
            }
        }

        private void kullanıcıtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
