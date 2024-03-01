namespace LivrariaAPI.Entidades
{
    public class Livros
    {
        public virtual int Id { get; protected set; }
        public virtual string? Nome { get; protected set; }
        public virtual string? Editora { get; protected set; }
        public virtual int IdFornecedor { get; protected set; }
    }
}