using System;
using System.ComponentModel;

namespace WebAppStyle.Models.Fiscal
{
    public class NotaVendaViewModel
    {
        #region Propriedades

        [DisplayName("NotaVendaId")]
        public int NotaVendaId { get; set; }

        [DisplayName("Valor")]
        public decimal Valor { get; set; }

        [DisplayName("ValorTotal")]
        public decimal ValorTotal { get; set; }

        [DisplayName("Data")]
        public DateTime Data { get; set; }

        [DisplayName("Desconto")]
        public decimal Desconto { get; set; }

        [DisplayName("FuncionarioId")]
        public int FuncionarioId { get; set; }

        [DisplayName("ClienteId")]
        public int ClienteId { get; set; }

        [DisplayName("DataCadastro")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("HoraCadastro")]
        public DateTime HoraCadastro { get; set; }

        #endregion

        #region Construtor

        public NotaVendaViewModel()
        { }

        #endregion
    }
}
