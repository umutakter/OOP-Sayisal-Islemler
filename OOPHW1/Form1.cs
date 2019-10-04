using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;

namespace OOPHW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myıcon.BalloonTipText = "Nesne Yönelimli Programlama Ödev1";
            myıcon.Icon = SystemIcons.Application;
            myıcon.BalloonTipTitle = "Programa Hoşgeldiniz!";
            myıcon.Text = "Program Başarıyla Başlatıldı";
            myıcon.ShowBalloonTip(3000);

            String seciliTabAyari;

            seciliTabAyari = "ARMSTRONG";

            if (seciliTabAyari.Equals("ARMSTRONG"))
            {
                tabSonuç.SelectedIndex = 3;
            }
            else if (seciliTabAyari.Equals("ASAL"))
            {
                tabSonuç.SelectedIndex = 2;
            }
            else if (seciliTabAyari.Equals("ÇİFT"))
            {
                tabSonuç.SelectedIndex = 1;
            }
            else if (seciliTabAyari.Equals("TEK"))
            {
                tabSonuç.SelectedIndex = 0;
            }
        }
        private Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(mtxBaşlangıçDeğeri.Text);
                Convert.ToInt32(mtxBitişDeğeri.Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void SonuçYazTek(string toplam,string çarpım)
        {
            txtTekToplam.Text = Convert.ToString(toplam);
            txtTekÇarpım.Text = Convert.ToString(çarpım);
        }
        private void SonuçYazÇift(string toplam, string çarpım)
        {
            txtÇiftToplam.Text = Convert.ToString(toplam);
            txtÇiftÇarpım.Text = Convert.ToString(çarpım);

        }

        void Temizle()
        {
            lstvArmstrongSayıları.Items.Clear();
            lstvAsalSayılar.Items.Clear();
            lstvTekSonuç.Items.Clear();
            lstvÇiftSonuç.Items.Clear();
            mtxBitişDeğeri.Clear();
            mtxBaşlangıçDeğeri.Clear();
            txtArmstrongToplam.Clear();
            txtArmstrongÇarpım.Clear();
            txtAsalToplam.Clear();
            txtAsalÇarpım.Clear();
            txtTekToplam.Clear();
            txtTekÇarpım.Clear();
            txtÇiftToplam.Clear();
            txtÇiftÇarpım.Clear();
        }

        void TekSayılarYazdırma(int başlangıç, int bitiş)
        {
            for (int i = başlangıç; i <= bitiş; i++)
            {
                if (i % 2 == 1)
                {
                    lstvTekSonuç.Items.Add(Convert.ToString(i));
                }
            }
        }
        void ÇiftSayılarYazdırma(int başlangıç, int bitiş)
        {
            for (int i = başlangıç; i <= bitiş; i++)
            {
                if (i % 2 == 0)
                {
                    lstvÇiftSonuç.Items.Add(Convert.ToString(i));
                }
            }
        }
        private BigInteger TekToplam(int başlangıç, int bitiş)
        {
            BigInteger sonuç = 0;
            for (int i = başlangıç; i <= bitiş; i++)
            {
                if (i % 2 == 1)
                {
                    sonuç = sonuç + i;
                }
            }
            return sonuç;
        }
        private BigInteger TekÇarpım(int başlangıç, int bitiş)
        {
            BigInteger sonuç = 1;
            for (int i = başlangıç; i <= bitiş; i++)
            {
                if (i % 2 == 1)
                {
                    sonuç = sonuç * i;
                }
            }
            return sonuç;
        }
        private BigInteger ÇiftToplam(int başlangıç, int bitiş)
        {
            BigInteger sonuç = 0;
            for (int i = başlangıç; i <= bitiş; i++)
            {
                if (i % 2 == 0)
                {
                    sonuç = sonuç + i;
                }
            }
            return sonuç;
        }
        private BigInteger ÇiftÇarpım(int başlangıç, int bitiş)
        {
            BigInteger sonuç = 1;
            for (int i = başlangıç; i <= bitiş; i++)
            {
                if (i % 2 == 0)
                {
                    sonuç = sonuç * i;
                }
            }
            return sonuç;
        }
        void AsalSayılar(int başlangıç, int bitiş)
        {
            BigInteger asalToplam = 0, asalÇarpım = 1;
            for (int i = başlangıç; i < bitiş; i++)
            {
                int sayaç = 0;
                for (int j = i - 1; j > 1; j--)
                {
                    if (i % j == 0)
                    {
                        sayaç++;
                    }
                }
                if (sayaç == 0)
                {
                    lstvAsalSayılar.Items.Add(Convert.ToString(i));
                    asalToplam = asalToplam + i;
                    asalÇarpım = asalÇarpım * i;
                }
            }
            using (StreamWriter Yaz = new StreamWriter("deneme.txt", true))
            {
                Yaz.WriteLine("İşem Türü: Asal Sayrılar İşlem Zamanı:{0}\n, Başlangıç Değeri:{1}\n" +
                            ", Bitiş Değeri{2}\n, Asal Sayıları Toplamı: {3}\n, Asal Sayıların Çarpımı:{4}\n"
                            , DateTime.Now, mtxBaşlangıçDeğeri.Text, mtxBitişDeğeri.Text, txtAsalToplam.Text, txtAsalÇarpım.Text);
            }
            txtAsalToplam.Text = Convert.ToString(asalToplam);
            txtAsalÇarpım.Text = Convert.ToString(asalÇarpım);
        }
        void ArmstrongSayıları(int başlangıç, int bitiş)
        {
            int birlerB, onlarB, yüzlerB, binlerB;
            BigInteger armstrongToplam = 0, armstrongÇarpım = 1;
            for (int i = başlangıç; i <= bitiş; i++)
            {
                if (i < 10000)
                {
                    birlerB = i % 10;
                    onlarB = ((i - birlerB) / 10) % 10;
                    yüzlerB = ((i - (onlarB * 10) - birlerB) / 100) % 10;
                    binlerB = (i - (100 * yüzlerB) - (10 * onlarB) - birlerB) / 1000;
                    if (i == Math.Pow(birlerB, 4) + Math.Pow(onlarB, 4) + Math.Pow(yüzlerB, 4) + Math.Pow(birlerB, 4))
                    {
                        lstvArmstrongSayıları.Items.Add(Convert.ToString(i));
                        armstrongToplam = armstrongToplam + i;
                        armstrongÇarpım = armstrongÇarpım * i;
                    }
                }
                if (i < 1000)
                {
                    birlerB = i % 10;
                    onlarB = ((i - birlerB) / 10) % 10;
                    yüzlerB = (i - (10 * onlarB) - birlerB) / 100;
                    if (i == Math.Pow(birlerB, 3) + Math.Pow(onlarB, 3) + Math.Pow(yüzlerB, 3))
                    {
                        lstvArmstrongSayıları.Items.Add(Convert.ToString(i));
                        armstrongToplam = armstrongToplam + i;
                        armstrongÇarpım = armstrongÇarpım * i;
                    }
                }
                if (i < 100)
                {
                    birlerB = i % 10;
                    onlarB = (i - birlerB) / 10;
                    if (i == Math.Pow(birlerB, 2) + Math.Pow(onlarB, 2))
                    {
                        lstvArmstrongSayıları.Items.Add(Convert.ToString(i));
                        armstrongToplam = armstrongToplam + i;
                        armstrongÇarpım = armstrongÇarpım * i;
                    }
                }
                if (i < 10)
                {
                    birlerB = i;
                    if (i == birlerB)
                    {
                        lstvArmstrongSayıları.Items.Add(Convert.ToString(i));
                        armstrongToplam = armstrongToplam + i;
                        armstrongÇarpım = armstrongÇarpım * i;
                    }
                }
            }
            txtArmstrongToplam.Text = Convert.ToString(armstrongToplam);
            txtArmstrongÇarpım.Text = Convert.ToString(armstrongÇarpım);
            using (StreamWriter Yaz = new StreamWriter("deneme.txt", true))
            {
                Yaz.WriteLine("İşem Türü: Armstrong Sayrılarında İşlem Zamanı:{0}\n, Başlangıç Değeri:{1}\n" +
                            ", Bitiş Değeri{2}\n, Armstrong Sayılarının Toplamı: {3}\n, Armstrong Sayılarının Çarpımı:{4}\n"
                            , DateTime.Now, mtxBaşlangıçDeğeri.Text, mtxBitişDeğeri.Text, txtArmstrongToplam.Text, txtArmstrongÇarpım.Text);
            }
        }
        private void btnİleri_Click(object sender, EventArgs e)
        {
            if (tabSonuç.SelectedIndex >= 3)
            {
                tabSonuç.SelectedIndex = 0;
            }
            else
                tabSonuç.SelectedIndex++;
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (tabSonuç.SelectedIndex <= 0)
            {
                tabSonuç.SelectedIndex = 3;
            }
            else
                tabSonuç.SelectedIndex--;
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int başlangıç, bitiş;

            başlangıç = Convert.ToInt32(mtxBaşlangıçDeğeri.Text);
            bitiş = Convert.ToInt32(mtxBitişDeğeri.Text);

            if (bitiş <= 10000 && başlangıç <= 10000 && Dogrula())
            {
                if (tabSonuç.SelectedIndex == 0)
                {
                    SonuçYazTek(Convert.ToString(TekToplam(başlangıç, bitiş))
                     , Convert.ToString(TekÇarpım(başlangıç, bitiş)));

                    TekSayılarYazdırma(başlangıç, bitiş);


                    using (StreamWriter Yaz = new StreamWriter("deneme.txt",true))
                    {
                        Yaz.WriteLine("İşlem Türü:Tek Sayılarda İşlemler: , " +
                            "İşlem Zamanı:{0} , Başlangıç Değeri:{1} , Bitiş Değeri:{2}, " +
                            "Tek Sayıların Toplamı:{3} , Tek Sayıların Çarpımı:{4}",
                            DateTime.Now, mtxBaşlangıçDeğeri.Text, mtxBitişDeğeri.Text, 
                            txtTekToplam.Text, txtTekÇarpım.Text);
                    }
                }
                if (tabSonuç.SelectedIndex == 1)
                {
                    SonuçYazÇift(Convert.ToString(ÇiftToplam(başlangıç, bitiş))
                                             , Convert.ToString(ÇiftÇarpım(başlangıç, bitiş)));

                    ÇiftSayılarYazdırma(başlangıç, bitiş);

                    using (StreamWriter Yaz = new StreamWriter("deneme.txt",true))
                    {
                        Yaz.WriteLine("İşlem Türü:Çift Sayılarda İşlemler: , " +
                            "İşlem Zamanı:{0} , Başlangıç Değeri:{1} , Bitiş Değeri:{2}, " +
                            "Çift Sayıların Toplamı:{3} , Çift Sayıların Çarpımı:{4}",
                            DateTime.Now, mtxBaşlangıçDeğeri.Text, mtxBitişDeğeri.Text,
                            txtÇiftToplam.Text, txtÇiftÇarpım.Text);
                    }
                }
                if (tabSonuç.SelectedIndex == 2)
                {
                    AsalSayılar(başlangıç, bitiş);

                }
                if (tabSonuç.SelectedIndex == 3)
                {
                    ArmstrongSayıları(başlangıç, bitiş);
                }  
            }
            else
            {
                MessageBox.Show("Hatalı Değer Girdiniz...");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtTekToplam_ReadOnlyChanged(object sender, EventArgs e)
        {

        }
    }
}
