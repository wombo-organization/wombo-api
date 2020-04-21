namespace Wombo.Domain.Users
{
    public class User
    {
        public User(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public bool IsValid()
        {
            return 
                Id > 0 &&
                !string.IsNullOrWhiteSpace(Nome) &&
                !string.IsNullOrWhiteSpace(Email);
        }
    }
}