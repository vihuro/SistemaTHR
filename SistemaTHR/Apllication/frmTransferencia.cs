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
                        listFechamento.SubItems.Add(loadPaController.pesoBruto.ToString("###,###.#0"));
                        listFechamento.SubItems.Add(loadPaController.pesoLiquido.ToString("###,###.#0"));
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
                list.SubItems.Add(loadPaController.pesoBruto.ToString("###,###.#0"));
                list.SubItems.Add(loadPaController.pesoLiquido.ToString("###,###.#0"));
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
                                double qtBobinas = Convert.ToDouble(listView2.Items[i].SubItems[4].Text);
                                
                                decimal BrutoLoadPa = Convert.ToDecimal(loadPaController.pesoBruto);
                                decimal LiquidoLoadPa = Convert.ToDecimal(loadPaController.pesoLiquido);
                                double qtbobinasPa = Convert.ToDouble(loadPaController.qtBobinas);
                                
                                decimal resultadoBruto = pesoBruto + BrutoLoadPa;
                                decimal resultadoLiquido = pesoLiquido + LiquidoLoadPa;
                                double resultadoQtBobinas = qtBobinas + qtbobinasPa;

                                
                                listView2.Items[i].SubItems[2].Text = resultadoBruto.ToString();
                                listView2.Items[i].SubItems[3].Text = resultadoLiquido.ToString();
                                listView2.Items[i].SubItems[4].Text = resultadoQtBobinas.ToString();

                                txtNumeroPA.Text = string.Empty;


                                break;
                            }
                        }
                    }
                    else
                    {
                        ListViewItem listFechamento = new ListViewItem(loadPaController.codigo);
                        listFechamento.SubItems.Add(loadPaController.descricao);
                        listFechamento.SubItems.Add(loadPaController.pesoBruto.ToString("###,###.#0"));
                        listFechamento.SubItems.Add(loadPaController.pesoLiquido.ToString("###,###.#0"));
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


            int quantidadeDeLinhas = listView1.Items.Count;

            decimal resultadopesoBruto = 0;
            decimal resultadopesoLiquido = 0;
            double resultadoQtBobinas = 0;

            int resultado = -1;
            int resultado2 = listView1.Items.Count;
            int numeroLinha = resultado + resultado2;

            ListViewItem item1 = listView1.Items[numeroLinha];

            if (item1.Text != "Resultado:")
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    decimal pesoBruto = Convert.ToDecimal(item.SubItems[3].Text);
                    decimal pesoLiquido = Convert.ToDecimal(item.SubItems[4].Text);
                    double qtBobinas = Convert.ToDouble(item.SubItems[5].Text);
                    decimal resultadopesoBruto1 = 0;
                    decimal resultadopesoLiquido1 = 0;
                    double resultadoQtBobinas1 = 0;

                    resultadopesoBruto = resultadopesoBruto + pesoBruto;
                    resultadopesoLiquido = resultadopesoLiquido + pesoLiquido;
                    resultadoQtBobinas = resultadoQtBobinas + qtBobinas;


                    resultadopesoBruto1 = resultadopesoBruto;
                    resultadopesoLiquido1 = resultadopesoLiquido;
                    resultadoQtBobinas1 = resultadoQtBobinas;

                }

                ListViewItem list = new ListViewItem("Resultado:");
                list.SubItems.Add("");
                list.SubItems.Add("");
                list.SubItems.Add(resultadopesoBruto.ToString("###,###.#0"));
                list.SubItems.Add(resultadopesoLiquido.ToString("###,###.#0"));
                list.SubItems.Add(resultadoQtBobinas.ToString());



                listView1.Items.Add(list);

            }

        }
        
        String id;
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime dateTime = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            if (listView1.Items.Count > 0 && listView2.Items.Count > 0) 
            {
                Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();
                try
                {

                    transferenciaController.insert(dateTime, lblUsuario.Text); ;
                    transferenciaController.selectId();
                    this.id = transferenciaController.id;


                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.SubItems[0].Text != "Resultado:" || item.SubItems[1].Text != string.Empty)
                        {
                            String numeroPA = item.SubItems[0].Text;
                            String codigo = item.SubItems[1].Text;
                            String descricao = item.SubItems[2].Text;
                            String pesoBruto = item.SubItems[3].Text;
                            String pesoLiquido = item.SubItems[4].Text;
                            String bobinas = item.SubItems[5].Text;
                            String idTransferencia = this.id;
                            String usuarioTransferencia = this.lblUsuario.Text;

                            MessageBox.Show(pesoBruto);
                            MessageBox.Show(pesoLiquido);

                            transferenciaController.insertMov(numeroPA, codigo, descricao, pesoBruto, pesoLiquido, bobinas, idTransferencia, usuarioTransferencia);
                        }


                    }
                    foreach (ListViewItem item2 in listView2.Items)
                    {

                        String codigo = item2.SubItems[0].Text;
                        String descricao = item2.SubItems[1].Text;
                        String pesoBruto = item2.SubItems[2].Text;
                        String pesoLiquido = item2.SubItems[3].Text;
                        String bobinas = item2.SubItems[4].Text;
                        String idTransferencia = this.id;

                        transferenciaController.InsertFechamento(codigo, descricao, pesoBruto, pesoLiquido, bobinas, idTransferencia);

                    }

                    MessageBox.Show("Transferencia realizada com sucesso!", "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView1.Items.Clear();
                    listView2.Items.Clear();


                }
                catch
                {
                    MessageBox.Show("Erro inesperado. Contate o administrador!","THR SISTEMAS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não é possivel adicionar uma transferencia com os itens vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (listView2.FindItemWithText(listView1.SelectedItems[0].SubItems[1].Text) != null)
            {

                for (var i = 0; i < listView2.Items.Count; i++)
                {
                    if (listView2.Items[i].Text == listView1.SelectedItems[0].SubItems[1].Text)
                    {
                        decimal pesoBrutoMovi = Convert.ToDecimal(listView1.SelectedItems[0].SubItems[3].Text);
                        decimal pesoLiquidoMovi = Convert.ToDecimal(listView1.SelectedItems[0].SubItems[4].Text);
                        decimal qtBobinasMovi = Convert.ToDecimal(listView1.SelectedItems[0].SubItems[5].Text);

                        decimal pesoBrutoFech = Convert.ToDecimal(listView2.Items[i].SubItems[2].Text);
                        decimal pesoLiquidoFech = Convert.ToDecimal(listView2.Items[i].SubItems[3].Text);
                        decimal qtBobinasFech = Convert.ToDecimal(listView2.Items[i].SubItems[4].Text);

                        decimal pesoBrutoResultado = pesoBrutoMovi - pesoBrutoFech;
                        decimal pesoLiquidoResultado = pesoLiquidoMovi - pesoLiquidoFech;
                        decimal qtBobinasResultado = qtBobinasMovi - qtBobinasFech;

                        decimal pesoBrutoTotal = pesoBrutoResultado * -1;
                        decimal pesoLiquidoTotal = pesoLiquidoResultado * -1;
                        decimal qtBobinasTotal = qtBobinasResultado * -1;

                        if(pesoBrutoTotal > 0)
                        {
                            listView2.Items[i].SubItems[2].Text = pesoBrutoTotal.ToString();
                            listView2.Items[i].SubItems[3].Text = pesoLiquidoTotal.ToString();
                            listView2.Items[i].SubItems[4].Text = qtBobinasTotal.ToString();

                            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                        }
                        else
                        {
                            foreach(ListViewItem item in listView2.Items)
                            {
                                if (listView1.SelectedItems[0].SubItems[1].Text == item.SubItems[0].Text)
                                {
                            
                                    item.Selected = true;
                                    listView2.Items.RemoveAt(listView2.SelectedIndices[0]);
                                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);

                                    break;
                                }
                                

                            }
                            
                        }

                        break;
                    }
                }
            }
              
        }
    }
}
