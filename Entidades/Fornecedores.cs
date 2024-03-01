namespace LivrariaAPI.Entidades
{
    public class Fornecedores
    {
        public virtual int Id { get; protected set; }
        public virtual string? Nome { get; protected set; }
        public virtual string? Cnpj { get; protected set; }
        public virtual string? Numero { get; protected set; }
    }
}