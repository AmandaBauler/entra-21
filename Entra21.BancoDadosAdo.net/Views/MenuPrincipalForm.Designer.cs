namespace Entra21.BancoDadosAdo.net.Views
{
    partial class MenuPrincipalForm
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
            this.buttonEditoras = new System.Windows.Forms.Button();
            this.buttonPersonagens = new System.Windows.Forms.Button();
            this.buttonTipoPersonagem = new System.Windows.Forms.Button();
            this.buttonCidades = new System.Windows.Forms.Button();
            this.buttonUF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditoras
            // 
            this.buttonEditoras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditoras.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditoras.Image = global::Entra21.BancoDadosAdo.net.Properties.Resources.letra_e;
            this.buttonEditoras.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonEditoras.Location = new System.Drawing.Point(12, 41);
            this.buttonEditoras.Name = "buttonEditoras";
            this.buttonEditoras.Size = new System.Drawing.Size(190, 179);
            this.buttonEditoras.TabIndex = 0;
            this.buttonEditoras.Text = "Editoras";
            this.buttonEditoras.UseVisualStyleBackColor = false;
            this.buttonEditoras.Click += new System.EventHandler(this.buttonEditoras_Click);
            // 
            // buttonPersonagens
            // 
            this.buttonPersonagens.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPersonagens.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPersonagens.Image = global::Entra21.BancoDadosAdo.net.Properties.Resources.superheroe;
            this.buttonPersonagens.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonPersonagens.Location = new System.Drawing.Point(292, 41);
            this.buttonPersonagens.Name = "buttonPersonagens";
            this.buttonPersonagens.Size = new System.Drawing.Size(187, 179);
            this.buttonPersonagens.TabIndex = 1;
            this.buttonPersonagens.Text = "Personagens";
            this.buttonPersonagens.UseVisualStyleBackColor = false;
            this.buttonPersonagens.Click += new System.EventHandler(this.buttonPersonagens_Click);
            // 
            // buttonTipoPersonagem
            // 
            this.buttonTipoPersonagem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTipoPersonagem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTipoPersonagem.Image = global::Entra21.BancoDadosAdo.net.Properties.Resources.jogador;
            this.buttonTipoPersonagem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonTipoPersonagem.Location = new System.Drawing.Point(575, 41);
            this.buttonTipoPersonagem.Name = "buttonTipoPersonagem";
            this.buttonTipoPersonagem.Size = new System.Drawing.Size(186, 179);
            this.buttonTipoPersonagem.TabIndex = 2;
            this.buttonTipoPersonagem.Text = "Tipo de Personagem";
            this.buttonTipoPersonagem.UseVisualStyleBackColor = false;
            this.buttonTipoPersonagem.Click += new System.EventHandler(this.buttonTipoPersonagem_Click);
            // 
            // buttonCidades
            // 
            this.buttonCidades.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCidades.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCidades.Image = global::Entra21.BancoDadosAdo.net.Properties.Resources.arquitetura_e_cidade;
            this.buttonCidades.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCidades.Location = new System.Drawing.Point(12, 282);
            this.buttonCidades.Name = "buttonCidades";
            this.buttonCidades.Size = new System.Drawing.Size(190, 156);
            this.buttonCidades.TabIndex = 3;
            this.buttonCidades.Text = "Cidades";
            this.buttonCidades.UseVisualStyleBackColor = false;
            // 
            // buttonUF
            // 
            this.buttonUF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUF.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUF.Image = global::Entra21.BancoDadosAdo.net.Properties.Resources.pino_de_localizacao;
            this.buttonUF.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonUF.Location = new System.Drawing.Point(574, 282);
            this.buttonUF.Name = "buttonUF";
            this.buttonUF.Size = new System.Drawing.Size(187, 156);
            this.buttonUF.TabIndex = 4;
            this.buttonUF.Text = "Unidade Federativa";
            this.buttonUF.UseVisualStyleBackColor = false;
            this.buttonUF.Click += new System.EventHandler(this.buttonUF_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUF);
            this.Controls.Add(this.buttonCidades);
            this.Controls.Add(this.buttonTipoPersonagem);
            this.Controls.Add(this.buttonPersonagens);
            this.Controls.Add(this.buttonEditoras);
            this.Name = "MenuPrincipalForm";
            this.Text = "MENU INICIAL";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEditoras;
        private Button buttonPersonagens;
        private Button buttonTipoPersonagem;
        private Button buttonCidades;
        private Button buttonUF;
    }
}