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
    public partial class FormAlterarNacionalidade : Form
    {
        DBConnect conn = new DBConnect();
        int id_nacionalidade = 0;
        public FormAlterarNacionalidade()
        {
            InitializeComponent();
        }

        private void FormAlterarNacionalidade_Load(object sender, EventArgs e)
        {
            tbCodigoIso.ReadOnly = true;
            tbNacionalidade.ReadOnly = true;
            btAtualizar.Enabled = false;
            
            conn.PreencherNacionalidade(ref cbNacionalidade);
        }

        private void cbNacionalidade_SelectedValueChanged(object sender, EventArgs e)
        {
            string alf2 = "", nacionalidade = "";

            SelecionarNacionalidade(ref id_nacionalidade, ref alf2, ref nacionalidade);
            tbCodigoIso.Text = alf2;
            tbNacionalidade.Text = nacionalidade;
            tbCodigoIso.ReadOnly = false;
            tbNacionalidade.ReadOnly = false;
            groupBoxNac.Enabled = false;
            btAtualizar.Enabled = true;
        }

        void SelecionarNacionalidade(ref int id_nacionalidade, ref string alf2, ref string nacionalidade)
        {
            string[] partes = cbNacionalidade.Text.Substring(0).Split('-');
            nacionalidade = partes[0].Trim();
            alf2 = partes[1].Trim();
            id_nacionalidade = Convert.ToInt32(partes[2].Trim());
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            groupBoxNac.Enabled = true;
            btAtualizar.Enabled = false;
            tbCodigoIso.ReadOnly = true;
            tbNacionalidade.ReadOnly = true;
            Limpar();
            cbNacionalidade.Focus();
        }

        void Limpar()
        {
            cbNacionalidade.Text = string.Empty;
            tbCodigoIso.Text = string.Empty;
            tbNacionalidade.Text = string.Empty;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (conn.AlterarNacionalidade(id_nacionalidade, tbCodigoIso.Text.ToUpper(), tbNacionalidade.Text))
            {
                MessageBox.Show("Registro atualizado com sucesso!");
                btCancelar_Click(sender, e);
                cbNacionalidade.Items.Clear();
                FormAlterarNacionalidade_Load(sender, e);
                id_nacionalidade = 0;
            }
            else
            {
                MessageBox.Show("Não foi possível atualizar o registro!");
            }
        }
    }
}
