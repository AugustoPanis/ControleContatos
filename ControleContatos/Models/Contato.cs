using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Display(Name = "Nome completo")]


        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
       
        [Required(ErrorMessage = "O campo e-mail é obrigatório")]
        public string Email { get; set; }

        public string Telefone { get; set; }
       

    }
}
