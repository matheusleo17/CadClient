using CadClient.Domain.Entities;
using CadClient.Domain.Repositories;

namespace CadClient.Application.Services
{
    public class ClientService 
    {
        private readonly IClientRepository _repository;

        public ClientService(IClientRepository repository)
        {
            _repository = repository;
        }
        public async Task<ServiceResult<Client>> AddClientAsync(Client client)
        {
            var result = new ServiceResult<Client>();
            if (client.Cpf == null)
            {
                result.Fail("Cpf do paciente não pode ser nulo");
                return result;
            }
            await _repository.AddClientAsync(client);
            result.Success = true;
            result.Data = client;
            return result;
        }


        public async Task<ServiceResult<Client>> GetClientByCpfAsync(string cpf)
        {
            var result = new ServiceResult<Client>();

            var client = await _repository.GetClientByCpfAsync(cpf);
          if (client == null)
          {
              result.Fail("Nenhum cliente encontrado para o CPF informado");
              return result;
          }
            result.Success = true;
            result.Data = client;
            return result;
           
           
        }
    }
}
