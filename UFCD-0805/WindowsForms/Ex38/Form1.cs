using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex38
{
    public partial class Form1 : Form
    {
        struct info
        {
            public string Nome, Documento, Tipo, Visitado;
            public double Numero;
            public DateTime Data, Hora;
        }

        info Visitas;

        LinkedList<info> Lista = new LinkedList<info>();
        LinkedListNode<info> NoLista;

        string Procura;
        public Form1()
        {
            InitializeComponent();
        }

        private void Ativar(bool estado)
        {
            txtNome.Enabled = estado;
            cboDocumento.Enabled = estado;
            txtNumero.Enabled = estado;
            txtVisitado.Enabled = estado;
            mtxtHora.Enabled = estado;
            tsbNovo.Enabled = !estado;
            tsbAnular.Enabled = estado;
            tsbGuardar.Enabled = estado;
            tsbEliminar.Enabled = estado;
        }

        private void Limpar()
        {
            foreach (Object controlo in this.Controls)
            {
                if (controlo is TextBox) ((TextBox)controlo).ResetText();
                if (controlo is ComboBox) ((ComboBox)controlo).ResetText();
                if (controlo is MaskedTextBox) ((MaskedTextBox)controlo).ResetText();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ativar(false);
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            Ativar(true);
            Limpar();
            tsbNovo.Checked = true;
            txtNome.Focus();
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            Ativar(false);
            Limpar();
            tsbNovo.Checked = false;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (tsbNovo.Checked)
            {
                if (txtNome.Text != "" && mtxtHora.MaskCompleted == true)
                {
                    if (ValidarHora(mtxtHora.Text))
                    {
                        Visitas.Nome = txtNome.Text;
                        Visitas.Documento = cboDocumento.Text;

                        double numero;
                        bool validar = double.TryParse(txtNumero.Text, out numero);
                        if (validar)
                        {
                            Visitas.Numero = double.Parse(txtNumero.Text);
                        }
                        else
                        {
                            Visitas.Numero = numero;
                        }

                        Visitas.Tipo = cboTipo.Text;
                        Visitas.Visitado = txtVisitado.Text;
                        Visitas.Data = DateTime.Parse(dtpData.Text);
                        Visitas.Hora = DateTime.Parse(mtxtHora.Text);

                        Lista.AddLast(Visitas);

                        dgvGrelha.Rows.Add(txtNome.Text, mtxtHora.Text);

                        tsbAnular.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Hora inválida!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("OS campos Nome e Hora são de preenchimento obrigatório", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private bool ValidarHora(string hora)
        {
            string sHour = hora.Split(':')[0];
            string sMinute = hora.Split(':')[1];

            int iHour = 0;
            bool validar = int.TryParse(sHour, out iHour);

            if (validar == false || iHour > 23)
            {
                return false;
            }

            int iMinutes;
            validar = int.TryParse(sMinute, out iMinutes);
            if (validar == false || iMinutes > 59)
            {
                return false;
            }
            return true;
        }

        private void tsbConsultar_Click(object sender, EventArgs e)
        {
            if (dgvGrelha.Rows.Count > 0)
            {
                int linha = dgvGrelha.CurrentRow.Index;
                Procura = dgvGrelha[0, linha].Value.ToString();

                FrmConsulta frmConsulta = new FrmConsulta();
                frmConsulta.lblNome.Text = Procura;

                foreach (info Visitas in Lista)
                {
                    if (Visitas.Nome == Procura)
                    {
                        // frmConsulta.dgvGrelha.Rows.Add(Visitas.Data, Visitas.Hora, Visitas.Visitado, Visitas.Tipo);
                        frmConsulta.dgvGrelha.Rows.Add(Visitas.Data.ToString("dd/MM/yyyy"), Visitas.Hora.ToString("HH:mm"), Visitas.Visitado, Visitas.Tipo);
                    }
                }

                frmConsulta.Show();
            }
            else
            {
                MessageBox.Show("Não existem dados inseridos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbAtualizar_Click(object sender, EventArgs e)
        {
            dgvGrelha.Rows.Clear();

            foreach (info Visitas in Lista)
            {
                dgvGrelha.Rows.Add(Visitas.Nome, Visitas.Hora.);
            }
        }

        private void btnProcuraTipo_Click(object sender, EventArgs e)
        {
            if (cboTipo.Text != "")
            {
                dgvGrelha.Rows.Clear();

                foreach (info Visitas in Lista)
                {
                    if (Visitas.Tipo == cboTipo.Text)
                    {
                        dgvGrelha.Rows.Add(Visitas.Nome, Visitas.Hora);
                    }
                }
            }
        }

        private void btnProcuraData_Click(object sender, EventArgs e)
        {
            dgvGrelha.Rows.Clear();

            foreach (info Visitas in Lista)
            {
                if (Visitas.Data == DateTime.Parse(dtpData.Text))
                {
                    dgvGrelha.Rows.Add(Visitas.Nome, Visitas.Hora);
                }
            }
        }
    } 
}
