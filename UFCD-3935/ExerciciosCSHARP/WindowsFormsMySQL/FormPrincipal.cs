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
    public partial class FormPrincipal : Form
    {
        FormInserirFormando formInserirFormando = new FormInserirFormando();
        FormApagarFormando formApagarFormando = new FormApagarFormando();
        FormAlterarFormando formAlterarFormando = new FormAlterarFormando();
        FormListarFormando formListarFormando = new FormListarFormando();
        FormInserirNacionalidade formInserirNacionalidade = new FormInserirNacionalidade();
        FormApagarNacionalidade formApagarNacionalidade = new FormApagarNacionalidade();
        FormAlterarNacionalidade formAlterarNacionalidade = new FormAlterarNacionalidade();
        FormListarNacionalidade formListarNacionalidade = new FormListarNacionalidade();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInserirFormando.IsDisposed)
            {
                formInserirFormando = new FormInserirFormando();
            }
            formInserirFormando.MdiParent = this;
            formInserirFormando.StartPosition = FormStartPosition.Manual;
            formInserirFormando.Location = new Point((this.ClientSize.Width - formInserirFormando.Width) /2, (this.ClientSize.Height - formInserirFormando.Height) /2);
            formInserirFormando.Show();
            formInserirFormando.Activate();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formApagarFormando.IsDisposed)
            {
                formApagarFormando = new FormApagarFormando();
            }
            formApagarFormando.MdiParent = this;
            formApagarFormando.StartPosition = FormStartPosition.Manual;
            formApagarFormando.Location = new Point((this.ClientSize.Width - formApagarFormando.Width) / 2, (this.ClientSize.Height - formApagarFormando.Height) / 2);
            formApagarFormando.Show();
            formApagarFormando.Activate();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAlterarFormando.IsDisposed)
            {
                formAlterarFormando = new FormAlterarFormando();
            }
            formAlterarFormando.MdiParent = this;
            formAlterarFormando.StartPosition = FormStartPosition.Manual;
            formAlterarFormando.Location = new Point((this.ClientSize.Width - formAlterarFormando.Width) / 2, (this.ClientSize.Height - formAlterarFormando.Height) / 2);
            formAlterarFormando.Show();
            formAlterarFormando.Activate();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formListarFormando.IsDisposed)
            {
                formListarFormando = new FormListarFormando();
            }
            formListarFormando.MdiParent = this;
            formListarFormando.StartPosition = FormStartPosition.Manual;
            formListarFormando.Location = new Point((this.ClientSize.Width - formListarFormando.Width) / 2, (this.ClientSize.Height - formListarFormando.Height) / 2);
            formListarFormando.Show();
            formListarFormando.Activate();
        }

        private void inserirNacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInserirNacionalidade.IsDisposed)
            {
                formInserirNacionalidade = new FormInserirNacionalidade();
            }
            formInserirNacionalidade.MdiParent = this;
            formInserirNacionalidade.StartPosition = FormStartPosition.Manual;
            formInserirNacionalidade.Location = new Point((this.ClientSize.Width - formInserirNacionalidade.Width) / 2, (this.ClientSize.Height - formInserirNacionalidade.Height) / 2);
            formInserirNacionalidade.Show();
            formInserirNacionalidade.Activate();
        }

        private void deletarNacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formApagarNacionalidade.IsDisposed)
            {
                formApagarNacionalidade = new FormApagarNacionalidade();
            }
            formApagarNacionalidade.MdiParent = this;
            formApagarNacionalidade.StartPosition = FormStartPosition.Manual;
            formApagarNacionalidade.Location = new Point((this.ClientSize.Width - formApagarNacionalidade.Width) / 2, (this.ClientSize.Height - formApagarNacionalidade.Height) / 2);
            formApagarNacionalidade.Show();
            formApagarNacionalidade.Activate();
        }

        private void atualizarNacToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formAlterarNacionalidade.IsDisposed)
            {
                formAlterarNacionalidade = new FormAlterarNacionalidade();
            }
            formAlterarNacionalidade.MdiParent = this;
            formAlterarNacionalidade.StartPosition = FormStartPosition.Manual;
            formAlterarNacionalidade.Location = new Point((this.ClientSize.Width - formAlterarNacionalidade.Width) / 2, (this.ClientSize.Height - formAlterarNacionalidade.Height) / 2);
            formAlterarNacionalidade.Show();
            formAlterarNacionalidade.Activate();
        }

        private void listarNacToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formListarNacionalidade.IsDisposed)
            {
                formListarNacionalidade = new FormListarNacionalidade();
            }
            formListarNacionalidade.MdiParent = this;
            formListarNacionalidade.StartPosition = FormStartPosition.Manual;
            formListarNacionalidade.Location = new Point((this.ClientSize.Width - formListarNacionalidade.Width) / 2, (this.ClientSize.Height - formListarNacionalidade.Height) / 2);
            formListarNacionalidade.Show();
            formListarNacionalidade.Activate();
        }
    }
}
