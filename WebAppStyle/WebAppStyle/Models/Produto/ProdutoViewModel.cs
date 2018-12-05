using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppStyle.Models.Produto
{
    public class ProdutoViewModel
    {
        #region Propriedades

        [DisplayName("ProdutoId")]
        public int ProdutoId { get; set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Descricao")]
        public string Descricao { get; set; }

        [DisplayName("ValorCompra")]
        public decimal ValorCompra { get; set; }

        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

        #endregion

        #region Construtor

        #endregion
    }
}
