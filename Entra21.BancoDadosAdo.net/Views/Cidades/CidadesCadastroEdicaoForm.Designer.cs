namespace Entra21.BancoDadosAdo.net.Views.Cidades
{
    partial class CidadesCadastroEdicaoForm
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelCidades = new System.Windows.Forms.Label();
            this.textBoxCidades = new System.Windows.Forms.TextBox();
            this.comboBoxUF = new System.Windows.Forms.ComboBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(417, 359);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(291, 359);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelCidades
            // 
            this.labelCidades.AutoSize = true;
            this.labelCidades.Location = new System.Drawing.Point(12, 9);
            this.labelCidades.Name = "labelCidades";
            this.labelCidades.Size = new System.Drawing.Size(56, 20);
            this.labelCidades.TabIndex = 2;
            this.labelCidades.Text = "Cidade";
            // 
            // textBoxCidades
            // 
            this.textBoxCidades.Location = new System.Drawing.Point(12, 32);
            this.textBoxCidades.Name = "textBoxCidades";
            this.textBoxCidades.Size = new System.Drawing.Size(477, 27);
            this.textBoxCidades.TabIndex = 3;
            // 
            // comboBoxUF
            // 
            this.comboBoxUF.FormattingEnabled = true;
            this.comboBoxUF.Location = new System.Drawing.Point(12, 92);
            this.comboBoxUF.Name = "comboBoxUF";
            this.comboBoxUF.Size = new System.Drawing.Size(477, 28);
            this.comboBoxUF.TabIndex = 4;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(12, 69);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(138, 20);
            this.labelUF.TabIndex = 6;
            this.labelUF.Text = "Unidade Federativa";
            // 
            // CidadesCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 400);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.comboBoxUF);
            this.Controls.Add(this.textBoxCidades);
            this.Controls.Add(this.labelCidades);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "CidadesCadastroEdicaoForm";
            this.Text = "Cadastro de Cidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonCancelar;
        private Label labelCidades;
        private TextBox textBoxCidades;
        private ComboBox comboBoxUF;
        private Label labelUF;
    }
}