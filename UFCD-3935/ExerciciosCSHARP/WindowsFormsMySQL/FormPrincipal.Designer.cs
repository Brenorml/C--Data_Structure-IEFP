namespace WindowsFormsMySQL
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formandosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacionalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirNacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarNacToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarNacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listarNacToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formandosToolStripMenuItem,
            this.nacionalidadeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formandosToolStripMenuItem
            // 
            this.formandosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.atualizarToolStripMenuItem,
            this.apagarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.listarToolStripMenuItem});
            this.formandosToolStripMenuItem.Name = "formandosToolStripMenuItem";
            this.formandosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.formandosToolStripMenuItem.Text = "&Formandos";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Image = global::WindowsFormsMySQL.Properties.Resources.Add;
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.inserirToolStripMenuItem.Text = "&Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Image = global::WindowsFormsMySQL.Properties.Resources.Refresh;
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.atualizarToolStripMenuItem.Text = "&Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Image = global::WindowsFormsMySQL.Properties.Resources.Delete;
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.apagarToolStripMenuItem.Text = "A&pagar";
            this.apagarToolStripMenuItem.Click += new System.EventHandler(this.apagarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Image = global::WindowsFormsMySQL.Properties.Resources.List;
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.listarToolStripMenuItem.Text = "&Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // nacionalidadeToolStripMenuItem
            // 
            this.nacionalidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirNacToolStripMenuItem,
            this.atualizarNacToolStripMenuItem1,
            this.deletarNacToolStripMenuItem,
            this.toolStripSeparator1,
            this.listarNacToolStripMenuItem1});
            this.nacionalidadeToolStripMenuItem.Name = "nacionalidadeToolStripMenuItem";
            this.nacionalidadeToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.nacionalidadeToolStripMenuItem.Text = "&Nacionalidade";
            // 
            // inserirNacToolStripMenuItem
            // 
            this.inserirNacToolStripMenuItem.Image = global::WindowsFormsMySQL.Properties.Resources.Add;
            this.inserirNacToolStripMenuItem.Name = "inserirNacToolStripMenuItem";
            this.inserirNacToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inserirNacToolStripMenuItem.Text = "&Inserir";
            this.inserirNacToolStripMenuItem.Click += new System.EventHandler(this.inserirNacToolStripMenuItem_Click);
            // 
            // atualizarNacToolStripMenuItem1
            // 
            this.atualizarNacToolStripMenuItem1.Image = global::WindowsFormsMySQL.Properties.Resources.Refresh;
            this.atualizarNacToolStripMenuItem1.Name = "atualizarNacToolStripMenuItem1";
            this.atualizarNacToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.atualizarNacToolStripMenuItem1.Text = "&Atualizar";
            this.atualizarNacToolStripMenuItem1.Click += new System.EventHandler(this.atualizarNacToolStripMenuItem1_Click);
            // 
            // deletarNacToolStripMenuItem
            // 
            this.deletarNacToolStripMenuItem.Image = global::WindowsFormsMySQL.Properties.Resources.Delete;
            this.deletarNacToolStripMenuItem.Name = "deletarNacToolStripMenuItem";
            this.deletarNacToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletarNacToolStripMenuItem.Text = "A&pagar";
            this.deletarNacToolStripMenuItem.Click += new System.EventHandler(this.deletarNacToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // listarNacToolStripMenuItem1
            // 
            this.listarNacToolStripMenuItem1.Image = global::WindowsFormsMySQL.Properties.Resources.List;
            this.listarNacToolStripMenuItem1.Name = "listarNacToolStripMenuItem1";
            this.listarNacToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listarNacToolStripMenuItem1.Text = "&Listar";
            this.listarNacToolStripMenuItem1.Click += new System.EventHandler(this.listarNacToolStripMenuItem1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Gestão de Formandos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formandosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacionalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirNacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarNacToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletarNacToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem listarNacToolStripMenuItem1;
    }
}