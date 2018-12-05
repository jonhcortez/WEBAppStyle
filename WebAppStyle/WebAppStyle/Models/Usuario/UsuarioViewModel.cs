using System.ComponentModel;

namespace WebAppStyle.Models.Usuario
{
    public class UsuarioViewModel
    {
        #region Propriedades

        [DisplayName("Usuario_id")]
        public int UsuarioId { get; set; }

        [DisplayName("Funcionario_id")]
        public int FuncionarioId { get; set; }

        [DisplayName("Senha")]
        public string Senha { get; set; }

        [DisplayName("Permissao")]
        public int Permissao { get; set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Ativo")]
        public int Ativo { get; set; }

        #endregion

        #region Construtor

        #endregion
    }
}