using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMySQL
{
    public partial class Form1 : Form
    {
        DBConnect ligacao = new DBConnect();
        FormInserirFormando formInserirFormando = new FormInserirFormando();
        FormApagarFormando formApagarFormando = new FormApagarFormando();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DBConnect ligacao = new DBConnect(); - TORNAMOS A INSTANCIA GLOBAL PARA NÃO PRECISAR INVOCAR EM CADA EVENTO
            ligacao.Count();
            MessageBox.Show("Nº total de formandos: " + ligacao.Count());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ligacao.InserirManual())
            {
                MessageBox.Show("Inseriu com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro de inserção!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(formInserirFormando.IsDisposed)
            {
                formInserirFormando = new FormInserirFormando();
            }
            formInserirFormando.Show();
            formInserirFormando.Activate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (formApagarFormando.IsDisposed)
            {
                formApagarFormando = new FormApagarFormando();
            }
            formApagarFormando.Show();
            formApagarFormando.Activate();
        }
    }
}
