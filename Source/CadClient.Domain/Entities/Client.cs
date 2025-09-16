namespace CadClient.Domain.Entities
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string? Email { get; set; } 
        public DateTime CreatedAt { get; set; }


    }
}
