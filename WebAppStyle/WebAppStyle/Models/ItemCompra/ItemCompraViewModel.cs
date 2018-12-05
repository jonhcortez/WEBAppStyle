using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppStyle.Models.ItemCompra
{
    public class ItemCompraViewModel
    {
        #region Propriedades

        [DisplayName("ItemCompraId")]
        public int ItemCompraId { get; set; }

        [DisplayName("NotaCompraId")]
        public int NotaCompraId { get; set; }

        [DisplayName("ProdutoId")]
        public int ProdutoId { get; set; }

        [DisplayName("ValorTotal")]
        public decimal ValorTotal { get; set; }

        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

        [DisplayName("Valor")]
        public decimal Valor { get; set; }

        [DisplayName("DataCadastro")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("HoraCadastro")]
        public DateTime HoraCadastro { get; set; }

        #endregion

        #region Construtor

        #endregion
    }
}
