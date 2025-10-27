# ServiceWebApp
Uma aplicação web ASP.NET Core MVC para gestão de usuários via serviço SOAP.

![License](https://img.shields.io/github/license/DanielMarinhoFerreira/ServiceWebApp?style=for-the-badge) ![GitHub issues](https://img.shields.io/github/issues/DanielMarinhoFerreira/ServiceWebApp?style=for-the-badge) ![Top Language](https://img.shields.io/github/languages/top/DanielMarinhoFerreira/ServiceWebApp?style=for-the-badge) ![Code Size](https://img.shields.io/github/languages/code-size/DanielMarinhoFerreira/ServiceWebApp?style=for-the-badge)

## 📝 Descrição Detalhada

O **ServiceWebApp** é um projeto de aplicação web desenvolvido em ASP.NET Core 8.0 (MVC) que atua como um cliente para um serviço web SOAP externo. Sua principal finalidade é demonstrar a integração e o consumo de um serviço SOAP para realizar operações de gerenciamento de usuários, incluindo criação, leitura, atualização e exclusão (CRUD).

A aplicação fornece uma interface de usuário responsiva e moderna, construída com o Material Dashboard, permitindo uma interação intuitiva com os dados dos usuários. O projeto é configurado para se comunicar com um endpoint SOAP específico, que expõe os métodos para manipulação dos registros de usuários.

## 🚀 Acesso ao Projeto

Este projeto está disponível no GitHub. Você pode acessar o repositório para explorar o código:

[Veja o repositório no GitHub](https://github.com/DanielMarinhoFerreira/ServiceWebApp)

## ✨ Funcionalidades Principais

*   **Gestão de Usuários (CRUD):** Permite criar, ler (listar e detalhar), atualizar e excluir registros de usuários através de um serviço SOAP.
*   **Consumo de Serviço SOAP:** Integração com um serviço web SOAP externo para todas as operações de dados.
*   **Interface Moderna:** Utiliza o Material Dashboard para uma experiência de usuário agradável e responsiva.
*   **Validação de Formulários:** Implementa validações para garantir a integridade dos dados inseridos.
*   **Tabelas Dinâmicas:** Gerenciamento e exibição de dados em tabelas interativas (via DataTables).
*   **Máscaras de Input:** Facilita a entrada de dados em campos específicos com máscaras (via jQuery Mask).
  
## 🛠️ Tecnologias Utilizadas (Tech Stack)

O projeto foi desenvolvido utilizando as seguintes tecnologias:

*   **Backend:**
    *   **ASP.NET Core 8.0 (MVC):** Framework para construção da aplicação web.
    *   **C#:** Linguagem de programação principal.
    *   **SOAP Web Services:** Utilização de `System.ServiceModel` para consumir o serviço SOAP. [Veja o repositório no GitHub](https://github.com/DanielMarinhoFerreira/ServiceSoap)

*   **Frontend:**
    *   **HTML5, CSS3, JavaScript:** Fundamentos da web.
    *   **Material Dashboard:** Framework de UI para um design moderno e responsivo.
    *   **Bootstrap:** Framework CSS para componentes e layout.
    *   **jQuery:** Biblioteca JavaScript para manipulação do DOM e eventos.
    *   **DataTables:** Plugin jQuery para tabelas interativas.
    *   **Perfect Scrollbar:** Plugin para scrollbars personalizadas.
    *   **jQuery Mask Plugin:** Plugin para máscaras de entrada em campos de formulário.

## 📂 Estrutura do Projeto

A estrutura principal do projeto é organizada da seguinte forma:

```
ServiceWebApp/
├── Controllers/            # Controladores MVC que gerenciam a lógica da aplicação
│   ├── HomeController.cs   # Lógica para a página inicial e exclusão de usuários
│   └── UsuarioController.cs# Lógica para cadastro e edição de usuários
├── Connected Services/     # Configuração e código gerado para o cliente SOAP
│   └── ServiceClient/
│       ├── ConnectedService.json # Detalhes da conexão com o serviço SOAP
│       └── Reference.cs    # Código proxy gerado para o serviço SOAP
├── ViewModels/             # Modelos de visualização (DTOs) para passar dados às Views
│   └── ViewUsuarioDto.cs
├── Views/                  # Arquivos de visualização (Razor Views)
│   ├── Home/               # Views para o HomeController
│   ├── Shared/             # Views compartilhadas (layout, validação)
│   └── Usuario/            # Views para o UsuarioController (Cadastro, Edição)
├── wwwroot/                # Arquivos estáticos (CSS, JavaScript, imagens)
│   ├── css/                # Estilos CSS (Material Dashboard, site.css)
│   ├── js/                 # Scripts JavaScript (lógica, plugins, Material Dashboard)
│   └── lib/                # Bibliotecas de terceiros (Bootstrap, jQuery)
├── Program.cs              # Ponto de entrada da aplicação e configuração do pipeline
├── ServiceWebApp.csproj    # Arquivo de projeto .NET
└── appsettings.json        # Configurações da aplicação
```

## 📋 Pré-requisitos

Para executar este projeto, você precisará ter instalado:
* Acessar repositorio e verificar como inicializar o Service SOAP:  [Veja o repositório no GitHub](https://github.com/DanielMarinhoFerreira/ServiceSoap)


*   **[.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)**
*   Um ambiente de desenvolvimento como **[Visual Studio](https://visualstudio.microsoft.com/)** ou **[Visual Studio Code](https://code.visualstudio.com/)** com as extensões de C# e ASP.NET Core.
*   Acesso ao serviço SOAP externo no endereço `http://dyolog.ddns.net:9000/Service.asmx`. A aplicação está configurada para se comunicar com este endpoint.

## 🚀 Guia de Início Rápido

Siga estas etapas para configurar e executar o projeto localmente:

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/DanielMarinhoFerreira/ServiceWebApp
    ```
2.  **Navegue até o diretório do projeto:**
    ```bash
    cd ServiceWebApp/ServiceWeApp
    ```
      
3.  **Restaurar Pacotes NuGet:**
    O Visual Studio geralmente restaura os pacotes automaticamente. Se não, você pode fazer isso via terminal:
    ```bash
    dotnet restore
    ```

4.  **Compilar o Projeto:**
    ```bash
    dotnet build
    ```

5.  **Executar a Aplicação:**
    ```bash
    dotnet run
    ```
    A aplicação será iniciada e estará acessível em `https://localhost:Porta_disponivel` ou `http://localhost:Porta_disponivel` (conforme configurado em `Properties/launchSettings.json`).

## ⚙️ Uso (Exemplos)

Após iniciar a aplicação, você pode:

1.  **Visualizar Usuários:** A página inicial (`/Home/Index`) listará todos os usuários existentes, obtidos do serviço SOAP.
2.  **Cadastrar Novo Usuário:** Navegue para a página de cadastro (`/Usuario/Cadastro`) para adicionar um novo usuário ao sistema.
3.  **Editar Usuário:** Na lista de usuários, clique em um usuário para acessar a página de edição (`/Usuario/EditableUsuario/{id}`).
4.  **Excluir Usuário:** Na lista de usuários, utilize a opção de exclusão para remover um registro.


## 👥 Autores/Contato

Desenvolvido por Daniel Marinho Ferreira.
