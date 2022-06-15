﻿using Sistema_Braz.BLL_Classes;
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
        transacao_detalhe_BLL transacaoDetalhe_BLL = new transacao_detalhe_BLL();
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
             produtos_BLL produto = produto_dal.Pesquisar_produto_transacao(keyword);
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
            decimal subtotal = decimal.Parse(textBox_SubTotal.Text);
            decimal pago = 0;
            if (textBox_TotalPago.Text != "")
             pago = decimal.Parse(textBox_TotalPago.Text);
            textBox_Troco.Text = (pago - subtotal).ToString();
        }

        private void button_finalizarCompra_Click(object sender, EventArgs e)
        {
            Transacao_BLL transacao_BLL = new Transacao_BLL();
            transacao_BLL.tipo = "Venda";
            transacao_BLL.cliente_id = transacao_BLL.id;
            transacao_BLL.total = Math.Round(decimal.Parse(textBox_ValorTotal.Text),2);
            transacao_BLL.data_transacao = DateTime.Now;
            transacao_BLL.imposto = decimal.Parse(textBox_Imposto.Text);
            transacao_BLL.desconto = decimal.Parse(textBox_Desconto.Text);
            transacao_BLL.user_add = int.Parse(frm_login.logado.ToString());

            bool sucesso = false;

            using (TransactionScope scope = new TransactionScope())
            {
                int transacao_id = -1;
                bool w = transacao_DAL.Insert(transacao_BLL, out transacao_id);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    produtos_BLL produtos_BLL = produto_dal.Pesquisar_produto_transacao(tabela.Rows[i][0].ToString());
                    transacaoDetalhe_BLL.id_produto = produtos_BLL.id;

                }
            }
        }
    }
}