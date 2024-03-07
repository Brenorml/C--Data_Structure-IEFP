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
    public partial class FormInserirFormando : Form
    {
        DBConnect conn = new DBConnect();
        public FormInserirFormando()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormInserirFormando_Load(object sender, EventArgs e)
        {
            nudID.Value = conn.devolveUtimoID();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if(conn.InserirFormulario(nudID.Value.ToString(), txtNome.Text, txtMorada.Text, mtxtContacto.Text, txtIBAN.Text, Genero(), DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd"))) 
                {
                    MessageBox.Show("Inseriu com sucesso!");
                    Limpar();
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Erro na inserção!");
                }
            }
        }

        bool VerificarCampos()
        {
            if(nudID.Value < 1)
            {
                MessageBox.Show("Erro no campo ID!");
                nudID.Focus();
                return false;
            }
            
            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
            if(txtNome.Text.Length < 2)
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

            if(Genero() == 'T')
            {
                MessageBox.Show("Erro no campo Sexo!");
                rbOutro.Focus();
                return false;
            }

            if(mtxtDataNascimento.Text.Length != 10 || Geral.CheckDate(mtxtDataNascimento.Text) == false)
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
            else if(rbMasculino.Checked)
            {
                genero = 'M';
            }
            else if(rbOutro.Checked)
            {
                genero = 'O';
            }
            return genero;
        }

        void Limpar()
        {
            nudID.Value = conn.devolveUtimoID();
            txtNome.Text = string.Empty;
            txtMorada.Clear();
            mtxtContacto.Clear();
            txtIBAN.Text = "";
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
            rbOutro.Checked = false;
            mtxtDataNascimento.Clear();
        }
    }
}
