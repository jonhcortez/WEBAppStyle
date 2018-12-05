using System;
using System.ComponentModel;

namespace WebAppStyle.Models.Fornecedor
{
    public class FornecedorViewModel
    {
        #region Propriedades

        [DisplayName("FornecedorId")]
        public int FornecedorId { get; set; }

        [DisplayName("RazaoSocial")]
        public string RazaoSocial { get; set; }

        [DisplayName("Fantasia")]
        public string Fantasia { get; set; }

        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [DisplayName("CEP")]
        public int CEP { get; set; }

        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Endereco")]
        public string Endereco { get; set; }

        [DisplayName("IE")]
        public string IE { get; set; }

        [DisplayName("Numero")]
        public string Numero { get; set; }

        [DisplayName("telefone")]
        public string telefone { get; set; }

        [DisplayName("celular")]
        public string celular { get; set; }

        [DisplayName("DATE")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("TIME")]
        public DateTime HoraCadastro { get; set; }

        #endregion

        #region Construtor

        #endregion
    }
}
