namespace DERS_PROGRAMI
{
    partial class DersProgramı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DersProgramı));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ogrcb1 = new System.Windows.Forms.ComboBox();
            this.saatcbx = new System.Windows.Forms.ComboBox();
            this.guncbx = new System.Windows.Forms.ComboBox();
            this.saatlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ÖğretmenlerBTN = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sınıfcb1 = new System.Windows.Forms.ComboBox();
            this.snfeklebtn = new System.Windows.Forms.Button();
            this.ogrsıl = new System.Windows.Forms.Button();
            this.ogrgncbtn = new System.Windows.Forms.Button();
            this.ogreklebtn = new System.Windows.Forms.Button();
            this.dersprogramıbtn = new System.Windows.Forms.Button();
            this.cıkısbutton = new System.Windows.Forms.Button();
            this.pazartesidgv = new System.Windows.Forms.DataGridView();
            this.saatp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Pazartesi = new System.Windows.Forms.Button();
            this.salıdgv = new System.Windows.Forms.DataGridView();
            this.Salı = new System.Windows.Forms.Button();
            this.çarşambadgv = new System.Windows.Forms.DataGridView();
            this.Çarşamba = new System.Windows.Forms.Button();
            this.perşembedgv = new System.Windows.Forms.DataGridView();
            this.Perşembe = new System.Windows.Forms.Button();
            this.cumadgv = new System.Windows.Forms.DataGridView();
            this.Cuma = new System.Windows.Forms.Button();
            this.sınıfsilbtn = new System.Windows.Forms.Button();
            this.sınıfgncbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazartesidgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salıdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.çarşambadgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perşembedgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cumadgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ogrcb1);
            this.panel1.Controls.Add(this.saatcbx);
            this.panel1.Controls.Add(this.guncbx);
            this.panel1.Controls.Add(this.saatlbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.ÖğretmenlerBTN);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.sınıfcb1);
            this.panel1.Location = new System.Drawing.Point(19, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 245);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(900, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 83);
            this.button3.TabIndex = 23;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(742, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 82);
            this.button2.TabIndex = 22;
            this.button2.Text = "YAZDIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ogrcb1
            // 
            this.ogrcb1.DisplayMember = "OGR_ADI";
            this.ogrcb1.FormattingEnabled = true;
            this.ogrcb1.Location = new System.Drawing.Point(166, 80);
            this.ogrcb1.Name = "ogrcb1";
            this.ogrcb1.Size = new System.Drawing.Size(121, 21);
            this.ogrcb1.TabIndex = 21;
            this.ogrcb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // saatcbx
            // 
            this.saatcbx.FormattingEnabled = true;
            this.saatcbx.Location = new System.Drawing.Point(842, 77);
            this.saatcbx.Name = "saatcbx";
            this.saatcbx.Size = new System.Drawing.Size(178, 21);
            this.saatcbx.TabIndex = 20;
            this.saatcbx.SelectedIndexChanged += new System.EventHandler(this.saatcbx_SelectedIndexChanged);
            // 
            // guncbx
            // 
            this.guncbx.DisplayMember = "GÜN_ADI";
            this.guncbx.FormattingEnabled = true;
            this.guncbx.Location = new System.Drawing.Point(842, 29);
            this.guncbx.Name = "guncbx";
            this.guncbx.Size = new System.Drawing.Size(178, 21);
            this.guncbx.TabIndex = 19;
            this.guncbx.ValueMember = "GÜN_ID";
            this.guncbx.SelectedIndexChanged += new System.EventHandler(this.guncbx_SelectedIndexChanged);
            // 
            // saatlbl
            // 
            this.saatlbl.AutoSize = true;
            this.saatlbl.BackColor = System.Drawing.Color.White;
            this.saatlbl.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.saatlbl.Location = new System.Drawing.Point(753, 80);
            this.saatlbl.Name = "saatlbl";
            this.saatlbl.Size = new System.Drawing.Size(46, 21);
            this.saatlbl.TabIndex = 18;
            this.saatlbl.Text = "Saat";
            this.saatlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.label1.Location = new System.Drawing.Point(753, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gün";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.button1.Location = new System.Drawing.Point(18, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Derslikler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(321, 120);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ÖğretmenlerBTN
            // 
            this.ÖğretmenlerBTN.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.ÖğretmenlerBTN.Image = ((System.Drawing.Image)(resources.GetObject("ÖğretmenlerBTN.Image")));
            this.ÖğretmenlerBTN.Location = new System.Drawing.Point(18, 62);
            this.ÖğretmenlerBTN.Name = "ÖğretmenlerBTN";
            this.ÖğretmenlerBTN.Size = new System.Drawing.Size(131, 127);
            this.ÖğretmenlerBTN.TabIndex = 1;
            this.ÖğretmenlerBTN.Text = "Öğretmenler";
            this.ÖğretmenlerBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ÖğretmenlerBTN.UseVisualStyleBackColor = true;
            this.ÖğretmenlerBTN.Click += new System.EventHandler(this.Öğretmenler_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(358, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(321, 58);
            this.dataGridView2.TabIndex = 16;
            // 
            // sınıfcb1
            // 
            this.sınıfcb1.DisplayMember = "SINIF_ADI";
            this.sınıfcb1.FormattingEnabled = true;
            this.sınıfcb1.Location = new System.Drawing.Point(166, 25);
            this.sınıfcb1.Name = "sınıfcb1";
            this.sınıfcb1.Size = new System.Drawing.Size(131, 21);
            this.sınıfcb1.TabIndex = 9;
            this.sınıfcb1.ValueMember = "I";
            this.sınıfcb1.SelectedIndexChanged += new System.EventHandler(this.sınıfcb1_SelectedIndexChanged);
            // 
            // snfeklebtn
            // 
            this.snfeklebtn.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.snfeklebtn.Location = new System.Drawing.Point(1182, 466);
            this.snfeklebtn.Name = "snfeklebtn";
            this.snfeklebtn.Size = new System.Drawing.Size(189, 36);
            this.snfeklebtn.TabIndex = 15;
            this.snfeklebtn.Text = "Derslik Ekle";
            this.snfeklebtn.UseVisualStyleBackColor = true;
            this.snfeklebtn.Click += new System.EventHandler(this.snfeklebtn_Click);
            // 
            // ogrsıl
            // 
            this.ogrsıl.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.ogrsıl.Location = new System.Drawing.Point(1184, 631);
            this.ogrsıl.Name = "ogrsıl";
            this.ogrsıl.Size = new System.Drawing.Size(190, 36);
            this.ogrsıl.TabIndex = 14;
            this.ogrsıl.Text = "Ögr.Sil";
            this.ogrsıl.UseVisualStyleBackColor = true;
            this.ogrsıl.Click += new System.EventHandler(this.button1_Click);
            // 
            // ogrgncbtn
            // 
            this.ogrgncbtn.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.ogrgncbtn.Location = new System.Drawing.Point(1184, 673);
            this.ogrgncbtn.Name = "ogrgncbtn";
            this.ogrgncbtn.Size = new System.Drawing.Size(190, 38);
            this.ogrgncbtn.TabIndex = 13;
            this.ogrgncbtn.Text = "Ögr.Güncelle";
            this.ogrgncbtn.UseVisualStyleBackColor = true;
            this.ogrgncbtn.Click += new System.EventHandler(this.ogrgncbtn_Click);
            // 
            // ogreklebtn
            // 
            this.ogreklebtn.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.ogreklebtn.Location = new System.Drawing.Point(1184, 592);
            this.ogreklebtn.Name = "ogreklebtn";
            this.ogreklebtn.Size = new System.Drawing.Size(190, 33);
            this.ogreklebtn.TabIndex = 10;
            this.ogreklebtn.Text = "Ögr.Ekle";
            this.ogreklebtn.UseVisualStyleBackColor = true;
            this.ogreklebtn.Click += new System.EventHandler(this.ogreklebtn_Click);
            // 
            // dersprogramıbtn
            // 
            this.dersprogramıbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.dersprogramıbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dersprogramıbtn.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.dersprogramıbtn.Image = ((System.Drawing.Image)(resources.GetObject("dersprogramıbtn.Image")));
            this.dersprogramıbtn.Location = new System.Drawing.Point(3, 2);
            this.dersprogramıbtn.Name = "dersprogramıbtn";
            this.dersprogramıbtn.Size = new System.Drawing.Size(127, 163);
            this.dersprogramıbtn.TabIndex = 0;
            this.dersprogramıbtn.Text = "Ders Programı";
            this.dersprogramıbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dersprogramıbtn.UseVisualStyleBackColor = false;
            this.dersprogramıbtn.Click += new System.EventHandler(this.dersprogramıbtn_Click);
            // 
            // cıkısbutton
            // 
            this.cıkısbutton.BackColor = System.Drawing.Color.LightCoral;
            this.cıkısbutton.Font = new System.Drawing.Font("Cascadia Mono", 14F);
            this.cıkısbutton.ForeColor = System.Drawing.Color.Black;
            this.cıkısbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cıkısbutton.Location = new System.Drawing.Point(1231, 727);
            this.cıkısbutton.Name = "cıkısbutton";
            this.cıkısbutton.Size = new System.Drawing.Size(171, 41);
            this.cıkısbutton.TabIndex = 8;
            this.cıkısbutton.Text = "Çıkış";
            this.cıkısbutton.UseVisualStyleBackColor = false;
            this.cıkısbutton.Click += new System.EventHandler(this.cıkısbutton_Click);
            // 
            // pazartesidgv
            // 
            this.pazartesidgv.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.pazartesidgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pazartesidgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saatp});
            this.pazartesidgv.Location = new System.Drawing.Point(136, 90);
            this.pazartesidgv.Name = "pazartesidgv";
            this.pazartesidgv.Size = new System.Drawing.Size(241, 335);
            this.pazartesidgv.TabIndex = 3;
            this.pazartesidgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pazartesidgv_CellContentClick);
            // 
            // saatp
            // 
            this.saatp.HeaderText = "Saat";
            this.saatp.Name = "saatp";
            this.saatp.Width = 60;
            // 
            // Pazartesi
            // 
            this.Pazartesi.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.Pazartesi.Location = new System.Drawing.Point(192, 32);
            this.Pazartesi.Name = "Pazartesi";
            this.Pazartesi.Size = new System.Drawing.Size(130, 45);
            this.Pazartesi.TabIndex = 4;
            this.Pazartesi.Text = "Pazartesi";
            this.Pazartesi.UseVisualStyleBackColor = true;
            this.Pazartesi.Click += new System.EventHandler(this.Pazartesi_Click);
            // 
            // salıdgv
            // 
            this.salıdgv.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.salıdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salıdgv.Location = new System.Drawing.Point(392, 90);
            this.salıdgv.Name = "salıdgv";
            this.salıdgv.Size = new System.Drawing.Size(241, 335);
            this.salıdgv.TabIndex = 3;
            // 
            // Salı
            // 
            this.Salı.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.Salı.Location = new System.Drawing.Point(445, 32);
            this.Salı.Name = "Salı";
            this.Salı.Size = new System.Drawing.Size(130, 45);
            this.Salı.TabIndex = 4;
            this.Salı.Text = "Salı";
            this.Salı.UseVisualStyleBackColor = true;
            this.Salı.Click += new System.EventHandler(this.Salı_Click);
            // 
            // çarşambadgv
            // 
            this.çarşambadgv.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.çarşambadgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.çarşambadgv.Location = new System.Drawing.Point(639, 90);
            this.çarşambadgv.Name = "çarşambadgv";
            this.çarşambadgv.Size = new System.Drawing.Size(241, 335);
            this.çarşambadgv.TabIndex = 3;
            // 
            // Çarşamba
            // 
            this.Çarşamba.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.Çarşamba.Location = new System.Drawing.Point(677, 32);
            this.Çarşamba.Name = "Çarşamba";
            this.Çarşamba.Size = new System.Drawing.Size(130, 45);
            this.Çarşamba.TabIndex = 4;
            this.Çarşamba.Text = "Çarşamba";
            this.Çarşamba.UseVisualStyleBackColor = true;
            this.Çarşamba.Click += new System.EventHandler(this.Çarşamba_Click);
            // 
            // perşembedgv
            // 
            this.perşembedgv.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.perşembedgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perşembedgv.Location = new System.Drawing.Point(886, 90);
            this.perşembedgv.Name = "perşembedgv";
            this.perşembedgv.Size = new System.Drawing.Size(241, 335);
            this.perşembedgv.TabIndex = 3;
            // 
            // Perşembe
            // 
            this.Perşembe.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.Perşembe.Location = new System.Drawing.Point(940, 32);
            this.Perşembe.Name = "Perşembe";
            this.Perşembe.Size = new System.Drawing.Size(130, 45);
            this.Perşembe.TabIndex = 4;
            this.Perşembe.Text = "Perşembe";
            this.Perşembe.UseVisualStyleBackColor = true;
            this.Perşembe.Click += new System.EventHandler(this.Perşembe_Click);
            // 
            // cumadgv
            // 
            this.cumadgv.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.cumadgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cumadgv.Location = new System.Drawing.Point(1133, 90);
            this.cumadgv.Name = "cumadgv";
            this.cumadgv.Size = new System.Drawing.Size(241, 335);
            this.cumadgv.TabIndex = 3;
            // 
            // Cuma
            // 
            this.Cuma.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.Cuma.Location = new System.Drawing.Point(1182, 32);
            this.Cuma.Name = "Cuma";
            this.Cuma.Size = new System.Drawing.Size(130, 45);
            this.Cuma.TabIndex = 4;
            this.Cuma.Text = "Cuma";
            this.Cuma.UseVisualStyleBackColor = true;
            this.Cuma.Click += new System.EventHandler(this.Cuma_Click);
            // 
            // sınıfsilbtn
            // 
            this.sınıfsilbtn.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.sınıfsilbtn.Location = new System.Drawing.Point(1182, 508);
            this.sınıfsilbtn.Name = "sınıfsilbtn";
            this.sınıfsilbtn.Size = new System.Drawing.Size(189, 36);
            this.sınıfsilbtn.TabIndex = 16;
            this.sınıfsilbtn.Text = "Derslik Sil";
            this.sınıfsilbtn.UseVisualStyleBackColor = true;
            this.sınıfsilbtn.Click += new System.EventHandler(this.sınıfsilbtn_Click);
            // 
            // sınıfgncbtn
            // 
            this.sınıfgncbtn.Font = new System.Drawing.Font("Cascadia Mono Light", 12F);
            this.sınıfgncbtn.Location = new System.Drawing.Point(1182, 550);
            this.sınıfgncbtn.Name = "sınıfgncbtn";
            this.sınıfgncbtn.Size = new System.Drawing.Size(189, 36);
            this.sınıfgncbtn.TabIndex = 17;
            this.sınıfgncbtn.Text = "Derslik Güncelle";
            this.sınıfgncbtn.UseVisualStyleBackColor = true;
            this.sınıfgncbtn.Click += new System.EventHandler(this.sınıfgncbtn_Click);
            // 
            // DersProgramı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1405, 780);
            this.ControlBox = false;
            this.Controls.Add(this.sınıfgncbtn);
            this.Controls.Add(this.sınıfsilbtn);
            this.Controls.Add(this.dersprogramıbtn);
            this.Controls.Add(this.Cuma);
            this.Controls.Add(this.Perşembe);
            this.Controls.Add(this.Çarşamba);
            this.Controls.Add(this.ogrgncbtn);
            this.Controls.Add(this.ogrsıl);
            this.Controls.Add(this.Salı);
            this.Controls.Add(this.ogreklebtn);
            this.Controls.Add(this.cıkısbutton);
            this.Controls.Add(this.snfeklebtn);
            this.Controls.Add(this.Pazartesi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cumadgv);
            this.Controls.Add(this.perşembedgv);
            this.Controls.Add(this.çarşambadgv);
            this.Controls.Add(this.salıdgv);
            this.Controls.Add(this.pazartesidgv);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DersProgramı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DersProgramı";
            this.Load += new System.EventHandler(this.DersProgramı_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazartesidgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salıdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.çarşambadgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perşembedgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cumadgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cıkısbutton;
        private System.Windows.Forms.Button ÖğretmenlerBTN;
        private System.Windows.Forms.Button dersprogramıbtn;
        private System.Windows.Forms.DataGridView pazartesidgv;
        private System.Windows.Forms.ComboBox sınıfcb1;
        private System.Windows.Forms.Button Pazartesi;
        private System.Windows.Forms.DataGridView salıdgv;
        private System.Windows.Forms.Button Salı;
        private System.Windows.Forms.DataGridView çarşambadgv;
        private System.Windows.Forms.Button Çarşamba;
        private System.Windows.Forms.DataGridView perşembedgv;
        private System.Windows.Forms.Button Perşembe;
        private System.Windows.Forms.DataGridView cumadgv;
        private System.Windows.Forms.Button Cuma;
        private System.Windows.Forms.Button ogreklebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ogrgncbtn;
        private System.Windows.Forms.Button ogrsıl;
        private System.Windows.Forms.Button snfeklebtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label saatlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox guncbx;
        private System.Windows.Forms.ComboBox saatcbx;
        private System.Windows.Forms.ComboBox ogrcb1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button sınıfsilbtn;
        private System.Windows.Forms.Button sınıfgncbtn;
        private System.Windows.Forms.DataGridViewComboBoxColumn saatp;
    }
}

