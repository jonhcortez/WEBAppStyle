using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppStyle.Models.Estoque
{
    public class ProdutoViewModel
    {
        #region Propriedades

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        public ProdutoViewModel()
        { }

        #endregion
    }
}
