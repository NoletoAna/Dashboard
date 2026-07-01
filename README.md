# Dashboard

Projeto desenvolvido com o objetivo de aprofundar conhecimentos em desenvolvimento Full Stack utilizando o ecossistema .NET, aplicando boas práticas de arquitetura, modelagem de dados, regras de negócio e desenvolvimento de APIs REST.

## Tecnologias

* .NET 10 Web API
* Entity Framework Core
* SQL Server
* Git & GitHub
* Scalar (Documentação da API)

## Estrutura Inicial do Projeto

```text
Dashboard/
│
├── Controllers/
│   └── Responsáveis pelos endpoints da API
│
├── Data/
│   └── Configurações de acesso a dados e DbContext
│
├── DTOs/
│   └── Objetos de transferência de dados (Request/Response)
│
├── Entities/
│   └── Entidades do domínio e tabelas do banco
│
├── Services/
│   └── Regras de negócio e lógica da aplicação
│
├── Program.cs
│
└── appsettings.json
```

## Registro de Evolução

### Dia 01 — Setup Inicial

#### Atividades realizadas

* Criação da Solution e da Web API
* Organização da estrutura inicial de pastas
* Configuração do Scalar para documentação da API
* Configuração do repositório Git
* Publicação do projeto no GitHub

#### Entregável

* Projeto inicial configurado e pronto para o desenvolvimento das funcionalidades.

### Dia 02 - Configurando Entity Framework Core

#### Atividades realizadas

* Instalação dos pacotes necessários do Entity Framework Core
* Configuração da conexão com o banco
* Realização da Migration Inicial + Criação da Entidade Chamado


### Dia 03 - Implementando Services

#### Atividades realizadas

* Implementação métodos de criação para usuário, categoria e chamado
* Criação das tabelas: usuário, categoria e chamado no banco
* Criação do Enum para o status da classe Chamado

### Dia 04 — Implementação da Camada de API

#### Atividades realizadas

* Criação dos Controllers para Usuário, Categoria e Chamado
* Implementação dos endpoints de criação (POST)
* Integração dos Controllers com os Services através de Injeção de Dependência
* Implementação da comunicação entre API, camada de serviços e banco de dados
* Validação do fluxo completo utilizando o Scalar

