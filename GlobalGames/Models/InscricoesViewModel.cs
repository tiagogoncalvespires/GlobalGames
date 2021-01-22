namespace GlobalGames.Models
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;
    using GlobalGames.Dados.Entidades;

    public class InscricoesViewModel : Inscricoes
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
