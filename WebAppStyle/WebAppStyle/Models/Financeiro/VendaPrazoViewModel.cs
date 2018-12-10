using System;
using System.ComponentModel;

namespace WebAppStyle.Models.Financeiro
{
    public class VendaPrazoViewModel
    {
        #region Propriedades

        [DisplayName("VendaPrazoId")]
        public int VendaPrazoId { get; set; }

        [DisplayName("NotaVendaId")]
        public int NotaVendaId { get; set; }

        [DisplayName("ClienteId")]
        public int ClienteId { get; set; }

        [DisplayName("DataPagamento")]
        public DateTime DataPagamento { get; set; }

        [DisplayName("DataVencimento")]
        public DateTime DataVencimento { get; set; }

        [DisplayName("QuantidadeParcela")]
        public int QuantidadeParcela { get; set; }

        [DisplayName("Valor")]
        public decimal Valor { get; set; }

        [DisplayName("ValorPago")]
        public decimal ValorPago { get; set; }

        [DisplayName("ValorRestante")]
        public decimal ValorRestante { get; set; }

        #endregion

        #region Construtor

        public VendaPrazoViewModel()
        { }

        #endregion
    }
}