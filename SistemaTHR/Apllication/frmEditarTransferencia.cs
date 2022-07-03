using System;
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
    public partial class frmEditarTransferencia : Form
    {
        private String numeroTransferencia;
        private String usuarioMovimentacao;

        public frmEditarTransferencia(String numeroTransferencia, string usuarioMovimentacao)
        {
            InitializeComponent();
            this.numeroTransferencia = numeroTransferencia;
            this.usuarioMovimentacao = usuarioMovimentacao;
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadStyleGridView1()
        {

            dataGridView1.Columns["id"].HeaderText = "Nº/Movimentação";
            dataGridView1.Columns["numeroPA"].HeaderText = "Nº P.A";
            dataGridView1.Columns["codigo"].HeaderText = "Código";
            dataGridView1.Columns["descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["pesoBruto"].HeaderText = "Peso Bruto";
            dataGridView1.Columns["pesoLiquido"].HeaderText = "Peso Liquido";
            dataGridView1.Columns["Bobinas"].HeaderText = "Qt: Bobinas";
            dataGridView1.Columns["idTransferencia"].HeaderText = "Nº/Transfenrecia";
            dataGridView1.Columns["usuarioTransferencia"].HeaderText = "Usuário/Transferencia";
  ;


        }
        public void loadStyleGridView2()
        {
            dataGridView2.Columns["id"].HeaderText = "Nº/Fechamento";
            dataGridView2.Columns["codigo"].HeaderText = "Código";
            dataGridView2.Columns["descricao"].HeaderText = "Descrição";
            dataGridView2.Columns["pesoBruto"].HeaderText = "Peso Bruto";
            dataGridView2.Columns["pesoLiquido"].HeaderText = "Peso Liquido";
            dataGridView2.Columns["QTBobinas"].HeaderText = "Qt: Bobinas";
            dataGridView2.Columns["idTransferencia"].HeaderText = "Nº/Transfenrecia";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {


                    if (dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[1].Value.ToString() == dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString())
                    {

                        decimal pesoBrutoMovi = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[4].Value.ToString());
                        decimal pesoLiquidoMovi = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[5].Value.ToString());
                        decimal qtBobinasMovi = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[6].Value.ToString());

                        String idMovimento = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();

                        Modelo.transferenciaController transferencia = new Modelo.transferenciaController();
                        transferencia.deletMovi(idMovimento);

                        decimal pesoBrutoFech = Convert.ToDecimal(dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[3].Value.ToString());
                        decimal pesoLiquidoFech = Convert.ToDecimal(dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[4].Value.ToString());
                        decimal qtBobinasFech = Convert.ToDecimal(dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[5].Value.ToString());

                        decimal pesoBrutoResultado = pesoBrutoMovi - pesoBrutoFech;
                        decimal pesoLiquidoResultado = pesoLiquidoMovi - pesoLiquidoFech;
                        decimal qtBobinasResultado = qtBobinasMovi - qtBobinasFech;

                        decimal pesoBrutoTotal = pesoBrutoResultado * -1;
                        decimal pesoLiquidoTotal = pesoLiquidoResultado * -1;
                        decimal qtBobinasTotal = qtBobinasResultado * -1;

                        if (pesoBrutoTotal == 0)
                        {
                            dataGridView2.Rows.Remove(dataGridView2.Rows[i]);
                        }
                        else
                        {
                            dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[3].Value = pesoBrutoTotal.ToString("###,###.#0");
                            dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[4].Value = pesoLiquidoTotal.ToString("###,###.#0");
                            dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[5].Value = qtBobinasTotal.ToString("###,###.#0");

                            transferencia.pesoBruto = pesoBrutoTotal.ToString("###,###.#0");
                            transferencia.pesoLiquido = pesoLiquidoTotal.ToString("###,###.#0");
                            transferencia.bobinas = qtBobinasTotal.ToString("###,###.#0");

                            transferencia.updateFech(dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[0].Value.ToString());

                        }

                        break;
                    }


                }
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private String numeroPa;
        private String codigo;
        private String descricao;
        private String pesoBruto;
        private String pesoLiquido;
        private String qtBobinas;
        private DataTable dt;
        private void btnConectar_Click(object sender, EventArgs e)
        {
            Modelo.loadPaController loadPaController = new Modelo.loadPaController();
            loadPaController.selectPA(txtNumeroPA.Text);
            if (loadPaController.codigo != null)
            {
                this.numeroPa = loadPaController.numeroPa;
                this.codigo = loadPaController.codigo;
                this.descricao = loadPaController.descricao;
                this.pesoBruto = loadPaController.pesoBruto.ToString("###,###.#0");
                this.pesoLiquido = loadPaController.pesoLiquido.ToString("###,###.#0");
                this.qtBobinas = loadPaController.qtBobinas.ToString();

                Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();

                transferenciaController.insertMov(numeroPa, codigo, descricao, pesoBruto, pesoLiquido, qtBobinas, numeroTransferencia, "vitor");
                loadGridView1();
                loadStyleGridView1();

                MessageBox.Show("Adicionado com sucesso");
            }

        }

        private void loadGridView1()
        {
            Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();
            transferenciaController.selectMovi(numeroTransferencia);
            this.dt = transferenciaController.dt;

            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = dt.TableName;

        }

        private void txtNumeroPA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
