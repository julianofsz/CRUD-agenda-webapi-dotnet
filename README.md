# Agenda Web API

Web API desenvolvido para gerenciar registros de uma agenda de contatos. A API foi construída com .NET e utiliza SQL Server como banco de dados, junto com o Entity Framework para manipulação dos dados.

## Funcionalidades

- **Adicionar** um novo contato
- **Listar** todos os contatos
- **Atualizar** informações de um contato existente
- **Remover** um contato da agenda
- **Filtrar** contatos pelo status de atividade

## Estrutura do Projeto

A API foi projetada para fornecer operações básicas de CRUD (Create, Read, Update, Delete) para o gerenciamento de contatos. Cada contato possui os seguintes atributos:

- `Id`: Identificador único do contato
- `Nome`: Nome do contato
- `Telefone`: Número de telefone do contato
- `Ativo`: Indica se o contato está ativo

## Tecnologias Utilizadas

- **.NET Core**: Plataforma principal para o desenvolvimento da API.
- **Entity Framework Core**: ORM para manipulação e persistência de dados.
- **SQL Server**: Banco de dados para armazenamento das informações dos contatos.
- **Swagger**: Documentação interativa da API para facilitar o uso e o desenvolvimento.

## Pré-requisitos

- **.NET SDK**: Versão 8.0.
- **SQL Server**: Configurado e acessível para conexão com a API.
- **Visual Studio** ou **VS Code**: IDE para desenvolvimento e testes.

## Instalação e Configuração

1. **Clone o Repositório**:
   ```bash
   git clone https://github.com/julianofsz/primeira-webapi-dotnet.git

## Configuração do Banco de Dados
Atualize a string de conexão do banco de dados no arquivo `appsettings.json` com suas credenciais de acesso ao SQL Server.

## Executar as Migrações
No terminal, navegue até o diretório do projeto e execute:

```bash
dotnet ef database update
```

Isso criará o banco de dados e as tabelas necessárias com base nas configurações do Entity Framework.

## Inicie o Projeto
No terminal, execute:

```bash
dotnet run
```

## Endpoints da API
- **GET /api/contatos:** Retorna a lista de todos os contatos.
- **GET /api/contatos/{id}:** Retorna um contato específico pelo Id.
- **POST /api/contatos:** Cria um novo contato. Requer um corpo JSON com as informações do contato.
- **PUT /api/contatos/{id}:** Atualiza as informações de um contato existente.
- **DELETE /api/contatos/{id}:** Exclui um contato da agenda.

## Documentação
Para visualizar a documentação interativa da API, acesse o Swagger após iniciar a aplicação em:

```bash
https://localhost:5001/swagger
```

## Contribuições
Este é um projeto de aprendizado, e contribuições são bem-vindas! Sinta-se à vontade para abrir Issues ou Pull Requests para melhorias e correções.
