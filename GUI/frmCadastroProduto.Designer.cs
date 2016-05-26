namespace GUI
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btLoFoto = new System.Windows.Forms.Button();
            this.btRmFoto = new System.Windows.Forms.Button();
            this.btaddCategoria = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btaddCategoria);
            this.pnDados.Controls.Add(this.btRmFoto);
            this.pnDados.Controls.Add(this.btLoFoto);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.panel1);
            this.pnDados.Controls.Add(this.cbRaca);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.txtDescricao);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDados_Paint);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBotoes_Paint);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(10, 29);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 67);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(270, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(10, 110);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(270, 98);
            this.txtDescricao.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Raça";
            // 
            // cbRaca
            // 
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Location = new System.Drawing.Point(10, 306);
            this.cbRaca.Margin = new System.Windows.Forms.Padding(2);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(120, 21);
            this.cbRaca.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Location = new System.Drawing.Point(320, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 237);
            this.panel1.TabIndex = 18;
            // 
            // pbFoto
            // 
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(0, 0);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(242, 235);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Foto";
            // 
            // btLoFoto
            // 
            this.btLoFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoFoto.Image = global::GUI.Properties.Resources.fotos_4736_152_128x128;
            this.btLoFoto.Location = new System.Drawing.Point(320, 271);
            this.btLoFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btLoFoto.Name = "btLoFoto";
            this.btLoFoto.Size = new System.Drawing.Size(119, 54);
            this.btLoFoto.TabIndex = 20;
            this.btLoFoto.Text = "Carregar Foto";
            this.btLoFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLoFoto.UseVisualStyleBackColor = true;
            this.btLoFoto.Click += new System.EventHandler(this.btLoFoto_Click);
            // 
            // btRmFoto
            // 
            this.btRmFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRmFoto.Image = global::GUI.Properties.Resources.aesthetica_5138_blog_post_delete;
            this.btRmFoto.Location = new System.Drawing.Point(451, 271);
            this.btRmFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btRmFoto.Name = "btRmFoto";
            this.btRmFoto.Size = new System.Drawing.Size(112, 54);
            this.btRmFoto.TabIndex = 21;
            this.btRmFoto.Text = "Remover Foto";
            this.btRmFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRmFoto.UseVisualStyleBackColor = true;
            this.btRmFoto.Click += new System.EventHandler(this.btRmFoto_Click);
            // 
            // btaddCategoria
            // 
            this.btaddCategoria.Location = new System.Drawing.Point(135, 306);
            this.btaddCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btaddCategoria.Name = "btaddCategoria";
            this.btaddCategoria.Size = new System.Drawing.Size(22, 19);
            this.btaddCategoria.TabIndex = 22;
            this.btaddCategoria.Text = "+";
            this.btaddCategoria.UseVisualStyleBackColor = true;
            this.btaddCategoria.Click += new System.EventHandler(this.btaddCategoria_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroProduto";
            this.Text = "Cadastro de animal";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRmFoto;
        private System.Windows.Forms.Button btLoFoto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btaddCategoria;
    }
}
