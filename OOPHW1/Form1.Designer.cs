namespace OOPHW1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.grpGirişBilgileri = new System.Windows.Forms.GroupBox();
            this.btnİleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.mtxBitişDeğeri = new System.Windows.Forms.MaskedTextBox();
            this.lblBitişDeğeri = new System.Windows.Forms.Label();
            this.mtxBaşlangıçDeğeri = new System.Windows.Forms.MaskedTextBox();
            this.lblBaşlangıçDeğeri = new System.Windows.Forms.Label();
            this.tabSonuç = new System.Windows.Forms.TabControl();
            this.tbpTekSayılar = new System.Windows.Forms.TabPage();
            this.txtTekÇarpım = new System.Windows.Forms.TextBox();
            this.lblTekÇarpım = new System.Windows.Forms.Label();
            this.txtTekToplam = new System.Windows.Forms.TextBox();
            this.lblTekToplam = new System.Windows.Forms.Label();
            this.lstvTekSonuç = new System.Windows.Forms.ListView();
            this.tbpÇiftSayılar = new System.Windows.Forms.TabPage();
            this.txtÇiftÇarpım = new System.Windows.Forms.TextBox();
            this.lblÇiftÇarpım = new System.Windows.Forms.Label();
            this.txtÇiftToplam = new System.Windows.Forms.TextBox();
            this.lblÇiftToplam = new System.Windows.Forms.Label();
            this.lstvÇiftSonuç = new System.Windows.Forms.ListView();
            this.tbpAsalSayılar = new System.Windows.Forms.TabPage();
            this.txtAsalÇarpım = new System.Windows.Forms.TextBox();
            this.lblAsalÇarpım = new System.Windows.Forms.Label();
            this.txtAsalToplam = new System.Windows.Forms.TextBox();
            this.lblAsalToplam = new System.Windows.Forms.Label();
            this.lstvAsalSayılar = new System.Windows.Forms.ListView();
            this.tbpArmstrongSayıları = new System.Windows.Forms.TabPage();
            this.txtArmstrongÇarpım = new System.Windows.Forms.TextBox();
            this.lblArmstrongÇarpım = new System.Windows.Forms.Label();
            this.txtArmstrongToplam = new System.Windows.Forms.TextBox();
            this.lblArmstrongToplam = new System.Windows.Forms.Label();
            this.lstvArmstrongSayıları = new System.Windows.Forms.ListView();
            this.myıcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnTemizle = new System.Windows.Forms.Button();
            this.grpGirişBilgileri.SuspendLayout();
            this.tabSonuç.SuspendLayout();
            this.tbpTekSayılar.SuspendLayout();
            this.tbpÇiftSayılar.SuspendLayout();
            this.tbpAsalSayılar.SuspendLayout();
            this.tbpArmstrongSayıları.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGirişBilgileri
            // 
            this.grpGirişBilgileri.Controls.Add(this.btnTemizle);
            this.grpGirişBilgileri.Controls.Add(this.btnİleri);
            this.grpGirişBilgileri.Controls.Add(this.btnGeri);
            this.grpGirişBilgileri.Controls.Add(this.btnHesapla);
            this.grpGirişBilgileri.Controls.Add(this.mtxBitişDeğeri);
            this.grpGirişBilgileri.Controls.Add(this.lblBitişDeğeri);
            this.grpGirişBilgileri.Controls.Add(this.mtxBaşlangıçDeğeri);
            this.grpGirişBilgileri.Controls.Add(this.lblBaşlangıçDeğeri);
            this.grpGirişBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpGirişBilgileri.Name = "grpGirişBilgileri";
            this.grpGirişBilgileri.Size = new System.Drawing.Size(776, 73);
            this.grpGirişBilgileri.TabIndex = 0;
            this.grpGirişBilgileri.TabStop = false;
            this.grpGirişBilgileri.Text = "Giriş Bilgileri";
            // 
            // btnİleri
            // 
            this.btnİleri.Location = new System.Drawing.Point(572, 22);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(77, 32);
            this.btnİleri.TabIndex = 6;
            this.btnİleri.Text = "İleri>>";
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(489, 22);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(77, 32);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "<<Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(395, 22);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(77, 32);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // mtxBitişDeğeri
            // 
            this.mtxBitişDeğeri.Location = new System.Drawing.Point(270, 28);
            this.mtxBitişDeğeri.Mask = "00000";
            this.mtxBitişDeğeri.Name = "mtxBitişDeğeri";
            this.mtxBitişDeğeri.Size = new System.Drawing.Size(100, 20);
            this.mtxBitişDeğeri.TabIndex = 3;
            // 
            // lblBitişDeğeri
            // 
            this.lblBitişDeğeri.AutoSize = true;
            this.lblBitişDeğeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitişDeğeri.Location = new System.Drawing.Point(230, 28);
            this.lblBitişDeğeri.Name = "lblBitişDeğeri";
            this.lblBitişDeğeri.Size = new System.Drawing.Size(34, 17);
            this.lblBitişDeğeri.TabIndex = 2;
            this.lblBitişDeğeri.Text = "Bitiş";
            // 
            // mtxBaşlangıçDeğeri
            // 
            this.mtxBaşlangıçDeğeri.Location = new System.Drawing.Point(87, 28);
            this.mtxBaşlangıçDeğeri.Mask = "0000";
            this.mtxBaşlangıçDeğeri.Name = "mtxBaşlangıçDeğeri";
            this.mtxBaşlangıçDeğeri.Size = new System.Drawing.Size(100, 20);
            this.mtxBaşlangıçDeğeri.TabIndex = 1;
            // 
            // lblBaşlangıçDeğeri
            // 
            this.lblBaşlangıçDeğeri.AutoSize = true;
            this.lblBaşlangıçDeğeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaşlangıçDeğeri.Location = new System.Drawing.Point(12, 28);
            this.lblBaşlangıçDeğeri.Name = "lblBaşlangıçDeğeri";
            this.lblBaşlangıçDeğeri.Size = new System.Drawing.Size(69, 17);
            this.lblBaşlangıçDeğeri.TabIndex = 0;
            this.lblBaşlangıçDeğeri.Text = "Başlangıç";
            // 
            // tabSonuç
            // 
            this.tabSonuç.Controls.Add(this.tbpTekSayılar);
            this.tabSonuç.Controls.Add(this.tbpÇiftSayılar);
            this.tabSonuç.Controls.Add(this.tbpAsalSayılar);
            this.tabSonuç.Controls.Add(this.tbpArmstrongSayıları);
            this.tabSonuç.Location = new System.Drawing.Point(12, 91);
            this.tabSonuç.Name = "tabSonuç";
            this.tabSonuç.SelectedIndex = 0;
            this.tabSonuç.Size = new System.Drawing.Size(786, 282);
            this.tabSonuç.TabIndex = 17;
            // 
            // tbpTekSayılar
            // 
            this.tbpTekSayılar.Controls.Add(this.txtTekÇarpım);
            this.tbpTekSayılar.Controls.Add(this.lblTekÇarpım);
            this.tbpTekSayılar.Controls.Add(this.txtTekToplam);
            this.tbpTekSayılar.Controls.Add(this.lblTekToplam);
            this.tbpTekSayılar.Controls.Add(this.lstvTekSonuç);
            this.tbpTekSayılar.Location = new System.Drawing.Point(4, 22);
            this.tbpTekSayılar.Name = "tbpTekSayılar";
            this.tbpTekSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTekSayılar.Size = new System.Drawing.Size(778, 256);
            this.tbpTekSayılar.TabIndex = 0;
            this.tbpTekSayılar.Text = "Tek Sayılar";
            this.tbpTekSayılar.UseVisualStyleBackColor = true;
            // 
            // txtTekÇarpım
            // 
            this.txtTekÇarpım.Location = new System.Drawing.Point(297, 17);
            this.txtTekÇarpım.Name = "txtTekÇarpım";
            this.txtTekÇarpım.ReadOnly = true;
            this.txtTekÇarpım.Size = new System.Drawing.Size(100, 20);
            this.txtTekÇarpım.TabIndex = 21;
            // 
            // lblTekÇarpım
            // 
            this.lblTekÇarpım.AutoSize = true;
            this.lblTekÇarpım.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTekÇarpım.Location = new System.Drawing.Point(222, 17);
            this.lblTekÇarpım.Name = "lblTekÇarpım";
            this.lblTekÇarpım.Size = new System.Drawing.Size(56, 17);
            this.lblTekÇarpım.TabIndex = 20;
            this.lblTekÇarpım.Text = "Çarpım:";
            // 
            // txtTekToplam
            // 
            this.txtTekToplam.Location = new System.Drawing.Point(83, 17);
            this.txtTekToplam.Name = "txtTekToplam";
            this.txtTekToplam.ReadOnly = true;
            this.txtTekToplam.Size = new System.Drawing.Size(100, 20);
            this.txtTekToplam.TabIndex = 19;
            this.txtTekToplam.ReadOnlyChanged += new System.EventHandler(this.txtTekToplam_ReadOnlyChanged);
            // 
            // lblTekToplam
            // 
            this.lblTekToplam.AutoSize = true;
            this.lblTekToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTekToplam.Location = new System.Drawing.Point(8, 17);
            this.lblTekToplam.Name = "lblTekToplam";
            this.lblTekToplam.Size = new System.Drawing.Size(59, 17);
            this.lblTekToplam.TabIndex = 7;
            this.lblTekToplam.Text = "Toplam:";
            // 
            // lstvTekSonuç
            // 
            this.lstvTekSonuç.Location = new System.Drawing.Point(6, 49);
            this.lstvTekSonuç.Name = "lstvTekSonuç";
            this.lstvTekSonuç.Size = new System.Drawing.Size(766, 201);
            this.lstvTekSonuç.TabIndex = 18;
            this.lstvTekSonuç.UseCompatibleStateImageBehavior = false;
            // 
            // tbpÇiftSayılar
            // 
            this.tbpÇiftSayılar.Controls.Add(this.txtÇiftÇarpım);
            this.tbpÇiftSayılar.Controls.Add(this.lblÇiftÇarpım);
            this.tbpÇiftSayılar.Controls.Add(this.txtÇiftToplam);
            this.tbpÇiftSayılar.Controls.Add(this.lblÇiftToplam);
            this.tbpÇiftSayılar.Controls.Add(this.lstvÇiftSonuç);
            this.tbpÇiftSayılar.Location = new System.Drawing.Point(4, 22);
            this.tbpÇiftSayılar.Name = "tbpÇiftSayılar";
            this.tbpÇiftSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpÇiftSayılar.Size = new System.Drawing.Size(778, 256);
            this.tbpÇiftSayılar.TabIndex = 1;
            this.tbpÇiftSayılar.Text = "Çift Sayılar";
            this.tbpÇiftSayılar.UseVisualStyleBackColor = true;
            // 
            // txtÇiftÇarpım
            // 
            this.txtÇiftÇarpım.Location = new System.Drawing.Point(298, 16);
            this.txtÇiftÇarpım.Name = "txtÇiftÇarpım";
            this.txtÇiftÇarpım.ReadOnly = true;
            this.txtÇiftÇarpım.Size = new System.Drawing.Size(100, 20);
            this.txtÇiftÇarpım.TabIndex = 25;
            // 
            // lblÇiftÇarpım
            // 
            this.lblÇiftÇarpım.AutoSize = true;
            this.lblÇiftÇarpım.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÇiftÇarpım.Location = new System.Drawing.Point(223, 16);
            this.lblÇiftÇarpım.Name = "lblÇiftÇarpım";
            this.lblÇiftÇarpım.Size = new System.Drawing.Size(56, 17);
            this.lblÇiftÇarpım.TabIndex = 24;
            this.lblÇiftÇarpım.Text = "Çarpım:";
            // 
            // txtÇiftToplam
            // 
            this.txtÇiftToplam.Location = new System.Drawing.Point(84, 16);
            this.txtÇiftToplam.Name = "txtÇiftToplam";
            this.txtÇiftToplam.ReadOnly = true;
            this.txtÇiftToplam.Size = new System.Drawing.Size(100, 20);
            this.txtÇiftToplam.TabIndex = 23;
            // 
            // lblÇiftToplam
            // 
            this.lblÇiftToplam.AutoSize = true;
            this.lblÇiftToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÇiftToplam.Location = new System.Drawing.Point(9, 16);
            this.lblÇiftToplam.Name = "lblÇiftToplam";
            this.lblÇiftToplam.Size = new System.Drawing.Size(59, 17);
            this.lblÇiftToplam.TabIndex = 22;
            this.lblÇiftToplam.Text = "Toplam:";
            // 
            // lstvÇiftSonuç
            // 
            this.lstvÇiftSonuç.Location = new System.Drawing.Point(6, 51);
            this.lstvÇiftSonuç.Name = "lstvÇiftSonuç";
            this.lstvÇiftSonuç.Size = new System.Drawing.Size(766, 199);
            this.lstvÇiftSonuç.TabIndex = 18;
            this.lstvÇiftSonuç.UseCompatibleStateImageBehavior = false;
            // 
            // tbpAsalSayılar
            // 
            this.tbpAsalSayılar.Controls.Add(this.txtAsalÇarpım);
            this.tbpAsalSayılar.Controls.Add(this.lblAsalÇarpım);
            this.tbpAsalSayılar.Controls.Add(this.txtAsalToplam);
            this.tbpAsalSayılar.Controls.Add(this.lblAsalToplam);
            this.tbpAsalSayılar.Controls.Add(this.lstvAsalSayılar);
            this.tbpAsalSayılar.Location = new System.Drawing.Point(4, 22);
            this.tbpAsalSayılar.Name = "tbpAsalSayılar";
            this.tbpAsalSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAsalSayılar.Size = new System.Drawing.Size(778, 256);
            this.tbpAsalSayılar.TabIndex = 2;
            this.tbpAsalSayılar.Text = "AsalSayılar";
            this.tbpAsalSayılar.UseVisualStyleBackColor = true;
            // 
            // txtAsalÇarpım
            // 
            this.txtAsalÇarpım.Location = new System.Drawing.Point(297, 17);
            this.txtAsalÇarpım.Name = "txtAsalÇarpım";
            this.txtAsalÇarpım.ReadOnly = true;
            this.txtAsalÇarpım.Size = new System.Drawing.Size(100, 20);
            this.txtAsalÇarpım.TabIndex = 25;
            // 
            // lblAsalÇarpım
            // 
            this.lblAsalÇarpım.AutoSize = true;
            this.lblAsalÇarpım.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsalÇarpım.Location = new System.Drawing.Point(222, 17);
            this.lblAsalÇarpım.Name = "lblAsalÇarpım";
            this.lblAsalÇarpım.Size = new System.Drawing.Size(56, 17);
            this.lblAsalÇarpım.TabIndex = 24;
            this.lblAsalÇarpım.Text = "Çarpım:";
            // 
            // txtAsalToplam
            // 
            this.txtAsalToplam.Location = new System.Drawing.Point(83, 17);
            this.txtAsalToplam.Name = "txtAsalToplam";
            this.txtAsalToplam.ReadOnly = true;
            this.txtAsalToplam.Size = new System.Drawing.Size(100, 20);
            this.txtAsalToplam.TabIndex = 23;
            // 
            // lblAsalToplam
            // 
            this.lblAsalToplam.AutoSize = true;
            this.lblAsalToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsalToplam.Location = new System.Drawing.Point(8, 17);
            this.lblAsalToplam.Name = "lblAsalToplam";
            this.lblAsalToplam.Size = new System.Drawing.Size(59, 17);
            this.lblAsalToplam.TabIndex = 22;
            this.lblAsalToplam.Text = "Toplam:";
            // 
            // lstvAsalSayılar
            // 
            this.lstvAsalSayılar.Location = new System.Drawing.Point(6, 53);
            this.lstvAsalSayılar.Name = "lstvAsalSayılar";
            this.lstvAsalSayılar.Size = new System.Drawing.Size(766, 197);
            this.lstvAsalSayılar.TabIndex = 18;
            this.lstvAsalSayılar.UseCompatibleStateImageBehavior = false;
            // 
            // tbpArmstrongSayıları
            // 
            this.tbpArmstrongSayıları.Controls.Add(this.txtArmstrongÇarpım);
            this.tbpArmstrongSayıları.Controls.Add(this.lblArmstrongÇarpım);
            this.tbpArmstrongSayıları.Controls.Add(this.txtArmstrongToplam);
            this.tbpArmstrongSayıları.Controls.Add(this.lblArmstrongToplam);
            this.tbpArmstrongSayıları.Controls.Add(this.lstvArmstrongSayıları);
            this.tbpArmstrongSayıları.Location = new System.Drawing.Point(4, 22);
            this.tbpArmstrongSayıları.Name = "tbpArmstrongSayıları";
            this.tbpArmstrongSayıları.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArmstrongSayıları.Size = new System.Drawing.Size(778, 256);
            this.tbpArmstrongSayıları.TabIndex = 3;
            this.tbpArmstrongSayıları.Text = "Armstrong Sayıları";
            this.tbpArmstrongSayıları.UseVisualStyleBackColor = true;
            // 
            // txtArmstrongÇarpım
            // 
            this.txtArmstrongÇarpım.Location = new System.Drawing.Point(295, 18);
            this.txtArmstrongÇarpım.Name = "txtArmstrongÇarpım";
            this.txtArmstrongÇarpım.ReadOnly = true;
            this.txtArmstrongÇarpım.Size = new System.Drawing.Size(100, 20);
            this.txtArmstrongÇarpım.TabIndex = 25;
            // 
            // lblArmstrongÇarpım
            // 
            this.lblArmstrongÇarpım.AutoSize = true;
            this.lblArmstrongÇarpım.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmstrongÇarpım.Location = new System.Drawing.Point(220, 18);
            this.lblArmstrongÇarpım.Name = "lblArmstrongÇarpım";
            this.lblArmstrongÇarpım.Size = new System.Drawing.Size(56, 17);
            this.lblArmstrongÇarpım.TabIndex = 24;
            this.lblArmstrongÇarpım.Text = "Çarpım:";
            // 
            // txtArmstrongToplam
            // 
            this.txtArmstrongToplam.Location = new System.Drawing.Point(81, 18);
            this.txtArmstrongToplam.Name = "txtArmstrongToplam";
            this.txtArmstrongToplam.ReadOnly = true;
            this.txtArmstrongToplam.Size = new System.Drawing.Size(100, 20);
            this.txtArmstrongToplam.TabIndex = 23;
            // 
            // lblArmstrongToplam
            // 
            this.lblArmstrongToplam.AutoSize = true;
            this.lblArmstrongToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmstrongToplam.Location = new System.Drawing.Point(6, 18);
            this.lblArmstrongToplam.Name = "lblArmstrongToplam";
            this.lblArmstrongToplam.Size = new System.Drawing.Size(59, 17);
            this.lblArmstrongToplam.TabIndex = 22;
            this.lblArmstrongToplam.Text = "Toplam:";
            // 
            // lstvArmstrongSayıları
            // 
            this.lstvArmstrongSayıları.Location = new System.Drawing.Point(6, 53);
            this.lstvArmstrongSayıları.Name = "lstvArmstrongSayıları";
            this.lstvArmstrongSayıları.Size = new System.Drawing.Size(766, 197);
            this.lstvArmstrongSayıları.TabIndex = 17;
            this.lstvArmstrongSayıları.UseCompatibleStateImageBehavior = false;
            // 
            // myıcon
            // 
            this.myıcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.myıcon.BalloonTipText = "Program Başarıyla Çalıştı. Hoşgeldiniz";
            this.myıcon.BalloonTipTitle = "OOPHW1";
            this.myıcon.Text = "notifyIcon1";
            this.myıcon.Visible = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(670, 22);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(77, 32);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.tabSonuç);
            this.Controls.Add(this.grpGirişBilgileri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGirişBilgileri.ResumeLayout(false);
            this.grpGirişBilgileri.PerformLayout();
            this.tabSonuç.ResumeLayout(false);
            this.tbpTekSayılar.ResumeLayout(false);
            this.tbpTekSayılar.PerformLayout();
            this.tbpÇiftSayılar.ResumeLayout(false);
            this.tbpÇiftSayılar.PerformLayout();
            this.tbpAsalSayılar.ResumeLayout(false);
            this.tbpAsalSayılar.PerformLayout();
            this.tbpArmstrongSayıları.ResumeLayout(false);
            this.tbpArmstrongSayıları.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGirişBilgileri;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.MaskedTextBox mtxBitişDeğeri;
        private System.Windows.Forms.Label lblBitişDeğeri;
        private System.Windows.Forms.MaskedTextBox mtxBaşlangıçDeğeri;
        private System.Windows.Forms.Label lblBaşlangıçDeğeri;
        private System.Windows.Forms.TabControl tabSonuç;
        private System.Windows.Forms.TabPage tbpTekSayılar;
        private System.Windows.Forms.TabPage tbpÇiftSayılar;
        private System.Windows.Forms.TabPage tbpAsalSayılar;
        private System.Windows.Forms.TabPage tbpArmstrongSayıları;
        private System.Windows.Forms.ListView lstvTekSonuç;
        private System.Windows.Forms.ListView lstvÇiftSonuç;
        private System.Windows.Forms.ListView lstvAsalSayılar;
        private System.Windows.Forms.ListView lstvArmstrongSayıları;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.NotifyIcon myıcon;
        private System.Windows.Forms.TextBox txtTekÇarpım;
        private System.Windows.Forms.Label lblTekÇarpım;
        private System.Windows.Forms.TextBox txtTekToplam;
        private System.Windows.Forms.Label lblTekToplam;
        private System.Windows.Forms.TextBox txtÇiftÇarpım;
        private System.Windows.Forms.Label lblÇiftÇarpım;
        private System.Windows.Forms.TextBox txtÇiftToplam;
        private System.Windows.Forms.Label lblÇiftToplam;
        private System.Windows.Forms.TextBox txtAsalÇarpım;
        private System.Windows.Forms.Label lblAsalÇarpım;
        private System.Windows.Forms.TextBox txtAsalToplam;
        private System.Windows.Forms.Label lblAsalToplam;
        private System.Windows.Forms.TextBox txtArmstrongÇarpım;
        private System.Windows.Forms.Label lblArmstrongÇarpım;
        private System.Windows.Forms.TextBox txtArmstrongToplam;
        private System.Windows.Forms.Label lblArmstrongToplam;
        private System.Windows.Forms.Button btnTemizle;
    }
}

