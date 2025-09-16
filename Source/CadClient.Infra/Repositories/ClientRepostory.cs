using CadClient.Domain.Entities;
using CadClient.Domain.Repositories;
using CadClient.Infra.AppDBContext;
using Microsoft.EntityFrameworkCore;

namespace CadClient.Infra.Repositories
{
    public class ClientRepostory : IClientRepository
    {
        private readonly AppDbContext _context;
        public ClientRepostory(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Client> AddClientAsync(Client client)
        {
            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();
            return client;
        }
        public async Task<Client?> GetClientByCpfAsync(string cpf)
        {
            return await _context.Clients.FirstOrDefaultAsync(c => c.Cpf == cpf);
        }
    }
}
