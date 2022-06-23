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
                int resultado = -1;
                int resultado2 = listView1.Items.Count;
                int numeroLinha = resultado + resultado2;

                ListViewItem item1 = listView1.Items[numeroLinha];

                MessageBox.Show("Achei só o resultado " + item1.Text);


                if(item1.Text == "Resultado:")
                {
                    alterarResultado();
                }
                else
                {
                    loadPA();
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

            }

            txtNumeroPA.Text = string.Empty;
        }

        public void loadPA()
        {
            Modelo.loadPaController loadPaController = new Modelo.loadPaController();
            loadPaController.selectPA(txtNumeroPA.Text);


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
