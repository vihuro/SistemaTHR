namespace SistemaTHR.Apllication
{
    partial class frmGerenciarLogin
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpEmpilhadeiras = new System.Windows.Forms.GroupBox();
            this.cboEmp = new System.Windows.Forms.ComboBox();
            this.rbEmpNao = new System.Windows.Forms.RadioButton();
            this.rbEmpSim = new System.Windows.Forms.RadioButton();
            this.grpRecebimento = new System.Windows.Forms.GroupBox();
            this.cboReceb = new System.Windows.Forms.ComboBox();
            this.rbRecebeNao = new System.Windows.Forms.RadioButton();
            this.rbEmpRecebSim = new System.Windows.Forms.RadioButton();
            this.grpExpedicao = new System.Windows.Forms.GroupBox();
            this.cboExp = new System.Windows.Forms.ComboBox();
            this.rbExpNao = new System.Windows.Forms.RadioButton();
            this.rbExpSim = new System.Windows.Forms.RadioButton();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtLimpar = new System.Windows.Forms.Button();
            this.grpAdm = new System.Windows.Forms.GroupBox();
            this.cboAdm = new System.Windows.Forms.ComboBox();
            this.rbAdmNao = new System.Windows.Forms.RadioButton();
            this.rbAdmSim = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpEmpilhadeiras.SuspendLayout();
            this.grpRecebimento.SuspendLayout();
            this.grpExpedicao.SuspendLayout();
            this.grpAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(63, 40);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(498, 554);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // grpEmpilhadeiras
            // 
            this.grpEmpilhadeiras.Controls.Add(this.cboEmp);
            this.grpEmpilhadeiras.Controls.Add(this.rbEmpNao);
            this.grpEmpilhadeiras.Controls.Add(this.rbEmpSim);
            this.grpEmpilhadeiras.Location = new System.Drawing.Point(14, 111);
            this.grpEmpilhadeiras.Name = "grpEmpilhadeiras";
            this.grpEmpilhadeiras.Size = new System.Drawing.Size(227, 59);
            this.grpEmpilhadeiras.TabIndex = 3;
            this.grpEmpilhadeiras.TabStop = false;
            this.grpEmpilhadeiras.Text = "Empilhadeiras";
            // 
            // cboEmp
            // 
            this.cboEmp.FormattingEnabled = true;
            this.cboEmp.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboEmp.Location = new System.Drawing.Point(144, 18);
            this.cboEmp.Name = "cboEmp";
            this.cboEmp.Size = new System.Drawing.Size(77, 21);
            this.cboEmp.TabIndex = 2;
            this.cboEmp.SelectedIndexChanged += new System.EventHandler(this.cboEmp_SelectedIndexChanged);
            // 
            // rbEmpNao
            // 
            this.rbEmpNao.AutoSize = true;
            this.rbEmpNao.Location = new System.Drawing.Point(55, 19);
            this.rbEmpNao.Name = "rbEmpNao";
            this.rbEmpNao.Size = new System.Drawing.Size(45, 17);
            this.rbEmpNao.TabIndex = 1;
            this.rbEmpNao.TabStop = true;
            this.rbEmpNao.Text = "Não";
            this.rbEmpNao.UseVisualStyleBackColor = true;
            this.rbEmpNao.CheckedChanged += new System.EventHandler(this.rbEmpNao_CheckedChanged);
            this.rbEmpNao.Click += new System.EventHandler(this.rbEmpNao_Click);
            // 
            // rbEmpSim
            // 
            this.rbEmpSim.AutoSize = true;
            this.rbEmpSim.Location = new System.Drawing.Point(7, 20);
            this.rbEmpSim.Name = "rbEmpSim";
            this.rbEmpSim.Size = new System.Drawing.Size(42, 17);
            this.rbEmpSim.TabIndex = 0;
            this.rbEmpSim.TabStop = true;
            this.rbEmpSim.Text = "Sim";
            this.rbEmpSim.UseVisualStyleBackColor = true;
            this.rbEmpSim.CheckedChanged += new System.EventHandler(this.rbEmpSim_CheckedChanged);
            this.rbEmpSim.Click += new System.EventHandler(this.rbEmpSim_Click);
            // 
            // grpRecebimento
            // 
            this.grpRecebimento.Controls.Add(this.cboReceb);
            this.grpRecebimento.Controls.Add(this.rbRecebeNao);
            this.grpRecebimento.Controls.Add(this.rbEmpRecebSim);
            this.grpRecebimento.Location = new System.Drawing.Point(14, 185);
            this.grpRecebimento.Name = "grpRecebimento";
            this.grpRecebimento.Size = new System.Drawing.Size(227, 59);
            this.grpRecebimento.TabIndex = 4;
            this.grpRecebimento.TabStop = false;
            this.grpRecebimento.Text = "Recebimento";
            // 
            // cboReceb
            // 
            this.cboReceb.FormattingEnabled = true;
            this.cboReceb.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboReceb.Location = new System.Drawing.Point(144, 19);
            this.cboReceb.Name = "cboReceb";
            this.cboReceb.Size = new System.Drawing.Size(77, 21);
            this.cboReceb.TabIndex = 3;
            // 
            // rbRecebeNao
            // 
            this.rbRecebeNao.AutoSize = true;
            this.rbRecebeNao.Location = new System.Drawing.Point(55, 19);
            this.rbRecebeNao.Name = "rbRecebeNao";
            this.rbRecebeNao.Size = new System.Drawing.Size(45, 17);
            this.rbRecebeNao.TabIndex = 1;
            this.rbRecebeNao.TabStop = true;
            this.rbRecebeNao.Text = "Não";
            this.rbRecebeNao.UseVisualStyleBackColor = true;
            // 
            // rbEmpRecebSim
            // 
            this.rbEmpRecebSim.AutoSize = true;
            this.rbEmpRecebSim.Location = new System.Drawing.Point(7, 20);
            this.rbEmpRecebSim.Name = "rbEmpRecebSim";
            this.rbEmpRecebSim.Size = new System.Drawing.Size(42, 17);
            this.rbEmpRecebSim.TabIndex = 0;
            this.rbEmpRecebSim.TabStop = true;
            this.rbEmpRecebSim.Text = "Sim";
            this.rbEmpRecebSim.UseVisualStyleBackColor = true;
            // 
            // grpExpedicao
            // 
            this.grpExpedicao.Controls.Add(this.cboExp);
            this.grpExpedicao.Controls.Add(this.rbExpNao);
            this.grpExpedicao.Controls.Add(this.rbExpSim);
            this.grpExpedicao.Location = new System.Drawing.Point(14, 261);
            this.grpExpedicao.Name = "grpExpedicao";
            this.grpExpedicao.Size = new System.Drawing.Size(227, 59);
            this.grpExpedicao.TabIndex = 4;
            this.grpExpedicao.TabStop = false;
            this.grpExpedicao.Text = "Expedição";
            // 
            // cboExp
            // 
            this.cboExp.FormattingEnabled = true;
            this.cboExp.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboExp.Location = new System.Drawing.Point(144, 19);
            this.cboExp.Name = "cboExp";
            this.cboExp.Size = new System.Drawing.Size(77, 21);
            this.cboExp.TabIndex = 4;
            // 
            // rbExpNao
            // 
            this.rbExpNao.AutoSize = true;
            this.rbExpNao.Location = new System.Drawing.Point(55, 19);
            this.rbExpNao.Name = "rbExpNao";
            this.rbExpNao.Size = new System.Drawing.Size(45, 17);
            this.rbExpNao.TabIndex = 1;
            this.rbExpNao.TabStop = true;
            this.rbExpNao.Text = "Não";
            this.rbExpNao.UseVisualStyleBackColor = true;
            // 
            // rbExpSim
            // 
            this.rbExpSim.AutoSize = true;
            this.rbExpSim.Location = new System.Drawing.Point(7, 20);
            this.rbExpSim.Name = "rbExpSim";
            this.rbExpSim.Size = new System.Drawing.Size(42, 17);
            this.rbExpSim.TabIndex = 0;
            this.rbExpSim.TabStop = true;
            this.rbExpSim.Text = "Sim";
            this.rbExpSim.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(63, 75);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(7, 519);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(88, 519);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // txtLimpar
            // 
            this.txtLimpar.Location = new System.Drawing.Point(7, 452);
            this.txtLimpar.Name = "txtLimpar";
            this.txtLimpar.Size = new System.Drawing.Size(75, 23);
            this.txtLimpar.TabIndex = 9;
            this.txtLimpar.Text = "Limpar";
            this.txtLimpar.UseVisualStyleBackColor = true;
            // 
            // grpAdm
            // 
            this.grpAdm.Controls.Add(this.cboAdm);
            this.grpAdm.Controls.Add(this.rbAdmNao);
            this.grpAdm.Controls.Add(this.rbAdmSim);
            this.grpAdm.Location = new System.Drawing.Point(14, 336);
            this.grpAdm.Name = "grpAdm";
            this.grpAdm.Size = new System.Drawing.Size(227, 59);
            this.grpAdm.TabIndex = 5;
            this.grpAdm.TabStop = false;
            this.grpAdm.Text = "Administrativo";
            // 
            // cboAdm
            // 
            this.cboAdm.FormattingEnabled = true;
            this.cboAdm.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboAdm.Location = new System.Drawing.Point(144, 19);
            this.cboAdm.Name = "cboAdm";
            this.cboAdm.Size = new System.Drawing.Size(77, 21);
            this.cboAdm.TabIndex = 4;
            // 
            // rbAdmNao
            // 
            this.rbAdmNao.AutoSize = true;
            this.rbAdmNao.Location = new System.Drawing.Point(55, 19);
            this.rbAdmNao.Name = "rbAdmNao";
            this.rbAdmNao.Size = new System.Drawing.Size(45, 17);
            this.rbAdmNao.TabIndex = 1;
            this.rbAdmNao.TabStop = true;
            this.rbAdmNao.Text = "Não";
            this.rbAdmNao.UseVisualStyleBackColor = true;
            // 
            // rbAdmSim
            // 
            this.rbAdmSim.AutoSize = true;
            this.rbAdmSim.Location = new System.Drawing.Point(7, 20);
            this.rbAdmSim.Name = "rbAdmSim";
            this.rbAdmSim.Size = new System.Drawing.Size(42, 17);
            this.rbAdmSim.TabIndex = 0;
            this.rbAdmSim.TabStop = true;
            this.rbAdmSim.Text = "Sim";
            this.rbAdmSim.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(752, 554);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 10;
            // 
            // frmGerenciarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 554);
            this.Controls.Add(this.grpAdm);
            this.Controls.Add(this.txtLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpExpedicao);
            this.Controls.Add(this.grpRecebimento);
            this.Controls.Add(this.grpEmpilhadeiras);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmGerenciarLogin";
            this.Text = "Gerenciar Login";
            this.Load += new System.EventHandler(this.frmGerenciarLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpEmpilhadeiras.ResumeLayout(false);
            this.grpEmpilhadeiras.PerformLayout();
            this.grpRecebimento.ResumeLayout(false);
            this.grpRecebimento.PerformLayout();
            this.grpExpedicao.ResumeLayout(false);
            this.grpExpedicao.PerformLayout();
            this.grpAdm.ResumeLayout(false);
            this.grpAdm.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox grpEmpilhadeiras;
        private System.Windows.Forms.RadioButton rbEmpNao;
        private System.Windows.Forms.RadioButton rbEmpSim;
        private System.Windows.Forms.GroupBox grpRecebimento;
        private System.Windows.Forms.RadioButton rbRecebeNao;
        private System.Windows.Forms.RadioButton rbEmpRecebSim;
        private System.Windows.Forms.GroupBox grpExpedicao;
        private System.Windows.Forms.RadioButton rbExpNao;
        private System.Windows.Forms.RadioButton rbExpSim;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button txtLimpar;
        private System.Windows.Forms.ComboBox cboEmp;
        private System.Windows.Forms.ComboBox cboReceb;
        private System.Windows.Forms.ComboBox cboExp;
        private System.Windows.Forms.GroupBox grpAdm;
        private System.Windows.Forms.ComboBox cboAdm;
        private System.Windows.Forms.RadioButton rbAdmNao;
        private System.Windows.Forms.RadioButton rbAdmSim;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}