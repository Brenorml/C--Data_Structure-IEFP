using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMySQL
{
    public partial class FormApagarNacionalidade : Form
    {
        DBConnect conn = new DBConnect();
        int id_nacionalidade = 0;
        public FormApagarNacionalidade()
        {
            InitializeComponent();
        }

        private void FormApagarNacionalidade_Load(object sender, EventArgs e)
        {  
            tbCodigoIso.ReadOnly = true;
            tbNacionalidade.ReadOnly = true;            
            btApagar.Enabled = false;
            
            conn.PreencherNacionalidade(ref cbNacionalidade);
            
        }
        
        private void btCancelar_Click(object sender, EventArgs e)
        {
            groupBoxNac.Enabled = true;                        
            btApagar.Enabled = false;            
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

        

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja eliminar o registro da nacionalidade " + tbNacionalidade.Text, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (conn.DeleteNacionalidade(id_nacionalidade))
                {
                    MessageBox.Show("Registro eliminado!");                    
                    btCancelar_Click(sender, e);                    
                    cbNacionalidade.Items.Clear();
                    FormApagarNacionalidade_Load(sender, e);
                    id_nacionalidade = 0;
                    
                }
                else
                {
                    MessageBox.Show("Não foi possível eliminar o registro!");
                }
            }
        }

        private void cbNacionalidade_SelectedValueChanged(object sender, EventArgs e)
        {
            string alf2 = "", nacionalidade = "";
            
            SelecionarNacionalidade(ref id_nacionalidade, ref alf2, ref nacionalidade);
            tbCodigoIso.Text = alf2;
            tbNacionalidade.Text = nacionalidade;
            groupBoxNac.Enabled = false;
            btApagar.Enabled = true;
            
        }

        void SelecionarNacionalidade(ref int id_nacionalidade, ref string alf2,ref string nacionalidade)
        {
            string[] partes = cbNacionalidade.Text.Substring(0).Split('-');
            nacionalidade = partes[0].Trim();
            alf2 = partes[1].Trim();
            id_nacionalidade = Convert.ToInt32(partes[2].Trim());
        }
    }
}
