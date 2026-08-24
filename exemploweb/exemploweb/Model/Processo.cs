namespace exemploweb.Model
{
    public class Processo
    {
        public int id { get; set; }
        public string Numero { get; set; } = string.Empty;
        public DateOnly Data { get; set; }
        public string Interessado {  get; set; } = string.Empty;

        public string Assunto { get; set; } = string.Empty ;
        public string Descricao {  get; set; } = string.Empty ;
        public string Situacao {  get; set; } = string.Empty ;
        
    }
}
