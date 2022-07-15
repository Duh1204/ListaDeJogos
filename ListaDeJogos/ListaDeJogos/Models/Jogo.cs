using System.ComponentModel.DataAnnotations;

namespace ListaDeJogos.Models
{
    public class Jogo
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Empresa { get; set; }
        public bool Zerou { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM}", ApplyFormatInEditMode = true)]
        public DateTime DataZerou { get; set; }
        public string User { get; set; }
    }
}
