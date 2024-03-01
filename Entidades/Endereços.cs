
namespace LivrariaAPI.Entidades
{
    public class Endereços
    {
        public virtual string? Nome { get; protected set; }
        public virtual string? Bairro { get; protected set; }
        public virtual string? Estado { get; protected set; }
        public virtual string? Logradouro { get; protected set; }
        public virtual string? Endereco { get; protected set; }
        public virtual int Numero { get; protected set; }
    }
}