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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroPA_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loadPA();
            }
        }

        private void txtNumeroPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count == 0)
            {
                loadPA();

            }
            else
            {
                foreach (ListViewItem item in listView1.Items)
                {

                    if (item.SubItems[0].Text == "Resultado:")
                    {
                        MessageBox.Show("Tem resultado!");
                    }
                    else
                    {
                        MessageBox.Show("Não tem resultado!");
                    }

                    /*while (item.SubItems[0].Text == "Resultado:")
                    {
                        if (item.SubItems[0].Text != "Resultado:")
                        {
                            loadPA();
                            break;
                        }
                        else
                        {
                            alterarResultado();
                            break;
                        }


                    }*/

                    /*if (item.SubItems[0].Text != "Resultado:")
                    {
                        MessageBox.Show("Não tem resultado ainda");
                        alterarResultado();
                    }
                    else
                    {
                        loadPA();

                    }*/




                }
            }




        }

        public void alterarResultado()
        {
            Modelo.loadPaController loadPaController = new Modelo.loadPaController();
            loadPaController.selectPA(txtNumeroPA.Text);

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == "Resultado:")
                {

                    MessageBox.Show("Alterando Resultado para valor de P.A");

                    MessageBox.Show(item.SubItems[0].Text);

                    item.SubItems[1].Text = loadPaController.codigo;
                    item.SubItems[2].Text = loadPaController.descricao;
                    item.SubItems[3].Text = loadPaController.pesoBruto.ToString();
                    item.SubItems[4].Text = loadPaController.pesoLiquido.ToString();
                    item.Text = txtNumeroPA.Text;

                }
            }
        }

        public void loadPA()
        {
            Modelo.loadPaController loadPaController = new Modelo.loadPaController();
            loadPaController.selectPA(txtNumeroPA.Text);

            foreach (ListViewItem item in listView1.Items)
            {
               // MessageBox.Show(item.SubItems[0].Text);

                /*if (item.SubItems[0].Text == "Resultado:")
                {
                    item.SubItems[1].Text = loadPaController.codigo.ToString();
                    item.SubItems[2].Text = loadPaController.descricao.ToString();
                    item.SubItems[3].Text = "0";
                    item.Text = txtNumeroPA.Text;

                }
                else
                {

                }*/

                /*double pesoBruto = Convert.ToDouble(item.SubItems[3].Text);
                double pesoLiquido = Convert.ToDouble(item.SubItems[4].Text);
                double resultadopesoBruto1 = 0;
                double resultadopesoLiquido1 = 0;

                resultadopesoBruto = resultadopesoBruto + pesoBruto;
                resultadopesoLiquido = resultadopesoLiquido + pesoLiquido;


                resultadopesoBruto1 = resultadopesoBruto;
                resultadopesoLiquido1 = resultadopesoLiquido;*/

            }
            ListViewItem list = new ListViewItem(txtNumeroPA.Text);
            list.SubItems.Add(loadPaController.codigo);
            list.SubItems.Add(loadPaController.descricao);
            list.SubItems.Add(loadPaController.pesoBruto.ToString());
            list.SubItems.Add(loadPaController.pesoLiquido.ToString());
            list.SubItems.Add(loadPaController.qtBobinas.ToString());



            listView1.Items.Add(list);

            txtNumeroPA.Text = string.Empty;



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double totalPesoBruto;

            int quantidadeDeLinhas = listView1.Items.Count;

            totalPesoBruto = 0;

            double resultadopesoBruto = 0;
            double resultadopesoLiquido = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                MessageBox.Show(item.SubItems[0].Text);

                if (item.SubItems[0].Text == "Resultado:")
                {
                    item.SubItems[1].Text = "0";
                    item.SubItems[2].Text = "0";
                    item.SubItems[3].Text = "0";
                    item.Text = string.Empty;

                }
                else
                {

                }

                /*double pesoBruto = Convert.ToDouble(item.SubItems[3].Text);
                double pesoLiquido = Convert.ToDouble(item.SubItems[4].Text);
                double resultadopesoBruto1 = 0;
                double resultadopesoLiquido1 = 0;

                resultadopesoBruto = resultadopesoBruto + pesoBruto;
                resultadopesoLiquido = resultadopesoLiquido + pesoLiquido;


                resultadopesoBruto1 = resultadopesoBruto;
                resultadopesoLiquido1 = resultadopesoLiquido;*/

            }

           // double resultadopesoBruto = 0;
           // double resultadopesoLiquido = 0;
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

            MessageBox.Show("o resultado é = " + resultadopesoBruto);

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
