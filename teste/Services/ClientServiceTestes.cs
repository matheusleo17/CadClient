using CadClient.Application.Services;
using CadClient.Domain.Entities;
using CadClient.Domain.Repositories;
using FluentAssertions;
using Moq;
using teste.entities;

namespace teste.Services
{
    public class ClientServiceTestes
    {
        [Fact]
        public async Task AddClient_RetornarErro_CpfNulo()
        {
            var repoMock = new Mock<IClientRepository>();
            var service = new ClientService(repoMock.Object);
            var client = new Client { Name = "Matheus", Cpf = null };
            var result = await service.AddClientAsync(client);

            result.Success.Should().BeFalse();
            result.ErrorMessage.Should().Be("Cpf do paciente não pode ser nulo");

        }
        [Fact]
        public async Task AddClient_Success()
        {
            var repoMock = new Mock<IClientRepository>();
            var service = new ClientService(repoMock.Object);
            var validator = ClientTesteBuilder.CreateValidClient();
            var result = await service.AddClientAsync(validator);

            result.Success.Should().BeTrue();


        }
    }
}
