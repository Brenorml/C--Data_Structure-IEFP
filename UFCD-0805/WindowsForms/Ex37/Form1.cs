using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex37
{
    public partial class Form1 : Form
    {
        //estrutura de dados
        struct Dados
        {
            public DateTime data;
            public string modelo;
            public string avaria;
        }
        //instância de avarias
        Queue<Dados> avarias = new Queue<Dados>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AtualizarGrelha()
        {
            dgvGrelha.Rows.Clear();

            foreach(Dados registos in avarias)
            {
                dgvGrelha.Rows.Add(registos.data.ToString("dd/MM/yyyy"), registos.modelo, registos.avaria);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Dados registo;

            if(txtModelo.Text != "" && txtAvaria.Text != "")
            {
                registo.data = DateTime.Parse(dtpData.Text);
                registo.modelo = txtModelo.Text;
                registo.avaria = txtAvaria.Text;

                avarias.Enqueue(registo);

                AtualizarGrelha();

                dtpData.Value = DateTime.Today;
                txtAvaria.ResetText();
            }
            else
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReparado_Click(object sender, EventArgs e)
        {
            if(avarias.Count > 0)
            {
                avarias.Dequeue();

                AtualizarGrelha();
            }
            else
            {
                MessageBox.Show("Não existem elementos inseridos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
