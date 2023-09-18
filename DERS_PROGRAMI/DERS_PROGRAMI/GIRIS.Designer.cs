namespace DERS_PROGRAMI
{
    partial class GIRIS
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minilabel = new System.Windows.Forms.Label();
            this.kapatlabel = new System.Windows.Forms.Label();
            this.girislabel = new System.Windows.Forms.Label();
            this.sifretextbox = new System.Windows.Forms.TextBox();
            this.kullanıcıtextbox = new System.Windows.Forms.TextBox();
            this.sifrelabel = new System.Windows.Forms.Label();
            this.kullanıcılabel = new System.Windows.Forms.Label();
            this.girisbuton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Corbel", 8F);
            this.checkBox1.ForeColor = System.Drawing.Color.BurlyWood;
            this.checkBox1.Location = new System.Drawing.Point(41, 216);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(86, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Giriş başarılı.";
            // 
            // minilabel
            // 
            this.minilabel.AutoSize = true;
            this.minilabel.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minilabel.ForeColor = System.Drawing.Color.White;
            this.minilabel.Location = new System.Drawing.Point(204, -1);
            this.minilabel.Name = "minilabel";
            this.minilabel.Size = new System.Drawing.Size(28, 33);
            this.minilabel.TabIndex = 18;
            this.minilabel.Text = "_";
            this.minilabel.Click += new System.EventHandler(this.minilabel_Click);
            // 
            // kapatlabel
            // 
            this.kapatlabel.AutoSize = true;
            this.kapatlabel.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapatlabel.ForeColor = System.Drawing.Color.White;
            this.kapatlabel.Location = new System.Drawing.Point(229, 3);
            this.kapatlabel.Name = "kapatlabel";
            this.kapatlabel.Size = new System.Drawing.Size(31, 33);
            this.kapatlabel.TabIndex = 17;
            this.kapatlabel.Text = "X";
            this.kapatlabel.Click += new System.EventHandler(this.kapatlabel_Click);
            // 
            // girislabel
            // 
            this.girislabel.AutoSize = true;
            this.girislabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girislabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.girislabel.Location = new System.Drawing.Point(86, 42);
            this.girislabel.Name = "girislabel";
            this.girislabel.Size = new System.Drawing.Size(81, 23);
            this.girislabel.TabIndex = 16;
            this.girislabel.Text = "Giriş Yap";
            // 
            // sifretextbox
            // 
            this.sifretextbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sifretextbox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifretextbox.Location = new System.Drawing.Point(41, 182);
            this.sifretextbox.Multiline = true;
            this.sifretextbox.Name = "sifretextbox";
            this.sifretextbox.PasswordChar = '*';
            this.sifretextbox.Size = new System.Drawing.Size(181, 28);
            this.sifretextbox.TabIndex = 15;
            // 
            // kullanıcıtextbox
            // 
            this.kullanıcıtextbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.kullanıcıtextbox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıtextbox.Location = new System.Drawing.Point(41, 119);
            this.kullanıcıtextbox.Multiline = true;
            this.kullanıcıtextbox.Name = "kullanıcıtextbox";
            this.kullanıcıtextbox.Size = new System.Drawing.Size(181, 28);
            this.kullanıcıtextbox.TabIndex = 14;
            this.kullanıcıtextbox.TextChanged += new System.EventHandler(this.kullanıcıtextbox_TextChanged);
            // 
            // sifrelabel
            // 
            this.sifrelabel.AutoSize = true;
            this.sifrelabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrelabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.sifrelabel.Location = new System.Drawing.Point(37, 160);
            this.sifrelabel.Name = "sifrelabel";
            this.sifrelabel.Size = new System.Drawing.Size(40, 19);
            this.sifrelabel.TabIndex = 13;
            this.sifrelabel.Text = "Şifre";
            // 
            // kullanıcılabel
            // 
            this.kullanıcılabel.AutoSize = true;
            this.kullanıcılabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcılabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.kullanıcılabel.Location = new System.Drawing.Point(37, 97);
            this.kullanıcılabel.Name = "kullanıcılabel";
            this.kullanıcılabel.Size = new System.Drawing.Size(91, 19);
            this.kullanıcılabel.TabIndex = 12;
            this.kullanıcılabel.Text = "Kullanıcı Adı";
            // 
            // girisbuton
            // 
            this.girisbuton.BackColor = System.Drawing.Color.BurlyWood;
            this.girisbuton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbuton.Location = new System.Drawing.Point(41, 242);
            this.girisbuton.Name = "girisbuton";
            this.girisbuton.Size = new System.Drawing.Size(181, 36);
            this.girisbuton.TabIndex = 11;
            this.girisbuton.Text = "Giriş Yap";
            this.girisbuton.UseVisualStyleBackColor = false;
            this.girisbuton.Click += new System.EventHandler(this.girisbuton_Click);
            // 
            // GIRIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(262, 363);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minilabel);
            this.Controls.Add(this.kapatlabel);
            this.Controls.Add(this.girislabel);
            this.Controls.Add(this.sifretextbox);
            this.Controls.Add(this.kullanıcıtextbox);
            this.Controls.Add(this.sifrelabel);
            this.Controls.Add(this.kullanıcılabel);
            this.Controls.Add(this.girisbuton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GIRIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIRIS";
            this.Load += new System.EventHandler(this.GIRIS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minilabel;
        private System.Windows.Forms.Label kapatlabel;
        private System.Windows.Forms.Label girislabel;
        private System.Windows.Forms.TextBox sifretextbox;
        private System.Windows.Forms.TextBox kullanıcıtextbox;
        private System.Windows.Forms.Label sifrelabel;
        private System.Windows.Forms.Label kullanıcılabel;
        private System.Windows.Forms.Button girisbuton;
    }
}