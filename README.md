# edisonbrito-API.REST.FCamara
API FCamara - Geração de token e lista de produtos

O Projeto foi feito em Visual Studio 2017 e SQL Server
Requesitos:
    SQL Server
    Visual Studio 2017 with .NET Core Tools

Passos para funcionar.

    1. Crie uma base de dados no SQL Server (ou deixei o entity criar para você)
    
    2. Atualize a connection string em appsettings.json em FCamara.API
    
    3. Atualize o arquivo Runtime.cs em -> Domain -> FCamara.Shared -> Runtime.cs
    
    4. Faça um Build na solution.
    
    5. Abra Package Manager Console Window e coloque "Update-Database" depois "Enter", faça isso na camada FCamara.Infra
    
    6. Setar aplicação para iniciar FCamara.API
    
    Se ncessário fazer o passo 7. Abra Package Manager Console Window e coloque "fluentvalidator" em todas as camadas.
    
 ##Technologies implemented:

    ASP.NET Core 1.1 (with .NET Core)
    ASP.NET WEB API
    Entity Framework 6
    FluentValidator
    .NET Core Native DI
    Unit of Work
    Repository and Generic Repository
    Unit Test
    
##Architecture:

    Clean Code
    Domain Driven Design (usando alguns conceitos)
    Domain Notification
    
 Sistema já executa SEED dos dados.
 
 Dúvidas na execução do código pode entar em contato: edijs.britto@gmail.com
   
    


    
    
