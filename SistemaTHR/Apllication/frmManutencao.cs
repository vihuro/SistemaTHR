﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication
{
    public partial class frmManutencao : Form
    {

        DataTable dt = new DataTable();
        String Usuario;
        String Status;
        
        public frmManutencao(String usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            loadGridView1();

        }


        private void loadGridView1()
        {
            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.selecOSAber();
            this.dt = controller.dt;

            dataGridView1.DataSource = dt;

            loadStyleGridView1();

            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
                if(i == dataGridView1.Rows.Count -1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i - 1].Cells[0];

                    break;
                }
                
            }

        }

        private void loadStyleGridView1()
        {

            dataGridView1.Columns["descricaoServico"].Visible = false;

            dataGridView1.Columns["DataHoraFinalizacao"].Visible = false;

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        String numeroOS;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int i = dataGrid.SelectedRows.Count;
            
            if ( i > 0)
            {
                numeroOS = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
                txtOrdemServico.Text = numeroOS; 
                loadInfoDataGridView1();
                loadDataGridView2();
                
            }

        }

        private void loadInfoDataGridView1()
        {
            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.loadINFO(numeroOS);
            txtDescricao.Text = controller.descricaoServico;
            cboPrioridade.Text = controller.Prioridade;
        }

        private void loadStyleDataGridView2()
        {
            dataGridView2.Columns["NUMEROStatus"].HeaderText = "Nº Status";
            dataGridView2.Columns["NUMEROOSTHR"].HeaderText = "Numero/OS";
            dataGridView2.Columns["Observacao"].HeaderText = "Observação";

            dataGridView2.Columns["NUMEROStatus"].Visible = false;
            dataGridView2.Columns["NUMEROOSTHR"].Visible = false;
            dataGridView2.Columns["Observacao"].Visible = false;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Columns[4].DefaultCellStyle.SelectionForeColor = Color.BlueViolet;

        }

        private void loadDataGridView2()
        {
            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.SelecStatusOS(numeroOS);
            dataGridView2.DataSource = controller.dt;
            loadStyleDataGridView2();

            dataGridView2.ClearSelection();
            txtObservacao.Text = string.Empty;
            btnApontar.Enabled = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DateTime datahora;
        String numeroStatus;
        String dataHoraApontamento;
        String usuarioApontamento;
        String dataHoraAlteracao;
        String usuarioAlteracao;
        String observacao;
        private void btnApontar_Click(object sender, EventArgs e)
        {
            datahora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));


            if(dataGridView2.SelectedRows[0].Cells[3].Value.Equals("00/00/0000 00:00:00"))
            {
                dataGridView2.SelectedRows[0].Cells[3].Value = Convert.ToString(datahora);
                dataGridView2.SelectedRows[0].Cells[4].Value = Usuario;
            }
            if(!dataGridView2.SelectedRows[0].Cells[3].Value.Equals("00/00/0000 00:00:00"))
            {
                dataGridView2.SelectedRows[0].Cells[5].Value = Convert.ToString(datahora);
                dataGridView2.SelectedRows[0].Cells[6].Value = Usuario;
            }

            numeroStatus = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            numeroOS = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            dataHoraApontamento = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            usuarioApontamento = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            dataHoraAlteracao = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            usuarioAlteracao = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            observacao = txtObservacao.Text;

            if(dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Início de manutenção")
            {
                Status = "Manutenção/INI";
            }
            if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Requisição de peça")
            {
                Status = "Aguardando/AUT. Peça";
            }
            if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Inconsistência da OS")
            {
                Status = "OS/INC";
            }
            if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Fim de manutenção")
            {
                Status = "Manutenção/FIN";
            }
            if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Manutenção N/C")
            {
                Status = "Manutenção/NC";
            }
            if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "OS Finalizada")
            {
                Status = "OS/Finalizada";
            }

            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.dataHoraApontament = this.dataHoraApontamento;
            controller.usuarioApontamento = this.usuarioApontamento;
            controller.dataHoraAlteracao = this.dataHoraAlteracao;
            controller.usuarioAlteracao = this.usuarioAlteracao;
            controller.observacao = this.observacao;
            controller.updateStatus(numeroStatus);

            controller.statusOP = Status;
            controller.UpdateStaOS(numeroOS);

            dataGridView2.ClearSelection();
            loadDataGridView2();
            btnApontar.Enabled = false;

        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    dataGridView2.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
                    if (dataGridView2.Rows[i].Cells[4].Value != "")
                    {
                        dataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                        dataGridView2.Rows[i].DefaultCellStyle.SelectionForeColor = Color.BlueViolet;

                    }
                    if (dataGridView2.Rows[i].Cells[4].Value == "" && dataGridView2.Rows[i].Cells[2].Value.ToString() == "Início de manutenção")
                    {

                        dataGridView2.Rows[4].DefaultCellStyle.ForeColor = Color.Gray;
                    }

                }

        }

        private void clearAll()
        {
            dataGridView1.ClearSelection();

            while(dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {

                  dataGridView2.Rows.Remove(dataGridView2.Rows[i]);

                }
            }


            dataGridView2.ClearSelection();
            txtDescricao.Text = string.Empty;
            txtOrdemServico.Text = string.Empty;
            cboPrioridade.Text = string.Empty;
            btnApontar.Enabled = false;
        }

        private void frmManutencao_Load(object sender, EventArgs e)
        {

            
            dataGridView1.ClearSelection();

            int i = dataGridView2.Rows.Count;
            for (int j = 0; j < i; j++)
            {
                if (dataGridView2.CurrentCell != null)
                {
                    if (i > 0)
                    {
                        if (dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[0].Value != null)
                        {
                            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                        }
                    }
                }
            }

            dataGridView2.ClearSelection();
            txtDescricao.Text = string.Empty;
            txtOrdemServico.Text = string.Empty;
            cboPrioridade.Text = string.Empty;
            btnApontar.Enabled = false;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int i = dataGrid.SelectedRows.Count;

            if (dataGridView2.CurrentCell != null)
            {

                if (i > 0)
                {

                    if (dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[0].Value != null)
                    {
                        numeroStatus = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[0].Value.ToString();

                        Modelo.OSTHRController controller = new Modelo.OSTHRController();
                        controller.selectOBS(numeroStatus);
                        txtObservacao.Text = controller.observacao;
                    }

                    for(i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if(dataGridView2.CurrentRow.DefaultCellStyle.ForeColor == Color.Gray)
                        {
                            btnApontar.Enabled = false;

                        }
                        else
                        {
                            btnApontar.Enabled = true;
                        }
                    }

                }
            }

        }


        private void btnLimpar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(btnLimpar, "Limpar");
        }

        private void btnFiltrar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(btnFiltrar, "Filtrar");
        }

        private void btnCompra_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(btnCompra, "Solicitar peça");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            frmSolicitacaoPeca peca = new frmSolicitacaoPeca(Usuario,numeroOS);

            peca.lblUsuario.Text = this.lblUsuario.Text;
            peca.ShowDialog();
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {

            dataGridView2.SelectedRows[0].Cells[3].Value = "00/00/0000 00:00:00";
            dataGridView2.SelectedRows[0].Cells[4].Value = "";
            dataGridView2.SelectedRows[0].Cells[5].Value = "00/00/0000 00:00:00";
            dataGridView2.SelectedRows[0].Cells[6].Value = Usuario;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.VerificarPriori(numeroOS);
            if(cboPrioridade.Text != controller.Prioridade)
            {
                controller.Prioridade = cboPrioridade.Text;
                controller.usuarioPrioridade = Usuario;
                controller.dataHoraPrioridade = "";
                controller.UpdatePriori(numeroOS);
            }

            loadGridView1();
            clearAll();

        }
    }
}
