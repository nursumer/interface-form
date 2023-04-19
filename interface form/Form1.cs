using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public interface IAracOzellikleri
        {
            string Marka { get; }
            string Model { get; }
            int Hız { get; set; }
            int Gosterge(int deger);
            void Bilgiler();
        }
        public interface IAracPuan
        {
            double AracPuani(double puan);
        }
        public class Mercedes : IAracOzellikleri
        {
            public string marka = "";
            public string model = "";
            
         
            public string Marka { get { return marka; } }
            public string Model { get { return model; } }
            private int hiz;
            public int Hiz
            {
                get { return hiz; }
                set { hiz = value; }
            }
            private int fiyat;
            public int Fiyat
            {
                get { return fiyat; }
                set { fiyat = value; }
            }

            public int Hız
            {
                get { return hiz; }
                set { hiz = value; }

            }

            string IAracOzellikleri.Marka => throw new NotImplementedException();

            string IAracOzellikleri.Model => throw new NotImplementedException();

            int IAracOzellikleri.Hız { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Bilgiler(Form1 formnesnesi)
            {
                formnesnesi.listBox1.Items.Add("Marka:" + Marka);
                formnesnesi.listBox1.Items.Add("Model:" + Model);
                formnesnesi.listBox1.Items.Add("Fiyat:" + Fiyat);
                formnesnesi.listBox1.Items.Add("Hız:" + Hız);
                formnesnesi.listBox1.Items.Add("Gösterge:" + Gosterge(300));
              
            }
            public int Gosterge(int deger)
            {
                return deger;
            }

            int IAracOzellikleri.Gosterge(int deger)
            {
                throw new NotImplementedException();
            }

            void IAracOzellikleri.Bilgiler()
            {
                throw new NotImplementedException();
            }
        }
        public class BMW : IAracOzellikleri, IAracPuan
        {
            public string marka = "";
            public string model = "";
           
            private int hiz;
            private int fiyat;
            public string Marka { get { return marka; } }
            public string Model { get { return model; } }
            public int Hız
            {
                get { return hiz; }
                set { hiz = value; }
            }
            public int Fiyat
            {
                get { return fiyat; }
                set { fiyat = value; }
            }
            public void Bilgiler(Form1 formnesnesi)
            {
                formnesnesi.listBox1.Items.Add("Marka:" + Marka);
                formnesnesi.listBox1.Items.Add("Model:" + Model);
                formnesnesi.listBox1.Items.Add("Fiyat:" + Fiyat);
                formnesnesi.listBox1.Items.Add("Hız:" + Hız);
                formnesnesi.listBox1.Items.Add("Gösterge:" + Gosterge(300));
                formnesnesi.listBox1.Items.Add("Araç Puanı:" + AracPuani(2000));

            }
            public double AracPuani(double puan)
            {
                return puan * 3.6;
            }
            public int Gosterge(int deger)
            {
                return deger;
            }

            public void Bilgiler()
            {
                throw new NotImplementedException();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mercedes")
            {
                Mercedes mm = new Mercedes();
                mm.marka = comboBox1.Text;
                mm.model = comboBox2.Text;
                mm.Fiyat = Convert.ToInt32(textBox1.Text);
                mm.Hiz = Convert.ToInt32(textBox2.Text);
                mm.Bilgiler(this);
            }

            else
            {
                BMW bbmw = new BMW();
                bbmw.marka = comboBox1.Text;
                bbmw.model = comboBox2.Text;
                bbmw.Fiyat = Convert.ToInt32(textBox1.Text);
                bbmw.Hız = Convert.ToInt32(textBox2.Text);
                bbmw.Bilgiler(this);
            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

           
        

