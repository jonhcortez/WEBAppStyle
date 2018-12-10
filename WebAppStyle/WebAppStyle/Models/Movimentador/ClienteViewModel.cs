using System;
using System.ComponentModel;

namespace WebAppStyle.Models.Movimentador
{
    public class ClienteViewModel
    {
        #region Propriedades

        [DisplayName("ClienteId")]
        public int ClienteId { get; set; }

        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [DisplayName("Celular")]
        public string Celular { get; set; }

        [DisplayName("Numero")]
        public string Numero { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("DataNascimento")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Endereco")]
        public string Endereco { get; set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("DataCadastro")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("HoraCadastro")]
        public DateTime HoraCadastro { get; set; }

        [DisplayName("RG")]
        public int RG { get; set; }

        [DisplayName("Sexo")]
        public char Sexo {get;set;}

        #endregion

        #region Construtor

        public ClienteViewModel()
        { }

        #endregion
    }
}
