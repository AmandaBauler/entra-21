namespace Entra21.BancoDadosAdo.net.Views.Unidades_Federativas
{
    partial class UnidadesFederativasCadastroEdicaoForm
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
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxSiglaUf = new System.Windows.Forms.TextBox();
            this.labelSiglaUf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(12, 32);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(523, 27);
            this.textBoxUF.TabIndex = 0;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(12, 9);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(138, 20);
            this.labelUF.TabIndex = 1;
            this.labelUF.Text = "Unidade Federativa";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(337, 116);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(441, 116);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxSiglaUf
            // 
            this.textBoxSiglaUf.Location = new System.Drawing.Point(12, 83);
            this.textBoxSiglaUf.Name = "textBoxSiglaUf";
            this.textBoxSiglaUf.Size = new System.Drawing.Size(523, 27);
            this.textBoxSiglaUf.TabIndex = 4;
            // 
            // labelSiglaUf
            // 
            this.labelSiglaUf.AutoSize = true;
            this.labelSiglaUf.Location = new System.Drawing.Point(12, 62);
            this.labelSiglaUf.Name = "labelSiglaUf";
            this.labelSiglaUf.Size = new System.Drawing.Size(42, 20);
            this.labelSiglaUf.TabIndex = 5;
            this.labelSiglaUf.Text = "Sigla";
            // 
            // UnidadesFederativasCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 177);
            this.Controls.Add(this.labelSiglaUf);
            this.Controls.Add(this.textBoxSiglaUf);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.textBoxUF);
            this.Name = "UnidadesFederativasCadastroEdicaoForm";
            this.Text = "Unidade Federativa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxUF;
        private Label labelUF;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private TextBox textBoxSiglaUf;
        private Label labelSiglaUf;
    }
}