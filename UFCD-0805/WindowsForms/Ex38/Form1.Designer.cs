namespace Ex38
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblVisitado = new System.Windows.Forms.Label();
            this.txtVisitado = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.mtxtHora = new System.Windows.Forms.MaskedTextBox();
            this.dgvGrelha = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcuraTipo = new System.Windows.Forms.Button();
            this.btnProcuraData = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAtualizar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(289, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // cboDocumento
            // 
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Items.AddRange(new object[] {
            "Bilhete de Identidade",
            "Cartão Cidadão",
            "Carta de Condução",
            "Passaporte",
            "Outro"});
            this.cboDocumento.Location = new System.Drawing.Point(88, 96);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(163, 21);
            this.cboDocumento.TabIndex = 3;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(20, 99);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 4;
            this.lblDocumento.Text = "Documento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(257, 99);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(307, 96);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(70, 20);
            this.txtNumero.TabIndex = 6;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 140);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Particular",
            "Empresa",
            "Comercial",
            "Instituição Pública",
            "Técnica/Assistência",
            "Visita de Estudo",
            "Outro"});
            this.cboTipo.Location = new System.Drawing.Point(88, 137);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(163, 21);
            this.cboTipo.TabIndex = 8;
            // 
            // lblVisitado
            // 
            this.lblVisitado.AutoSize = true;
            this.lblVisitado.Location = new System.Drawing.Point(20, 180);
            this.lblVisitado.Name = "lblVisitado";
            this.lblVisitado.Size = new System.Drawing.Size(44, 13);
            this.lblVisitado.TabIndex = 9;
            this.lblVisitado.Text = "Visitado";
            // 
            // txtVisitado
            // 
            this.txtVisitado.Location = new System.Drawing.Point(88, 177);
            this.txtVisitado.Name = "txtVisitado";
            this.txtVisitado.Size = new System.Drawing.Size(289, 20);
            this.txtVisitado.TabIndex = 10;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(20, 220);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(88, 218);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(163, 20);
            this.dtpData.TabIndex = 12;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(297, 220);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "Hora";
            // 
            // mtxtHora
            // 
            this.mtxtHora.Location = new System.Drawing.Point(333, 217);
            this.mtxtHora.Mask = "00:00";
            this.mtxtHora.Name = "mtxtHora";
            this.mtxtHora.Size = new System.Drawing.Size(44, 20);
            this.mtxtHora.TabIndex = 14;
            // 
            // dgvGrelha
            // 
            this.dgvGrelha.AllowUserToAddRows = false;
            this.dgvGrelha.AllowUserToDeleteRows = false;
            this.dgvGrelha.AllowUserToResizeColumns = false;
            this.dgvGrelha.AllowUserToResizeRows = false;
            this.dgvGrelha.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGrelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrelha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Hora});
            this.dgvGrelha.Location = new System.Drawing.Point(24, 254);
            this.dgvGrelha.Name = "dgvGrelha";
            this.dgvGrelha.RowHeadersVisible = false;
            this.dgvGrelha.Size = new System.Drawing.Size(353, 184);
            this.dgvGrelha.TabIndex = 15;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 8;
            this.Nome.Name = "Nome";
            this.Nome.Width = 170;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 8;
            this.Hora.Name = "Hora";
            this.Hora.Width = 170;
            // 
            // btnProcuraTipo
            // 
            this.btnProcuraTipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProcuraTipo.BackgroundImage")));
            this.btnProcuraTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProcuraTipo.Location = new System.Drawing.Point(260, 136);
            this.btnProcuraTipo.Name = "btnProcuraTipo";
            this.btnProcuraTipo.Size = new System.Drawing.Size(34, 22);
            this.btnProcuraTipo.TabIndex = 16;
            this.btnProcuraTipo.UseVisualStyleBackColor = true;
            this.btnProcuraTipo.Click += new System.EventHandler(this.btnProcuraTipo_Click);
            // 
            // btnProcuraData
            // 
            this.btnProcuraData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProcuraData.BackgroundImage")));
            this.btnProcuraData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProcuraData.Location = new System.Drawing.Point(257, 216);
            this.btnProcuraData.Name = "btnProcuraData";
            this.btnProcuraData.Size = new System.Drawing.Size(34, 22);
            this.btnProcuraData.TabIndex = 17;
            this.btnProcuraData.UseVisualStyleBackColor = true;
            this.btnProcuraData.Click += new System.EventHandler(this.btnProcuraData_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbAnular,
            this.tsbGuardar,
            this.tsbEliminar,
            this.toolStripSeparator1,
            this.tsbConsultar,
            this.toolStripSeparator2,
            this.tsbAtualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(405, 46);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(40, 43);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // tsbAnular
            // 
            this.tsbAnular.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnular.Image")));
            this.tsbAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnular.Name = "tsbAnular";
            this.tsbAnular.Size = new System.Drawing.Size(46, 43);
            this.tsbAnular.Text = "Anular";
            this.tsbAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbAnular.Click += new System.EventHandler(this.tsbAnular_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(53, 43);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(54, 43);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // tsbConsultar
            // 
            this.tsbConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tsbConsultar.Image")));
            this.tsbConsultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultar.Name = "tsbConsultar";
            this.tsbConsultar.Size = new System.Drawing.Size(62, 43);
            this.tsbConsultar.Text = "Consultar";
            this.tsbConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbConsultar.Click += new System.EventHandler(this.tsbConsultar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // tsbAtualizar
            // 
            this.tsbAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAtualizar.Image")));
            this.tsbAtualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAtualizar.Name = "tsbAtualizar";
            this.tsbAtualizar.Size = new System.Drawing.Size(57, 43);
            this.tsbAtualizar.Text = "Atualizar";
            this.tsbAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbAtualizar.Click += new System.EventHandler(this.tsbAtualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnProcuraData);
            this.Controls.Add(this.btnProcuraTipo);
            this.Controls.Add(this.dgvGrelha);
            this.Controls.Add(this.mtxtHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtVisitado);
            this.Controls.Add(this.lblVisitado);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.cboDocumento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registo de Visitas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cboDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblVisitado;
        private System.Windows.Forms.TextBox txtVisitado;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.MaskedTextBox mtxtHora;
        private System.Windows.Forms.DataGridView dgvGrelha;
        private System.Windows.Forms.Button btnProcuraTipo;
        private System.Windows.Forms.Button btnProcuraData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
    }
}

