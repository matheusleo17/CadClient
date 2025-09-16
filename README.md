🧾 CadClient


API de cadastro de clientes desenvolvida em .NET 9, organizada em arquitetura limpa (Domain, Application, Infra, Api) com suporte a TDD e testes automatizados.

🔗 Repositório: github.com/matheusleo17/CadClient

🚀 Tecnologias

.NET 9 / ASP.NET Core Web API

Entity Framework Core 9

SQL Server LocalDB

xUnit + Moq + FluentAssertions

Bogus (geração de dados fake para testes)

Swagger (documentação da API)

🏗️ Arquitetura
CadClient/
│
├── Source/
│   ├── CadClient.Api          -> Controllers / Endpoints (interface com o mundo externo)
│   ├── CadClient.Application  -> Services / Regras de negócio
│   ├── CadClient.Domain       -> Entidades / Interfaces (contratos)
│   └── CadClient.Infra        -> Persistência (EF Core / Repositórios / Migrations)
│
├── Tests/
│   ├── CadClient.Application.Tests
│   └── CadClient.Domain.Tests
│
├── CadClient.sln
└── .gitignore

⚙️ Configuração

Clone o repositório:

git clone https://github.com/matheusleo17/CadClient.git
cd CadClient


Restaure os pacotes NuGet:

dotnet restore


Configure o banco no appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CadSystem;Trusted_Connection=True;TrustServerCertificate=True;"
}


Crie o banco/migrations:

dotnet ef migrations add InitialCreate -p Source/CadClient.Infra -s Source/CadClient.Api
dotnet ef database update -p Source/CadClient.Infra -s Source/CadClient.Api


Rode a API:

dotnet run --project Source/CadClient.Api

📌 Endpoints

POST /api/client → Cadastrar cliente

GET /api/client/cpf/{cpf} → Buscar cliente por CPF

📖 Acesse a documentação Swagger em:

https://localhost:5001/swagger

🧪 Testes

Rodar todos os testes:

dotnet test


Exemplo de testes:

Validação de CPF nulo

Cadastro com sucesso

Buscar cliente por CPF inexistente

Buscar cliente válido

🛣️ Roadmap do Challenge

Dia 1 → Estruturação inicial da solução e arquitetura

Dia 2 → Configuração do EF Core e string de conexão

Dia 3 → Implementação de ClientService + Repository

Dia 4 → Implementação de TDD com xUnit, Moq e Bogus

Próximos passos →

Melhorar cobertura de testes

Implementar DTOs + validação com FluentValidation

Observabilidade (logs estruturados e métricas)

🧑‍💻 Autor

Matheus Souza
Estudando arquitetura limpa, TDD e boas práticas para atuar em FinTechs e Big Techs.

🔗 GitHub: github.com/matheusleo17
