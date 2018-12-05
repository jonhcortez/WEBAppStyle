using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppStyle.Models.NotaCompra
{
    public class NotaCompraViewModel
    {
        #region Propriedades

        [DisplayName("NotaCompraId")]
        public int NotaCompraId { get; set; }

        [DisplayName("FuncionarioId")]
        public int FuncionarioId { get; set; }

        [DisplayName("FornecedorId")]
        public int FornecedorId { get; set; }

        [DisplayName("NumeroNota")]
        public int NumeroNota { get; set; }

        [DisplayName("Data")]
        public DateTime Data { get; set; }

        [DisplayName("Vencimento")]
        public DateTime Vencimento { get; set; }

        [DisplayName("Desconto")]
        public decimal Desconto { get; set; }

        [DisplayName("ValorTotalNota")]
        public decimal ValorTotalNota { get; set; }

        [DisplayName("ICMS")]
        public int ICMS { get; set; }

        [DisplayName("ChaveAcesso")]
        public int ChaveAcesso { get; set; }

        [DisplayName("IPI")]
        public int IPI { get; set; }

        [DisplayName("DataCadastro")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("HoraCadastro")]
        public DateTime HoraCadastro { get; set; }

        #endregion

        #region Construtor

        #endregion
    }
}
