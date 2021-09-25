using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Klasa_ArrayList_EM
{
    public partial class form1 : Form
    {



        ArrayList ListaAutomobila = new ArrayList();

        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            textBoxNovi.Enabled = true;
            buttonUnesi.Enabled = true;
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            Automobil Auto = new Automobil(textBoxNovi.Text);
            ListaAutomobila.Add(Auto);
            richTextBox1.AppendText(ListaAutomobila.IndexOf(Auto) + 1 + ". " + Auto.DajMarku() + "\n");
            textBoxNovi.Text = "";
            textBoxNovi.Enabled = false;
            textBoxNovi.Enabled = false;

        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            ListaAutomobila.Clear();
            richTextBox1.Text = "";
            textBoxNovi.Text = "";
        }
    }
}
