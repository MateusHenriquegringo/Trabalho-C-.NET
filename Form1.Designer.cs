namespace TrabalhoProgVisual
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuarioBox = new System.Windows.Forms.TextBox();
            this.senhaBox = new System.Windows.Forms.TextBox();
            this.entrarButton = new System.Windows.Forms.Button();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.criarButron = new System.Windows.Forms.Button();
            this.linkEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.mostrarSenhaButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuarioBox
            // 
            this.usuarioBox.Location = new System.Drawing.Point(262, 108);
            this.usuarioBox.Name = "usuarioBox";
            this.usuarioBox.Size = new System.Drawing.Size(199, 20);
            this.usuarioBox.TabIndex = 0;
            this.usuarioBox.UseWaitCursor = true;
            this.usuarioBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // senhaBox
            // 
            this.senhaBox.Location = new System.Drawing.Point(262, 157);
            this.senhaBox.Name = "senhaBox";
            this.senhaBox.Size = new System.Drawing.Size(199, 20);
            this.senhaBox.TabIndex = 1;
            this.senhaBox.UseSystemPasswordChar = true;
            this.senhaBox.UseWaitCursor = true;
            this.senhaBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // entrarButton
            // 
            this.entrarButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.entrarButton.Location = new System.Drawing.Point(262, 222);
            this.entrarButton.Name = "entrarButton";
            this.entrarButton.Size = new System.Drawing.Size(199, 37);
            this.entrarButton.TabIndex = 2;
            this.entrarButton.Text = "Entrar";
            this.entrarButton.UseVisualStyleBackColor = false;
            this.entrarButton.UseWaitCursor = true;
            this.entrarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuarioLabel.Location = new System.Drawing.Point(259, 92);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(50, 13);
            this.usuarioLabel.TabIndex = 3;
            this.usuarioLabel.Text = "Usuario";
            this.usuarioLabel.UseWaitCursor = true;
            this.usuarioLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.senhaLabel.Location = new System.Drawing.Point(259, 141);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(43, 13);
            this.senhaLabel.TabIndex = 4;
            this.senhaLabel.Text = "Senha";
            this.senhaLabel.UseWaitCursor = true;
            this.senhaLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.mostrarSenhaButton);
            this.panel1.Controls.Add(this.criarButron);
            this.panel1.Controls.Add(this.linkEsqueceuSenha);
            this.panel1.Controls.Add(this.senhaLabel);
            this.panel1.Controls.Add(this.usuarioLabel);
            this.panel1.Controls.Add(this.entrarButton);
            this.panel1.Controls.Add(this.senhaBox);
            this.panel1.Controls.Add(this.usuarioBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // criarButron
            // 
            this.criarButron.BackColor = System.Drawing.Color.SteelBlue;
            this.criarButron.Location = new System.Drawing.Point(262, 265);
            this.criarButron.Name = "criarButron";
            this.criarButron.Size = new System.Drawing.Size(199, 37);
            this.criarButron.TabIndex = 6;
            this.criarButron.Text = "Criar Conta";
            this.criarButron.UseVisualStyleBackColor = false;
            this.criarButron.UseWaitCursor = true;
            this.criarButron.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkEsqueceuSenha
            // 
            this.linkEsqueceuSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkEsqueceuSenha.AutoSize = true;
            this.linkEsqueceuSenha.Location = new System.Drawing.Point(259, 191);
            this.linkEsqueceuSenha.Name = "linkEsqueceuSenha";
            this.linkEsqueceuSenha.Size = new System.Drawing.Size(108, 13);
            this.linkEsqueceuSenha.TabIndex = 5;
            this.linkEsqueceuSenha.TabStop = true;
            this.linkEsqueceuSenha.Text = "Esqueci minha senha";
            this.linkEsqueceuSenha.UseWaitCursor = true;
            this.linkEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // mostrarSenhaButton
            // 
            this.mostrarSenhaButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mostrarSenhaButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mostrarSenhaButton.Location = new System.Drawing.Point(467, 157);
            this.mostrarSenhaButton.Name = "mostrarSenhaButton";
            this.mostrarSenhaButton.Size = new System.Drawing.Size(52, 20);
            this.mostrarSenhaButton.TabIndex = 7;
            this.mostrarSenhaButton.Text = "Mostrar";
            this.mostrarSenhaButton.UseVisualStyleBackColor = false;
            this.mostrarSenhaButton.Click += new System.EventHandler(this.toggleSenha_Click);
            // 
            // Login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Login";
            this.Tag = "";
            this.Text = "Login";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioBox;
        private System.Windows.Forms.TextBox senhaBox;
        private System.Windows.Forms.Button entrarButton;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button criarButron;
        private System.Windows.Forms.LinkLabel linkEsqueceuSenha;
        private System.Windows.Forms.Button mostrarSenhaButton;
    }
}

