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
        public frmEditarTransferencia()
        {
            InitializeComponent();
            
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadStyleGridView1()
        {
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["numeroPA"].HeaderText = "Nº P.A";
            dataGridView1.Columns["codigo"].HeaderText = "Código";
            dataGridView1.Columns["descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["pesoBruto"].HeaderText = "Peso Bruto";
            dataGridView1.Columns["pesoLiquido"].HeaderText = "Peso Liquido";
            dataGridView1.Columns["Bobinas"].HeaderText = "Qt: Bobinas";
            dataGridView1.Columns["idTransferencia"].HeaderText = "Nº/Transfenrecia";
            dataGridView1.Columns["usuarioTransferencia"].HeaderText = "Usuário/Transferencia";

            //dataGridView1.Columns["id"].Visible = false;
            //dataGridView1.Columns["idTransferencia"].Visible = false;

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
                            dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[3].Value = pesoBrutoTotal;
                            dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[4].Value = pesoLiquidoTotal;
                            dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[5].Value = qtBobinasTotal;

                            transferencia.pesoBruto = pesoBrutoTotal.ToString();
                            transferencia.pesoLiquido = pesoLiquidoTotal.ToString();
                            transferencia.bobinas = qtBobinasTotal.ToString();

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
    }
}
