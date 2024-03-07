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
    public partial class FormInserirNacionalidade : Form
    {
        DBConnect conn = new DBConnect();
        public FormInserirNacionalidade()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposNac())
            {
                if (conn.InserirNacionalidade(tbCodigoIso.Text.ToUpper(), tbNacionalidade.Text))
                {
                    MessageBox.Show("Inseriu com sucesso!");
                    Limpar();
                    tbCodigoIso.Focus();
                }
                else
                {
                    MessageBox.Show("Erro na inserção!");
                }
            }
        }

        bool VerificarCamposNac()
        {
            tbCodigoIso.Text = Geral.TirarEspacos(tbCodigoIso.Text);
            if (tbCodigoIso.Text.Length > 2 || tbCodigoIso.Text.Length == 0)
            {
                MessageBox.Show("Erro no campo no campo ALF2(ISO2)!");
                tbCodigoIso.Focus();
                return false;
            }            

            tbNacionalidade.Text = Geral.TirarEspacos(tbNacionalidade.Text);
            if (tbNacionalidade.Text.Length < 2 || tbNacionalidade.Text.Length == 0)
            {
                MessageBox.Show("Erro no campo Nacionalidade!");
                tbNacionalidade.Focus();
                return false;
            }
            return true;
        }

        void Limpar()
        {            
            tbCodigoIso.Text = string.Empty;
            tbNacionalidade.Text= string.Empty;            
        }
    }
}
