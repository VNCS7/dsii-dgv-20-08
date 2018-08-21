using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;


namespace EtecMetodoGenerics
{
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }

        List<Classes.Produto> lista_produto = new List<Classes.Produto>();

        private void Produto_Load(object sender, EventArgs e)
        {
            InserirProdutos();
            CarregarGrid();
           
        }
        
        private void CarregarGrid()
        {
            gdvProdutos.DataSource = null;
            gdvProdutos.DataSource = lista_produto;
        }

        private void InserirProdutos()
        {
            Classes.Produto produto1 = new Classes.Produto();
            produto1.idProduto = 1;
            produto1.nmProduto = "GEL";
            produto1.marcaProduto = "BOZZANO";
            produto1.precoProduto = "20";
            lista_produto.Add(produto1);
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Classes.Produto> listaPesquisa = new List<Classes.Produto>();
            listaPesquisa = lista_produto;
            //PODE COMENTAR AVONTEES GRANDEEE
            listaPesquisa = lista_produto.Where(i => i.nmProduto.Contains(txtNomeProd.Text) && i.marcaProduto.Contains(txtMarca.Text)).ToList();
            gdvProdutos.DataSource = null; //NUM QUERO NADA
            gdvProdutos.DataSource = listaPesquisa;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeProd.Text = string.Empty;
            txtMarca.Text = string.Empty;
            gdvProdutos.DataSource = null;
            CarregarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Produto produto1 = new Classes.Produto();
            produto1.idProduto = System.Convert.ToInt32(txtIDProduto.Text);
            produto1.nmProduto = txtNomeProduto.Text;
            produto1.marcaProduto = txtMarcaProduto.Text;
            produto1.precoProduto = txtPrecoProduto.Text;
            lista_produto.Add(produto1);
        }
    }
}
