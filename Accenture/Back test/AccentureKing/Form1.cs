using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccentureKing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KingSort kingsOrder;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string[] stringSeparators = new string[] { "\r\n" };
            string[] parts = textBox1.Text.Split(stringSeparators, StringSplitOptions.None);
            int QunatidadeReis = parts.Count();
            string[] listaReis = new string[QunatidadeReis];
            for (int i = 0; i < QunatidadeReis; i++)
            {
                listaReis[i] = parts[i];
            }
            kingsOrder = new KingSort(listaReis);

            kingsOrder.kings = kingsOrder.GetSortedList(kingsOrder.kings);
            for (int i = 0; i < kingsOrder.kings.Count(); i++)
            {
                textBox2.Text += kingsOrder.kings[i] + "\r\n";
            }
        }
    }
}
