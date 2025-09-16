using CadClient.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CadClient.Domain.Repositories
{
    public interface IClientRepository 
    {
        Task<Client> AddClientAsync(Client client);
        Task<Client> GetClientByCpfAsync(string cpf);
    }
}
