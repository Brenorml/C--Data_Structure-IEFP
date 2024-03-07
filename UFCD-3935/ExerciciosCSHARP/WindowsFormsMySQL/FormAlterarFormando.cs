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
    public partial class FormAlterarFormando : Form
    {
        DBConnect conn = new DBConnect();
        public FormAlterarFormando()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "", morada = "", contacto = "", iban = "", data_nascimento = "";
            char genero = ' ';
            if (conn.PesquisaFormando(nudID.Value.ToString(), ref nome, ref morada, ref contacto, ref iban, ref genero, ref data_nascimento))
            {
                txtNome.Text = nome;
                txtMorada.Text = morada;
                mtxtContacto.Text = contacto;
                txtIBAN.Text = iban;
                if (genero == 'M')
                {
                    rbMasculino.Checked = true;
                }
                else if (genero == 'F')
                {
                    rbFeminino.Checked = true;
                }
                else if (genero == 'O')
                {
                    rbOutro.Checked = true;
                }
                mtxtDataNascimento.Text = DateTime.Parse(data_nascimento).ToString("dd-MM-yyyy");

                groupBoxPesquisa.Enabled = false;
                FoundMatch();
                //btnAtualizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Formando não encontrado!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxPesquisa.Enabled = true;
            btnAtualizar.Enabled = false;
            Limpar();
            FormAlterarFormando_Load(sender, e);
            nudID.Focus();
        }

        void Limpar()
        {
            nudID.Value = 0;
            txtNome.Text = string.Empty;
            txtMorada.Clear();
            mtxtContacto.Clear();
            txtIBAN.Text = "";
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
            rbOutro.Checked = false;
            mtxtDataNascimento.Clear();
        }

        private void FormAlterarFormando_Load(object sender, EventArgs e)
        {
            txtNome.ReadOnly = true;
            txtMorada.ReadOnly = true;
            mtxtContacto.ReadOnly = true;
            txtIBAN.ReadOnly = true;
            rbMasculino.Enabled = false;
            rbFeminino.Enabled = false;
            rbOutro.Enabled = false;
            mtxtDataNascimento.ReadOnly = true;           

            btnAtualizar.Enabled = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if (conn.AlterarFormulario(nudID.Value.ToString(), txtNome.Text, txtMorada.Text, mtxtContacto.Text, txtIBAN.Text, Genero(), DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd")))
                {
                    MessageBox.Show("Dado editado com sucesso!");
                    btnCancelar_Click(sender, e);
                    FormAlterarFormando_Load(sender, e);
                    nudID.Focus();
                }
                else
                {
                    MessageBox.Show("Erro na edição!");
                }
            }
        }

        bool VerificarCampos()
        {
            if (nudID.Value < 1)
            {
                MessageBox.Show("Erro no campo ID!");
                nudID.Focus();
                return false;
            }

            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
            if (txtNome.Text.Length < 2)
            {
                MessageBox.Show("Erro no campo Nome!");
                txtNome.Focus();
                return false;
            }

            txtMorada.Text = Geral.TirarEspacos(txtMorada.Text);
            if (txtMorada.Text.Length < 4)
            {
                MessageBox.Show("Erro no campo Morada!");
                txtMorada.Focus();
                return false;
            }

            if (mtxtContacto.Text.Length < 9)
            {
                MessageBox.Show("Erro no campo Contacto!");
                mtxtContacto.Focus();
                return false;
            }

            txtIBAN.Text = Geral.TirarEspacos(txtIBAN.Text);
            if (txtIBAN.Text.Length < 25)
            {
                MessageBox.Show("Erro no campo IBAN!");
                txtIBAN.Focus();
                return false;
            }

            if (Genero() == 'T')
            {
                MessageBox.Show("Erro no campo Sexo!");
                rbOutro.Focus();
                return false;
            }

            if (mtxtDataNascimento.Text.Length != 10 || Geral.CheckDate(mtxtDataNascimento.Text) == false)
            {
                MessageBox.Show("Erro no campo Data de Nascimento!");
                mtxtDataNascimento.Focus();
                return false;
            }

            return true;
        }

        private char Genero()
        {
            char genero = 'T';
            if (rbFeminino.Checked)
            {
                genero = 'F';
            }
            else if (rbMasculino.Checked)
            {
                genero = 'M';
            }
            else if (rbOutro.Checked)
            {
                genero = 'O';
            }
            return genero;
        }

        private void FoundMatch()
        {
            txtNome.ReadOnly = false;
            txtMorada.ReadOnly = false;
            mtxtContacto.ReadOnly = false;
            txtIBAN.ReadOnly = false;
            rbMasculino.Enabled = true;
            rbFeminino.Enabled = true;
            rbOutro.Enabled = true;
            mtxtDataNascimento.ReadOnly = false;

            btnAtualizar.Enabled = true;
        }
    }
}
