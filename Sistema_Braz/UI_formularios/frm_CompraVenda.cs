using DGVPrinterHelper;
using Sistema_Braz.BLL_Classes;
using Sistema_Braz.DAL_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Sistema_Braz.UI_formularios
{
    public partial class frm_CompraVenda : Form
    {
        public frm_CompraVenda()
        {
            InitializeComponent();
        }
        produtos_DAL produto_dal = new produtos_DAL();
        DataTable tabela = new DataTable();
        Transacao_DAL transacao_DAL = new Transacao_DAL();
        transacaoDetalhe_DAL transacaoDetalhe_DAL = new transacaoDetalhe_DAL();
        user_DAL user = new user_DAL();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_nome_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_pesquisar_produto_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox_pesquisar_produto.Text;
            if (keyword == "")
            {
                textBox_produto_nome.Clear();
                textBox_produto_quantidade.Clear();
                textBox_produto_qtd_total.Clear();
                textBox_produto_avaliacao.Clear();
                return;
            }
             produtos_BLL produto = produto_dal.Pesquisar_produto(keyword);
            if (produto.nome != null)
            {
                textBox_produto_nome.Text = produto.nome.ToString();
                textBox_produto_avaliacao.Text = produto.avaliacao.ToString();
                textBox_produto_qtd_total.Text = produto.quantidade.ToString();
            }
           
        }

        private void frm_CompraVenda_Load(object sender, EventArgs e)
        {
            tabela.Columns.Add("Nome do produto");
            tabela.Columns.Add("Avaliação");
            tabela.Columns.Add("Quantidade");
            tabela.Columns.Add("Total");

        }

        private void button_add_produto_Click(object sender, EventArgs e)
        {
            string nome = textBox_produto_nome.Text;
            decimal avaliacao = decimal.Parse(textBox_produto_avaliacao.Text);
            int quantidade = 1;
            if (textBox_produto_quantidade.Text != "")
                quantidade = int.Parse(textBox_produto_quantidade.Text);
            decimal total = avaliacao * quantidade;
            decimal subtotal = decimal.Parse(textBox_SubTotal.Text);
            subtotal += total;
            if (nome == "")
            {
                MessageBox.Show("Selecione produto primeiro!");
            }
            else
            {
                tabela.Rows.Add(nome,avaliacao,quantidade,total);
                dataGridView_produtos.DataSource = tabela;
                textBox_SubTotal.Text = subtotal.ToString();
                textBox_ValorTotal.Text = subtotal.ToString();
            }
            textBox_produto_quantidade.Text = "1";
            textBox_pesquisar_produto.Clear();
        }

        private void textBox_Desconto_TextChanged(object sender, EventArgs e)
        {
            string valor = textBox_Desconto.Text;
            if (valor == "")
            {
                MessageBox.Show("Digite desconto primeiro!");
                textBox_ValorTotal.Text = "0,00";
            }
                
            else
            {
                decimal subtotal = decimal.Parse(textBox_SubTotal.Text);
                decimal desconto = decimal.Parse(textBox_Desconto.Text);
                decimal totalgeral = ((100 - desconto) / 100)* subtotal;
                textBox_ValorTotal.Text = totalgeral.ToString();
            }
        }

        private void textBox_Imposto_TextChanged(object sender, EventArgs e)
        {
            string flag =textBox_SubTotal.Text;
            decimal imposto = 0;
            if (flag == "" || flag == "0,00")
            {
                MessageBox.Show("não há valor de venda para calculo de imposto!");
                textBox_Imposto.Text = "0,00";
            }

            else
            {
                decimal anterior = decimal.Parse(textBox_SubTotal.Text);
                if (textBox_Imposto.Text != "")
                    imposto  = decimal.Parse(textBox_Imposto.Text);
                decimal totalgeral = ((100 + imposto) / 100) * anterior;
                textBox_ValorTotal.Text = totalgeral.ToString();
            }
        }

        private void textBox_TotalPago_TextChanged(object sender, EventArgs e)
        {
            decimal subtotal = decimal.Parse(textBox_ValorTotal.Text);
            decimal pago = 0;
            if (textBox_TotalPago.Text != "")
             pago = decimal.Parse(textBox_TotalPago.Text);
            textBox_Troco.Text = (pago - subtotal).ToString();
        }

        private void button_finalizarCompra_Click(object sender, EventArgs e)
        {
            Transacao_BLL transacao_BLL = new Transacao_BLL();
            transacao_BLL.tipo = "Venda";
            transacao_BLL.cliente_id = 66;
            transacao_BLL.total = Math.Round(decimal.Parse(textBox_ValorTotal.Text),2);
            transacao_BLL.data_transacao = DateTime.Now;
            transacao_BLL.data_add = DateTime.Now;
            transacao_BLL.imposto = decimal.Parse(textBox_Imposto.Text);
            transacao_BLL.desconto = decimal.Parse(textBox_Desconto.Text);
            transacao_BLL.pago= decimal.Parse(textBox_TotalPago.Text);
            transacao_BLL.troco= decimal.Parse(textBox_Troco.Text);
            user_BLL usr = user.GETID_user(frm_login.logado);
            transacao_BLL.user_add = usr.id;
            transacao_BLL.transacaoDetalhes = tabela;
            bool sucesso = false;

            using (TransactionScope scope = new TransactionScope())
            {
                int transacao_id = -1;
                bool w = transacao_DAL.Insert(transacao_BLL, out transacao_id);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    transacao_detalhe_BLL transacao_Det_BLL = new transacao_detalhe_BLL();
                    produtos_BLL produtos_BLL = produto_dal.Pesquisar_produto_transacao(tabela.Rows[i][0].ToString());
                    transacao_Det_BLL.id_produto = produtos_BLL.id;
                    transacao_Det_BLL.avaliacao = decimal.Parse(tabela.Rows[i][1].ToString());
                    transacao_Det_BLL.quantidade = int.Parse(tabela.Rows[i][2].ToString());
                    transacao_Det_BLL.total = Math.Round(decimal.Parse(tabela.Rows[i][3].ToString()), 2);
                    transacao_Det_BLL.cliente_id = transacao_id;
                    transacao_Det_BLL.data_add = DateTime.Now;
                    transacao_Det_BLL.user_add = usr.id;
                    bool y = transacaoDetalhe_DAL.Insert(transacao_Det_BLL);
                    sucesso = w && y;
                    produto_dal.removeProduto(transacao_Det_BLL.id_produto, transacao_Det_BLL.quantidade);
                }
                    if (sucesso== true)
                    {
                        scope.Complete();

                        DGVPrinter printer = new DGVPrinter();
                    printer.Title = "\r\n\nBn Morais Ferro Velho Oeste LTDA";
                    printer.SubTitle = "Telefone: (62) 3225-2011";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Desconto: " + textBox_Desconto.Text + "% \r\n" + "Imposto: " + textBox_Imposto.Text +
                        "% \r\n" + "Valor Total: " + textBox_ValorTotal.Text + "  \r\n" + "Obrigado por comprar conosco.!";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(dataGridView_produtos);

                        MessageBox.Show("Dados salvo com sucesso!");
                        dataGridView_produtos.DataSource = null;
                        dataGridView_produtos.Rows.Clear();

                        textBox_Desconto.Clear();
                        textBox_Imposto.Clear();
                        textBox_SubTotal.Clear();
                        textBox_TotalPago.Clear();
                        textBox_Troco.Clear();
                        textBox_ValorTotal.Clear();
                        

                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel salvar os dados!");
                    }

            }
        }

        private void frm_CompraVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
