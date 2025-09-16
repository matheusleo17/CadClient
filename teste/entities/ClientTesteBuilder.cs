using Bogus;
using Bogus.Extensions.Brazil;
using CadClient.Domain.Entities;
using Moq;

namespace teste.entities
{
    public class ClientTesteBuilder
    {
        public static Client CreateValidClient()
        {
            return new Faker<Client>()
                .RuleFor(c => c.Id, f => Guid.NewGuid())
                .RuleFor(c => c.Name, f => f.Person.FullName)
                .RuleFor(c => c.Cpf, f => f.Person.Cpf())
                .RuleFor(c => c.Email, f => f.Person.Email)
                .RuleFor(c => c.CreatedAt, f => DateTime.Now)
                .Generate();
        }
    }
}
