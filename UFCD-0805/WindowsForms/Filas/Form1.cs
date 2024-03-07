using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filas
{
    public partial class Form1 : Form
    {
        Queue<string> pessoas = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNome.Text = "Nome Completo";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "") //Esta condição tb poderia ser - if(txtNome.Text != String.Empty)
            {
                pessoas.Enqueue(txtNome.Text);
                btnAtualizar_Click(sender, e);
                txtNome.Text = "";
            }
            else
            {
                MessageBox.Show("Preencha o nome!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            txtNome.Focus();
        }

        private void btnAtendido_Click(object sender, EventArgs e)
        {
            if(pessoas.Count > 0)
            {
                pessoas.Dequeue();
                btnAtualizar_Click(sender, e);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();

            foreach (string nome in pessoas)
            {
                lstLista.Items.Add(nome);
            }
        }
    }
}
