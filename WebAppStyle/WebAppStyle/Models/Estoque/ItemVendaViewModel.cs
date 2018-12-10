using System;
using System.ComponentModel;

namespace WebAppStyle.Models.Estoque
{
    public class ItemVendaViewModel
    {
        #region Propriedades

        [DisplayName("ItemVendaId")]
        public int ItemVendaId { get; set; }

        [DisplayName("NotaVendaId")]
        public int NotaVendaId { get; set; }

        [DisplayName("ProdutoId")]
        public int ProdutoId { get; set; }

        [DisplayName("Valor")]
        public decimal Valor { get; set; }

        [DisplayName("ValorTotal")]
        public decimal ValorTotal { get; set; }

        [DisplayName("Quantidade")]
        public decimal Quantidade { get; set; }

        [DisplayName("DataCadastro")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("HoraCadastro")]
        public DateTime HoraCadastro { get; set; }

        #endregion

        #region Construtor

        public ItemVendaViewModel()
        { }

        #endregion
    }
}
