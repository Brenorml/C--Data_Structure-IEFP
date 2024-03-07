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
    public partial class FormApagarFormando : Form
    {
        DBConnect conn = new DBConnect();
        public FormApagarFormando()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "", morada = "", contacto = "", iban = "", data_nascimento = "";
            char genero = ' ';
            if(conn.PesquisaFormando(nudID.Value.ToString(), ref nome, ref morada, ref contacto, ref iban, ref genero, ref data_nascimento))
            {
                txtNome.Text = nome;
                txtMorada.Text = morada;
                mtxtContacto.Text = contacto;
                txtIBAN.Text = iban;
                if(genero == 'M')
                {
                    rbMasculino.Checked = true;
                } else if(genero == 'F')
                {
                    rbFeminino.Checked = true;
                } else if (genero == 'O')
                {
                    rbOutro.Checked = true;
                }
                mtxtDataNascimento.Text = DateTime.Parse(data_nascimento).ToString("dd-MM-yyyy");
                
                groupBoxPesquisa.Enabled = false;
                btnEliminar.Enabled = true;                
            }
            else
            {
                MessageBox.Show("Formando não encontrado!");
            }

        }

        private void FormApagarFormando_Load(object sender, EventArgs e)
        {
            txtNome.ReadOnly = true;
            txtMorada.ReadOnly = true;
            mtxtContacto.ReadOnly = true;
            txtIBAN.ReadOnly = true;
            rbMasculino.Enabled = false;
            rbFeminino.Enabled = false;
            rbOutro.Enabled = false;
            mtxtDataNascimento.ReadOnly = true;

            btnEliminar.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxPesquisa.Enabled = true;
            btnEliminar.Enabled = false;
            Limpar();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja eliminar o registro com id " + nudID.Value.ToString(), "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (conn.Delete(nudID.Value.ToString())){
                    MessageBox.Show("Registro eliminado!");
                    btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Não foi possível eliminar o registro!");
                }
            }
        }
    }
}
