namespace SistemaTHR.Apllication
{
    partial class frmTrocaGas
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroEmp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrocaAtual = new System.Windows.Forms.TextBox();
            this.txtUltimaTroca = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero da Empilhadeira:";
            // 
            // lblNumeroEmp
            // 
            this.lblNumeroEmp.AutoSize = true;
            this.lblNumeroEmp.Location = new System.Drawing.Point(143, 26);
            this.lblNumeroEmp.Name = "lblNumeroEmp";
            this.lblNumeroEmp.Size = new System.Drawing.Size(42, 13);
            this.lblNumeroEmp.TabIndex = 1;
            this.lblNumeroEmp.Text = "numero";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblHorasTrabalhadas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTrocaAtual);
            this.groupBox1.Controls.Add(this.txtUltimaTroca);
            this.groupBox1.Location = new System.Drawing.Point(10, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horimetro";
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(119, 158);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(19, 13);
            this.lblHorasTrabalhadas.TabIndex = 5;
            this.lblHorasTrabalhadas.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Horas Trabalhadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Troca atual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ultima troca:";
            // 
            // txtTrocaAtual
            // 
            this.txtTrocaAtual.Location = new System.Drawing.Point(160, 52);
            this.txtTrocaAtual.Name = "txtTrocaAtual";
            this.txtTrocaAtual.Size = new System.Drawing.Size(68, 20);
            this.txtTrocaAtual.TabIndex = 1;
            this.txtTrocaAtual.EnabledChanged += new System.EventHandler(this.txtTrocaAtual_EnabledChanged);
            this.txtTrocaAtual.TextChanged += new System.EventHandler(this.txtTrocaAtual_TextChanged);
            this.txtTrocaAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrocaAtual_KeyPress);
            // 
            // txtUltimaTroca
            // 
            this.txtUltimaTroca.Enabled = false;
            this.txtUltimaTroca.Location = new System.Drawing.Point(6, 52);
            this.txtUltimaTroca.Name = "txtUltimaTroca";
            this.txtUltimaTroca.Size = new System.Drawing.Size(68, 20);
            this.txtUltimaTroca.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(26, 370);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(177, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmTrocaGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 405);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNumeroEmp);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmTrocaGas";
            this.Text = "Troca de Gás";
            this.Load += new System.EventHandler(this.frmTrocaGas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTrocaGas_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblNumeroEmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHorasTrabalhadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrocaAtual;
        private System.Windows.Forms.TextBox txtUltimaTroca;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}