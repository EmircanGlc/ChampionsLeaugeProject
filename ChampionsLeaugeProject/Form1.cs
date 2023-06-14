using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsLeaugeProject
{
    public partial class Form1 : Form
    {
        //Öncelikle girilen verileri hafızada tutalım. Daha sonra da dağıtalım.
        List<Takim> takimlar;

        List<ListBox> torbalar = new List<ListBox>();

        List<ListBox> gruplar = new List<ListBox>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LstTorba2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takim yenitakim = null; //Gelecek takımı henüz bilmiyoruz.Gelince değiştirecez.

            takimlar = new List<Takim>(); //Takım listesini oluşturduk.
            //Artık takımları ve ülkelerini girelim.

            yenitakim = new Takim("Bayern Münih", "Almanya");
            takimlar.Add(yenitakim);  //Takımı ve ülkesini ekleyelim.
            yenitakim = new Takim("Sevilla", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Real Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Liverpool", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Juventus", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Paris Saint-Germain", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Zenit", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Porto", "Portekiz");
            takimlar.Add(yenitakim); //1.Torba Takımları bitti.

            yenitakim = new Takim("Barcelona", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atletico Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester City", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester United", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Borussia Dortmund", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Shaktar Donetsk", "Ukrayna");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Chelsea", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Ajax", "Hollanda");
            takimlar.Add(yenitakim); //2.Torba Takımları bitti.

            yenitakim = new Takim("Dynamo Kiev", "Ukrayna");
            takimlar.Add(yenitakim);  //Takımı ve ülkesini ekleyelim.
            yenitakim = new Takim("Red Bull Salzburg", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("RB Leipzig", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Internazionale", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Olympiacos", "Yunanistan");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Lazio", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Krasnodar", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atalanta", "İtalya");
            takimlar.Add(yenitakim); //3.Torba Takımları bitti.

            yenitakim = new Takim("Lokomotif Moskova", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Marseille", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Club Brugge", "Belçika");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Bor.Mönchengladbach", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Galatasaray", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Midtjylland", "Danimarka");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Rennes", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Ferencvaos", "Macaristan");
            takimlar.Add(yenitakim); //4.Torba Takımları bitti.


        }

        private void button2_Click(object sender, EventArgs e) //Takımları rastgele torbalara dağıtalım.
        {
            Random rastgele = new Random();
            List<int> takimsec = new List<int>();
            for (int j = 0; j < 4; j++) //Bu sayede bir grupta 4 takım olucak ve sonrasında döngü bitecektir. j=grup
            {
                takimsec.Clear(); //Seçilen takımları silelim ki aynı takımlar tekrar gelmesin.
                for (int i = 0; i < 8; i++)
                {
                    int secilentakim = rastgele.Next(0, takimlar.Count / 4); //1 grupta toplam takım sayısının 4 e bölümü kadar 
                                                                             //takım olabilir.



                    if (takimsec.Contains(secilentakim)) //Seçilen takim seçilen takımların içinde mi?
                    {
                        i--;
                    }
                    else
                    {
                        takimsec.Add(secilentakim);
                    }
                }

                bool aynıulkedentakimvar = false;
                for (int k = 0; k < 8; k++)
                {
                    aynıulkedentakimvar = Aynıulkedentakimvarmi(gruplar[k], torbalar[j].Items[takimsec[k]] as Takim); //Önemli
                    if (aynıulkedentakimvar)  //Aynııulkeden varmi=true ise döngüyü kır.
                        break;
                }
                if (!aynıulkedentakimvar)
                {
                    listBox1.Items.Add(torbalar[j].Items[takimsec[0]] as Takim);  //Şart sağlanıyorsa listboxa ekle.
                    listBox2.Items.Add(torbalar[j].Items[takimsec[1]] as Takim);
                    listBox3.Items.Add(torbalar[j].Items[takimsec[2]] as Takim);
                    listBox4.Items.Add(torbalar[j].Items[takimsec[3]] as Takim);
                    listBox5.Items.Add(torbalar[j].Items[takimsec[4]] as Takim);
                    listBox6.Items.Add(torbalar[j].Items[takimsec[5]] as Takim);
                    listBox7.Items.Add(torbalar[j].Items[takimsec[6]] as Takim);
                    listBox8.Items.Add(torbalar[j].Items[takimsec[7]] as Takim);
                }
                else
                {
                    j--;
                }
            }
        }
        private bool Aynıulkedentakimvarmi(ListBox grup, Takim takim)
        {
            bool durum = false;
            for (int i = 0; i < grup.Items.Count; i++)
            {
                Takim gruptakim = grup.Items[i] as Takim;
                if (gruptakim.TeamCountry == takim.TeamCountry)
                {
                    durum = true;
                    break;
                }

            }
            return durum;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> takimsec = new List<int>();
            for (int i = 0; i < takimlar.Count; i++)
            {
                int secilentakim = rastgele.Next(0, takimlar.Count);
                if (takimsec.Contains(secilentakim))
                {
                    i--;   //Eğer var ise tekrar döngüye girecektir.
                }
                else
                {
                    takimsec.Add(secilentakim);
                }
            }
            for (int i = 0; i < takimsec.Count; i++)
            {
                if (i < 8)
                {
                    LstTorba1.Items.Add(takimlar[takimsec[i]]);
                }
                else if (i < 16)
                {
                    LstTorba2.Items.Add(takimlar[takimsec[i]]);
                }
                else if (i < 24)
                {
                    LstTorba3.Items.Add(takimlar[takimsec[i]]);
                }
                else
                {
                    LstTorba4.Items.Add(takimlar[takimsec[i]]);
                }
            }
            torbalar.Add(LstTorba1);
            torbalar.Add(LstTorba2);
            torbalar.Add(LstTorba3);
            torbalar.Add(LstTorba4);

            gruplar.Add(listBox1);
            gruplar.Add(listBox2);
            gruplar.Add(listBox3);
            gruplar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);
        }



        private void LstTorba1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LstTorba4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            
            foreach (Control control in Controls)
            {
                if (control is ListBox listBox)
                {
                    foreach (var item in listBox.Items)
                    {
                        form2.ListBoxItems.Add(item.ToString()); // Çözemedim:(((( O yüzden devam edemiyorum. Buradan devam edilecek.
                    }

                }

            }
            form2.Show();


        }
    }
}

