using System.ComponentModel.DataAnnotations;

namespace MerceariaMVCLm.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public int Estoque { get; set; }


        public bool Validacao()
        {
            return Preco > 0 && Estoque > 0 && !string.IsNullOrEmpty(Nome);


        }
    }

}