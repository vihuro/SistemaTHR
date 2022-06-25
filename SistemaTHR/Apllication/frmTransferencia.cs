using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaTHR.Apllication
{
    public partial class frmTransferencia : Form
    {
        public frmTransferencia()
        {
            InitializeComponent();
        }

        private void txtNumeroPA_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (listView1.Items.Count == 0)
                {
                    loadPA();

                }
                else
                {
                    int resultado = -1;
                    int resultado2 = listView1.Items.Count;
                    int numeroLinha = resultado + resultado2;

                    ListViewItem item1 = listView1.Items[numeroLinha];

                    if (item1.Text == "Resultado:")
                    {
                        alterarResultado();
                    }
                    else
                    {
                        loadPA();
                    }


                }
            }
        }

        public void alterarResultado()
        {
            Modelo.loadPaController loadPaController = new Modelo.loadPaController();
            loadPaController.selectPA(txtNumeroPA.Text);

            int resultado = -1;
            int resultado2 = listView1.Items.Count;
            int numeroLinha = resultado + resultado2;

            ListViewItem item1 = listView1.Items[numeroLinha];

            if (item1.Text == "Resultado:")
            {
                item1.Text = txtNumeroPA.Text;
                item1.SubItems[1].Text = loadPaController.codigo;
                item1.SubItems[2].Text = loadPaController.descricao;
                item1.SubItems[3].Text = loadPaController.pesoBruto.ToString();
                item1.SubItems[4].Text = loadPaController.pesoLiquido.ToString();
                item1.SubItems.Add(loadPaController.qtBobinas.ToString());

                if (loadPaController.codigo != string.Empty)
                {
                    if (listView2.FindItemWithText(loadPaController.codigo) != null)
                    {
                        for (var i = 0; i < listView2.Items.Count; i++)
                        {
                            if (listView2.Items[i].Text == loadPaController.codigo)
                            {
                                decimal pesoBruto = Convert.ToDecimal(listView2.Items[i].SubItems[2].Text);
                                decimal pesoLiquido = Convert.ToDecimal(listView2.Items[i].SubItems[3].Text);

                                decimal BrutoLoadPa = Convert.ToDecimal(loadPaController.pesoBruto);
                                decimal LiquidoLoadPa = Convert.ToDecimal(loadPaController.pesoLiquido);

                                decimal resultadoBruto = pesoBruto + BrutoLoadPa;
                                decimal resultadoLiquido = pesoLiquido + LiquidoLoadPa;

                                listView2.Items[i].SubItems[2].Text = resultadoBruto.ToString();
                                listView2.Items[i].SubItems[3].Text = resultadoLiquido.ToString();

                                txtNumeroPA.Text = string.Empty;


                                break;
                            }
                        }
                    }
                    else
                    {
                        ListViewItem listFechamento = new ListViewItem(loadPaController.codigo);
                        listFechamento.SubItems.Add(loadPaController.descricao);
                        listFechamento.SubItems.Add(loadPaController.pesoBruto.ToString());
                        listFechamento.SubItems.Add(loadPaController.pesoLiquido.ToString());
                        listFechamento.SubItems.Add(loadPaController.qtBobinas.ToString());

                        listView2.Items.Add(listFechamento);


                    }
                }

            }

            txtNumeroPA.Text = string.Empty;
        }

        public void loadPA()
        {
            Modelo.loadPaController loadPaController = new Modelo.loadPaController();
            loadPaController.selectPA(txtNumeroPA.Text);


            ListViewItem list = new ListViewItem(txtNumeroPA.Text);
            if(loadPaController.codigo != null)
            {
                list.SubItems.Add(loadPaController.codigo);
                list.SubItems.Add(loadPaController.descricao);
                list.SubItems.Add(loadPaController.pesoBruto.ToString());
                list.SubItems.Add(loadPaController.pesoLiquido.ToString());
                list.SubItems.Add(loadPaController.qtBobinas.ToString());



                listView1.Items.Add(list);

                if (loadPaController.codigo != string.Empty)
                {
                    if (listView2.FindItemWithText(loadPaController.codigo) != null)
                    {
                        for (var i = 0; i < listView2.Items.Count; i++)
                        {
                            if (listView2.Items[i].Text == loadPaController.codigo)
                            {
                                decimal pesoBruto = Convert.ToDecimal(listView2.Items[i].SubItems[2].Text);
                                decimal pesoLiquido = Convert.ToDecimal(listView2.Items[i].SubItems[3].Text);

                                decimal BrutoLoadPa = Convert.ToDecimal(loadPaController.pesoBruto);
                                decimal LiquidoLoadPa = Convert.ToDecimal(loadPaController.pesoLiquido);

                                decimal resultadoBruto = pesoBruto + BrutoLoadPa;
                                decimal resultadoLiquido = pesoLiquido + LiquidoLoadPa;

                                listView2.Items[i].SubItems[2].Text = resultadoBruto.ToString();
                                listView2.Items[i].SubItems[3].Text = resultadoLiquido.ToString();

                                txtNumeroPA.Text = string.Empty;


                                break;
                            }
                        }
                    }
                    else
                    {
                        ListViewItem listFechamento = new ListViewItem(loadPaController.codigo);
                        listFechamento.SubItems.Add(loadPaController.descricao);
                        listFechamento.SubItems.Add(loadPaController.pesoBruto.ToString());
                        listFechamento.SubItems.Add(loadPaController.pesoLiquido.ToString());
                        listFechamento.SubItems.Add(loadPaController.qtBobinas.ToString());

                        listView2.Items.Add(listFechamento);

                        txtNumeroPA.Text = string.Empty;
                    }
                }
            }

            txtNumeroPA.Text = string.Empty;
        }

        private void btnConectar_Click_1(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                loadPA();

            }
            else
            {
                int resultado = -1;
                int resultado2 = listView1.Items.Count;
                int numeroLinha = resultado + resultado2;

                ListViewItem item1 = listView1.Items[numeroLinha];

                if (item1.Text == "Resultado:")
                {
                    alterarResultado();
                }
                else
                {
                    loadPA();
                }


            }

        }

        public void alterarFechamento()
        {
            double totalPesoBruto;

            int quantidadeDeLinhas = listView2.Items.Count;

            totalPesoBruto = 0;

            double resultadopesoBruto = 0;
            double resultadopesoLiquido = 0;



            foreach (ListViewItem item in listView1.Items)
            {
                double pesoBruto = Convert.ToDouble(item.SubItems[3].Text);
                double pesoLiquido = Convert.ToDouble(item.SubItems[4].Text);
                double resultadopesoBruto1 = 0;
                double resultadopesoLiquido1 = 0;

                resultadopesoBruto = resultadopesoBruto + pesoBruto;
                resultadopesoLiquido = resultadopesoLiquido + pesoLiquido;


                resultadopesoBruto1 = resultadopesoBruto;
                resultadopesoLiquido1 = resultadopesoLiquido;

            }

            ListViewItem list = new ListViewItem("Resultado:");
            list.SubItems.Add("");
            list.SubItems.Add("");
            list.SubItems.Add(resultadopesoBruto.ToString("##,#0"));
            list.SubItems.Add(resultadopesoLiquido.ToString("##,#0"));



            listView1.Items.Add(list);

        }
        private void txtNumeroPA_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listView1.Items.Count == 0)
                {
                    loadPA();

                }
                else
                {
                    int resultado = -1;
                    int resultado2 = listView1.Items.Count;
                    int numeroLinha = resultado + resultado2;

                    ListViewItem item1 = listView1.Items[numeroLinha];

                    if (item1.Text == "Resultado:")
                    {
                        alterarResultado();
                    }
                    else
                    {
                        loadPA();
                    }


                }
            }

        }

        private void btnSomar_Click_1(object sender, EventArgs e)
        {
            double totalPesoBruto;

            int quantidadeDeLinhas = listView1.Items.Count;

            totalPesoBruto = 0;

            double resultadopesoBruto = 0;
            double resultadopesoLiquido = 0;

            int resultado = -1;
            int resultado2 = listView1.Items.Count;
            int numeroLinha = resultado + resultado2;

            ListViewItem item1 = listView1.Items[numeroLinha];

            if (item1.Text != "Resultado:")
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    double pesoBruto = Convert.ToDouble(item.SubItems[3].Text);
                    double pesoLiquido = Convert.ToDouble(item.SubItems[4].Text);
                    double resultadopesoBruto1 = 0;
                    double resultadopesoLiquido1 = 0;

                    resultadopesoBruto = resultadopesoBruto + pesoBruto;
                    resultadopesoLiquido = resultadopesoLiquido + pesoLiquido;


                    resultadopesoBruto1 = resultadopesoBruto;
                    resultadopesoLiquido1 = resultadopesoLiquido;

                }

                ListViewItem list = new ListViewItem("Resultado:");
                list.SubItems.Add("");
                list.SubItems.Add("");
                list.SubItems.Add(resultadopesoBruto.ToString("##,#0"));
                list.SubItems.Add(resultadopesoLiquido.ToString("##,#0"));



                listView1.Items.Add(list);

            }

        }
        

        String id;
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();
            try
            {

                transferenciaController.insert(DateTime.Now, "Vitor");
                transferenciaController.selectId();
                this.id = transferenciaController.id;

                foreach(ListViewItem item in listView1.Items)
                {
                    String numeroPA = item.SubItems[0].Text;
                    String codigo = item.SubItems[1].Text;
                    String descricao = item.SubItems[2].Text;
                    String pesoBruto = item.SubItems[3].Text;
                    String pesoLiquido = item.SubItems[4].Text;
                    String bobinas = item.SubItems[5].Text;
                    String idTransferencia = this.id;
                    String usuarioTransferencia = "Vitor";

                    transferenciaController.insertMov(numeroPA, codigo, descricao, pesoBruto, pesoLiquido,bobinas, idTransferencia, usuarioTransferencia);

                }
                foreach(ListViewItem item2 in listView2.Items)
                {

                    String codigo = item2.SubItems[0].Text;
                    String descricao = item2.SubItems[1].Text;
                    String pesoBruto = item2.SubItems[3].Text;
                    String pesoLiquido = item2.SubItems[3].Text;
                    String bobinas = item2.SubItems[4].Text;
                    String idTransferencia = this.id;

                    transferenciaController.InsertFechamento(codigo, descricao, pesoBruto, pesoLiquido, bobinas, idTransferencia);

                }


            }
            catch
            {
                MessageBox.Show("Erro");
            }


        }
    }
}
