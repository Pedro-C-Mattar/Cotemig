namespace Prj_OrdemServico
{
    partial class FrmUsuario
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
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSetor
            // 
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(117, 219);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(338, 21);
            this.cmbSetor.TabIndex = 1;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(117, 74);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(180, 20);
            this.txtnome.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(117, 125);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(180, 20);
            this.txtemail.TabIndex = 3;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(117, 172);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(104, 20);
            this.txttelefone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Setor";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(27, 262);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(117, 262);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(208, 262);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(298, 262);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(27, 307);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.Size = new System.Drawing.Size(514, 172);
            this.dtgUsuarios.TabIndex = 14;
            this.dtgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellClick);
            this.dtgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellContentClick);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(117, 31);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(54, 20);
            this.txtid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 509);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.txtid);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}