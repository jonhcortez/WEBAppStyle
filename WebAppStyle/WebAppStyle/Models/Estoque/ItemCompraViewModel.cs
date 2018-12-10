using System;
using System.ComponentModel;

namespace WebAppStyle.Models.Estoque
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

        public ItemCompraViewModel()
        { }

        #endregion
    }
}
