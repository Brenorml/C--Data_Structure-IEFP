using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilhas
{
    public partial class Form1 : Form
    {
        Stack<string> pessoas = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblNome.Text = "Boa tarde a todos!";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "")
            {
                pessoas.Push(txtNome.Text);
                txtNome.Text = "";
            }
            else
            {
                MessageBox.Show("Preencha o nome!", this.Text, MessageBoxButtons )
            }
        }
    }
}
