using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_Supermercado_Menor_Preço
{
    //nome, fabricante, código de barras, valor unitário, valor de compra e quantidade em estoque de determinado produto.
    public class Estoque
    {
        public string nome;
        public string fabricante;
        public int codigoDeBarras;
        public double valorUnitario;
        public double valorDeCompra;
        public int qtdNoEstoque;
    }
}
