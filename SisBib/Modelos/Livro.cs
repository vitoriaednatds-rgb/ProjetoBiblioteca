namespace SisBib.Models
{
    public class Livro
    {
        public int id {get; set; }
        public string Título { get; set;}
        public string Autor { get; set;}
        public bool Emprestado { get; set,}
    }
}