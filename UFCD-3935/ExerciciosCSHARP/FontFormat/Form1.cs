using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //types
            comboBox1.Items.Add("Arial");
            comboBox1.Items.Add("Times New Roman");
            comboBox1.Items.Add("Verdana");
            comboBox1.Text = "Arial"; //default type
            //sizes
            comboBox2.Items.Add("10");
            comboBox2.Items.Add("12");
            comboBox2.Items.Add("14");
            comboBox2.Text = "10"; //default size
            //styles
            comboBox3.Items.Add("Normal");
            comboBox3.Items.Add("Negrito");
            comboBox3.Items.Add("Itálico");
            comboBox3.Items.Add("Sublinhado");
            comboBox3.Text = "Normal"; //default style
        }

        void Formatar()
        {
            //type verification
            string tipo;
            tipo = comboBox1.Text;
            //size verfication
            int tamanho;
            tamanho = int.Parse(comboBox2.Text);
            //style verification
            FontStyle estilo = new FontStyle();
            switch(comboBox3.Text)
            {
                case "Normal":
                    estilo = FontStyle.Regular;
                    break;
                case "Negrito":
                    estilo = FontStyle.Bold; 
                    break;
                case "Itálico":
                    estilo = FontStyle.Italic;
                    break;
                case "Sublinhado":
                    estilo = FontStyle.Underline;
                    break;
            }
            //Apply choices
            richTextBox1.SelectionFont = new Font(tipo, tamanho, estilo);
        }

        //ComboBox Type
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                Formatar();
            }
        }
        //ComboBox Size
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                Formatar();
            }
        }
        //ComboBox style
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                Formatar();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Formatar();
        }
    }
}
