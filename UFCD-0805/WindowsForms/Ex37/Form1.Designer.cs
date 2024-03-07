namespace Ex37
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
            this.txtAvaria = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAvaria = new System.Windows.Forms.Label();
            this.btnReparado = new System.Windows.Forms.Button();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.dgvGrelha = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAvaria
            // 
            this.txtAvaria.Location = new System.Drawing.Point(83, 114);
            this.txtAvaria.Multiline = true;
            this.txtAvaria.Name = "txtAvaria";
            this.txtAvaria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAvaria.Size = new System.Drawing.Size(330, 58);
            this.txtAvaria.TabIndex = 1;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(182, 205);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(101, 43);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(83, 35);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(32, 35);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(32, 79);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblAvaria
            // 
            this.lblAvaria.AutoSize = true;
            this.lblAvaria.Location = new System.Drawing.Point(32, 117);
            this.lblAvaria.Name = "lblAvaria";
            this.lblAvaria.Size = new System.Drawing.Size(40, 13);
            this.lblAvaria.TabIndex = 8;
            this.lblAvaria.Text = "Avaria:";
            // 
            // btnReparado
            // 
            this.btnReparado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparado.Location = new System.Drawing.Point(312, 205);
            this.btnReparado.Name = "btnReparado";
            this.btnReparado.Size = new System.Drawing.Size(101, 43);
            this.btnReparado.TabIndex = 9;
            this.btnReparado.Text = "Reparado";
            this.btnReparado.UseVisualStyleBackColor = true;
            this.btnReparado.Click += new System.EventHandler(this.btnReparado_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(83, 76);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(249, 20);
            this.txtModelo.TabIndex = 10;
            // 
            // dgvGrelha
            // 
            this.dgvGrelha.AllowUserToAddRows = false;
            this.dgvGrelha.AllowUserToDeleteRows = false;
            this.dgvGrelha.AllowUserToResizeColumns = false;
            this.dgvGrelha.AllowUserToResizeRows = false;
            this.dgvGrelha.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGrelha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrelha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Modelo,
            this.Avaria});
            this.dgvGrelha.Location = new System.Drawing.Point(35, 280);
            this.dgvGrelha.Name = "dgvGrelha";
            this.dgvGrelha.RowHeadersVisible = false;
            this.dgvGrelha.Size = new System.Drawing.Size(378, 150);
            this.dgvGrelha.TabIndex = 11;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 126;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 126;
            // 
            // Avaria
            // 
            this.Avaria.HeaderText = "Avaria";
            this.Avaria.Name = "Avaria";
            this.Avaria.Width = 126;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.dgvGrelha);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.btnReparado);
            this.Controls.Add(this.lblAvaria);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtAvaria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Avarias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAvaria;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAvaria;
        private System.Windows.Forms.Button btnReparado;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.DataGridView dgvGrelha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avaria;
    }
}

