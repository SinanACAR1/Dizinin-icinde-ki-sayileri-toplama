using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayılar = { 5, 6, 7 };
            int toplam = 0;

            for (int i = 0; i < sayılar.Length; i++)//sayılar.lenght yerine kaç tane index varsa onuda yazabiliriz bknz:for(int i=0;i<3;i++);
            {
                toplam = toplam + sayılar[i];//i'nin değeri 0 iken sayılar[0] anlamına gelir ve 0. index ile toplam toplanır.
                label1.Text = toplam.ToString();
            }

        }
    }
}
