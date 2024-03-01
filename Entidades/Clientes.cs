namespace LivrariaAPI.Entidades
{
    public class Clientes
    {
        public virtual int Id { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual string Telefone { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string Senha { get; protected set; }



    }
}