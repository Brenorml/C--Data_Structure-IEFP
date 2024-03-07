namespace WindowsFormsMySQL
{
    partial class FormAlterarNacionalidade
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
            this.groupBoxNac = new System.Windows.Forms.GroupBox();
            this.cbNacionalidade = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNacionalidade = new System.Windows.Forms.TextBox();
            this.tbCodigoIso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxNac.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNac
            // 
            this.groupBoxNac.Controls.Add(this.cbNacionalidade);
            this.groupBoxNac.Location = new System.Drawing.Point(23, 24);
            this.groupBoxNac.Name = "groupBoxNac";
            this.groupBoxNac.Size = new System.Drawing.Size(430, 75);
            this.groupBoxNac.TabIndex = 0;
            this.groupBoxNac.TabStop = false;
            this.groupBoxNac.Text = "Nacionalidade";
            // 
            // cbNacionalidade
            // 
            this.cbNacionalidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNacionalidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNacionalidade.FormattingEnabled = true;
            this.cbNacionalidade.Location = new System.Drawing.Point(38, 32);
            this.cbNacionalidade.Name = "cbNacionalidade";
            this.cbNacionalidade.Size = new System.Drawing.Size(282, 21);
            this.cbNacionalidade.TabIndex = 0;
            this.cbNacionalidade.SelectedValueChanged += new System.EventHandler(this.cbNacionalidade_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAtualizar);
            this.groupBox2.Controls.Add(this.btCancelar);
            this.groupBox2.Location = new System.Drawing.Point(23, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(254, 39);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(118, 48);
            this.btAtualizar.TabIndex = 3;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(49, 39);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(118, 48);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNacionalidade);
            this.groupBox1.Controls.Add(this.tbCodigoIso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tbNacionalidade
            // 
            this.tbNacionalidade.Location = new System.Drawing.Point(109, 85);
            this.tbNacionalidade.Name = "tbNacionalidade";
            this.tbNacionalidade.Size = new System.Drawing.Size(282, 20);
            this.tbNacionalidade.TabIndex = 3;
            // 
            // tbCodigoIso
            // 
            this.tbCodigoIso.Location = new System.Drawing.Point(109, 35);
            this.tbCodigoIso.Name = "tbCodigoIso";
            this.tbCodigoIso.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoIso.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nacionalidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALF2 (ISO2):";
            // 
            // FormAlterarNacionalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 409);
            this.Controls.Add(this.groupBoxNac);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlterarNacionalidade";
            this.Text = "Alterar Nacionalidade";
            this.Load += new System.EventHandler(this.FormAlterarNacionalidade_Load);
            this.groupBoxNac.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNac;
        private System.Windows.Forms.ComboBox cbNacionalidade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNacionalidade;
        private System.Windows.Forms.TextBox tbCodigoIso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}