# ServiceSoap: API RESTful e Serviço SOAP para Gerenciamento de Usuários

Uma solução robusta em .NET 8 para operações CRUD de usuários, expondo funcionalidades via interfaces REST e SOAP.

![License](https://img.shields.io/github/license/DanielMarinhoFerreira/ServiceWebApp?style=for-the-badge)
![GitHub issues](https://img.shields.io/github/issues/DanielMarinhoFerreira/ServiceWebApp?style=for-the-badge)
![Top Language](https://img.shields.io/github/languages/top/DanielMarinhoFerreira/ServiceWebApp?style=for-the-badge)
![Code Size](https://img.shields.io/github/languages/code-size/DanielMarinhoFerreira/ServiceWebApp?style=for-the-badge)

## 📝 Descrição Detalhada

O projeto **ServiceSoap** é uma aplicação .NET 8 desenvolvida para gerenciar informações de usuários, oferecendo uma abordagem de comunicação dual: tanto via **API RESTful** quanto via **Serviços SOAP**. Ele foi projetado para ser flexível e interoperável, atendendo a diferentes necessidades de integração.

A persistência de dados é realizada utilizando **Entity Framework Core** com um banco de dados **MySQL**, garantindo robustez e escalabilidade. A validação de dados de entrada é gerenciada de forma eficiente pelo **FluentValidation**, assegurando a integridade das informações. Além disso, a API RESTful é documentada interativamente através do **Swagger/Swashbuckle**, facilitando o consumo e a exploração dos endpoints.

## ✅ Status do Projeto

`✅ Estável`

## 🚀 Acesso ao Projeto

Este projeto está disponível no GitHub. Você pode acessar o repositório para explorar o código, clonar e contribuir:

[Veja o repositório no GitHub](https://github.com/DanielMarinhoFerreira/ServiceWebApp)

## ✨ Funcionalidades Principais

*   **Gerenciamento Completo de Usuários (CRUD):** Permite criar, ler, atualizar e excluir registros de usuários.
*   **API RESTful:** Endpoints HTTP para todas as operações CRUD de usuários, seguindo os princípios REST.
*   **Serviço SOAP:** Implementação de um serviço SOAP para as mesmas operações CRUD, garantindo compatibilidade com sistemas legados ou que preferem essa abordagem.
*   **Validação de Dados Robustas:** Utiliza FluentValidation para garantir a integridade e conformidade dos dados de entrada.
*   **Persistência de Dados com EF Core:** Gerenciamento do banco de dados MySQL através do Entity Framework Core, incluindo migrações.
*   **Documentação Interativa da API:** Integração com Swagger/Swashbuckle para uma documentação clara e interativa dos endpoints REST.
*   **Estrutura de Projeto Limpa:** Organização modular com separação de responsabilidades (Controllers, DTOs, Interfaces, Models, Repositories, Validators).

## 🛠️ Tecnologias Utilizadas

Este projeto foi construído com as seguintes tecnologias:

*   **Backend:** C# / .NET 8
*   **Web Framework:** ASP.NET Core
*   **ORM (Object-Relational Mapper):** Entity Framework Core
*   **Banco de Dados:** MySQL (via Pomelo.EntityFrameworkCore.MySql)
*   **Serviços SOAP:** SoapCore
*   **Validação:** FluentValidation
*   **Documentação API:** Swashbuckle.AspNetCore (Swagger/OpenAPI)
*   **Autenticação (Presente nas Dependências):** Microsoft.AspNetCore.Authentication.JwtBearer (indica suporte ou plano para JWT)

## 📂 Estrutura do Projeto

A estrutura principal do projeto `ServiceSoap` é organizada da seguinte forma:

```
ServiceSoap/
├── Controllers/              # Contém os controladores da API RESTful (ex: UsuarioController.cs).
├── Data/                     # Contexto do banco de dados (AppDbContext.cs) para Entity Framework Core.
├── Dto/                      # Objetos de Transferência de Dados (ex: UsuarioDto.cs).
├── Interface/                # Definições de interfaces para os serviços (ex: IICrud.cs, IUsuario.cs).
├── Migrations/               # Histórico de migrações do Entity Framework Core.
├── Models/                   # Modelos de entidade do banco de dados (ex: Usuario.cs).
├── Repository/               # Implementações da lógica de negócios e acesso a dados (ex: RUsuario.cs).
├── Validators/               # Classes de validação de dados usando FluentValidation.
├── appsettings.json          # Arquivo de configuração da aplicação, incluindo string de conexão.
├── Program.cs                # Ponto de entrada da aplicação, configuração de serviços e middleware.
└── ServiceSoap.csproj        # Arquivo de projeto .NET.
```

## 📋 Pré-requisitos

Antes de iniciar o projeto, certifique-se de ter os seguintes softwares e ferramentas instalados:

*   **[.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)**
*   **[MySQL Server](https://dev.mysql.com/downloads/mysql/)** (ou acesso a uma instância MySQL)
*   **[dotnet-ef CLI tool](https://learn.microsoft.com/pt-br/ef/core/cli/dotnet)** para gerenciar migrações do Entity Framework Core. Se não tiver, instale com:
    ```bash
    dotnet tool install --global dotnet-ef
    ```

## 🚀 Guia de Início Rápido

Siga estas etapas para configurar e executar o projeto localmente:

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/DanielMarinhoFerreira/ServiceWebApp
    ```
2.  **Navegue até o diretório do projeto:**
    ```bash
    cd ServiceWebApp/ServiceSoap
    ```
3.  **Configure a string de conexão:**
    Abra o arquivo `appsettings.json` e atualize a `DefaultConnection` para apontar para sua instância do MySQL.
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=ServiceSoap;User Id=root;Password=SUA_SENHA_AQUI;"
      },
      "AllowedHosts": "*"
    }
    ```
    **Nota:** A senha `1nt3gr@l0g` é um exemplo. Altere-a para uma senha segura ou utilize variáveis de ambiente em produção.

4.  **Aplique as migrações do banco de dados:**
    Certifique-se de que o MySQL Server esteja em execução.
    ```bash
    dotnet ef database update
    ```
    Isso criará o banco de dados `ServiceSoap` (se não existir) e a tabela `USERS`.

5.  **Execute o projeto:**
    ```bash
    dotnet run
    ```
    Ou, se estiver usando o Visual Studio, abra o arquivo `ServiceSoap.sln` e execute a aplicação.

    A aplicação será iniciada nas URLs configuradas no `Properties/launchSettings.json`, geralmente:
    *   HTTP: `http://localhost:5277`
    *   HTTPS: `https://localhost:7189`

## ⚙️ Uso

Após iniciar a aplicação, você pode interagir com os serviços da seguinte forma:

### API RESTful (Swagger UI)

Acesse a documentação interativa da API RESTful através do Swagger UI no seu navegador:

*   **Desenvolvimento (HTTPS):** `https://localhost:7189/swagger`
*   **Desenvolvimento (HTTP):** `http://localhost:5277/swagger`

Aqui você pode testar os endpoints CRUD para `Usuario`.

### Serviço SOAP (WSDL)

O serviço SOAP está disponível no endpoint `/Service.asmx`. Você pode acessar o WSDL para gerar clientes SOAP em outras linguagens ou ferramentas:

*   **Desenvolvimento (HTTPS):** `https://localhost:7189/Service.asmx?wsdl`
*   **Desenvolvimento (HTTP):** `http://localhost:5277/Service.asmx?wsdl`

## 🤝 Como Contribuir

Contribuições são sempre bem-vindas! Se você tiver sugestões, relatar bugs ou quiser implementar novas funcionalidades, sinta-se à vontade para:

1.  Fazer um fork do repositório.
2.  Criar uma branch para sua feature (`git checkout -b feature/minha-feature`).
3.  Realizar suas alterações e fazer commit (`git commit -m 'feat: Adiciona minha feature'`).
4.  Fazer push para a branch (`git push origin feature/minha-feature`).
5.  Abrir um Pull Request.

Consulte a seção de [Issues](https://github.com/DanielMarinhoFerreira/ServiceWebApp/issues) para ver as tarefas abertas ou relatar novos problemas.
Para enviar suas contribuições, abra um [Pull Request](https://github.com/DanielMarinhoFerreira/ServiceWebApp/pulls).

## 📜 Licença

Este projeto não possui uma licença explicitamente definida nos arquivos fornecidos. Por favor, entre em contato com os autores para mais informações sobre os termos de uso e distribuição.

## 👥 Autores/Contato

Desenvolvido por Daniel Marinho Ferreira.
