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

namespace NumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();

            int v1 = numAleatorio.Next(1, 61);
            int v2 = numAleatorio.Next(1, 61);
            int v3 = numAleatorio.Next(1, 61);
            int v4 = numAleatorio.Next(1, 61);
            int v5 = numAleatorio.Next(1, 61);
            int v6 = numAleatorio.Next(1, 61);

            List<int> list = new List<int>();

            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            list.Add(v4);
            list.Add(v5);
            list.Add(v6);

            list.Sort();

            foreach (int L in list)
            {
                listBox1.Items.Add(L);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string texto = "Deseja sair da aplicação? ";
            string titulo = "***FINALIZANDO APLICAÇÃO";
            if (MessageBox.Show(texto, titulo,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        } 
    }
}
