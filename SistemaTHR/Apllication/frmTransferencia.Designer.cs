namespace SistemaTHR.Apllication
{
    partial class frmTransferencia
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clNumeroPA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPesoBruto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPesoLiquido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clQuantidadeBob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroPA = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.clCodigoFech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDescricaoFech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPesoBrutoFech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPesoLiquidoFech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clQtBobinas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNumeroPA,
            this.clCodigo,
            this.clDescricao,
            this.clPesoBruto,
            this.clPesoLiquido,
            this.clQuantidadeBob});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(796, 94);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clNumeroPA
            // 
            this.clNumeroPA.Text = "Nº PA";
            this.clNumeroPA.Width = 102;
            // 
            // clCodigo
            // 
            this.clCodigo.Text = "Código";
            this.clCodigo.Width = 126;
            // 
            // clDescricao
            // 
            this.clDescricao.Text = "Descrição";
            this.clDescricao.Width = 259;
            // 
            // clPesoBruto
            // 
            this.clPesoBruto.Text = "Peso Bruto";
            this.clPesoBruto.Width = 101;
            // 
            // clPesoLiquido
            // 
            this.clPesoLiquido.Text = "Peso Liquido";
            this.clPesoLiquido.Width = 124;
            // 
            // clQuantidadeBob
            // 
            this.clQuantidadeBob.Text = "Quantidade de Bob";
            this.clQuantidadeBob.Width = 132;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AllowDrop = true;
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AllowDrop = true;
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(800, 575);
            this.splitContainer2.SplitterDistance = 98;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AllowDrop = true;
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.Controls.Add(this.btnSomar);
            this.splitContainer3.Panel1.Controls.Add(this.btnConectar);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.txtNumeroPA);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AllowDrop = true;
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.Controls.Add(this.listView2);
            this.splitContainer3.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer3.Size = new System.Drawing.Size(800, 473);
            this.splitContainer3.SplitterDistance = 144;
            this.splitContainer3.TabIndex = 0;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(162, 61);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 7;
            this.btnSomar.Text = "Somar...";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click_1);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(56, 61);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Carregar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nº PA";
            // 
            // txtNumeroPA
            // 
            this.txtNumeroPA.Location = new System.Drawing.Point(56, 5);
            this.txtNumeroPA.Name = "txtNumeroPA";
            this.txtNumeroPA.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroPA.TabIndex = 4;
            this.txtNumeroPA.TextChanged += new System.EventHandler(this.txtNumeroPA_TextChanged_1);
            this.txtNumeroPA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNumeroPA_KeyUp_1);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clCodigoFech,
            this.clDescricaoFech,
            this.clPesoBrutoFech,
            this.clPesoLiquidoFech,
            this.clQtBobinas});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(796, 299);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // clCodigoFech
            // 
            this.clCodigoFech.Text = "Código";
            this.clCodigoFech.Width = 123;
            // 
            // clDescricaoFech
            // 
            this.clDescricaoFech.Text = "Descrição";
            this.clDescricaoFech.Width = 146;
            // 
            // clPesoBrutoFech
            // 
            this.clPesoBrutoFech.Text = "Peso Bruto";
            this.clPesoBrutoFech.Width = 145;
            // 
            // clPesoLiquidoFech
            // 
            this.clPesoLiquidoFech.Text = "Peso Liquido";
            this.clPesoLiquidoFech.Width = 148;
            // 
            // clQtBobinas
            // 
            this.clQtBobinas.Text = "Quantidade de Bobinas";
            this.clQtBobinas.Width = 145;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(796, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.splitContainer2);
            this.Name = "frmTransferencia";
            this.Text = "frmTransferencia";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clNumeroPA;
        private System.Windows.Forms.ColumnHeader clDescricao;
        private System.Windows.Forms.ColumnHeader clPesoBruto;
        private System.Windows.Forms.ColumnHeader clPesoLiquido;
        private System.Windows.Forms.ColumnHeader clQuantidadeBob;
        private System.Windows.Forms.ColumnHeader clCodigo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroPA;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader clCodigoFech;
        private System.Windows.Forms.ColumnHeader clDescricaoFech;
        private System.Windows.Forms.ColumnHeader clPesoBrutoFech;
        private System.Windows.Forms.ColumnHeader clPesoLiquidoFech;
        private System.Windows.Forms.ColumnHeader clQtBobinas;
    }
}