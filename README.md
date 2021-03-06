![Pizzaritto Logo](https://github.com/NataliaZhydeikina/Pizzerito/blob/main/Pizzerito/Pizzerito/wwwroot/images/PizzarittoLogo2.png)  
# Pizzerito

This project was completed using my knowledge of ASP.NET Core Razor pages with MVC. I liked doing the Repository Pattern
with other projects so much I had to create a new one to solidify my understanding. This application is a typical pizza ordering system
that has different users such as manager, cook, driver, and customer roles. Each screen facilitates the specific user that is logged in. 

Website is now up! 
Azure Deployed [HERE](https://pizzerito20210403235840.azurewebsites.net/Customer/Home).   

ASP.NET Core 3.1 Razor Pages With MVC Continuation Demo 

- CRUD Operations in Razor Pages
- ASP Handelers
- Repository Pattern (unitOfWork)
- API Controllers using MVC  
- Server/Client Validation
- DataBase Migrations (code first approach)
- Multi-Project structure (Easier to read and understand) 
- Table creating/sorting on load
- Image Uploading
- Creating Multiple Users with different Roles
  - Manager Role
  - Front Desk Cashier
  - Pizza maker  
  - Online Customer Ordering
- User Authorization and account Lock 
- SSO Using Facebook and Microsoft
- Shopping cart functionality with session loading 
- DOM manipulation with JQuery
- Ordering System with Order Details and Management
- Using Stripe payment system
- UI designed with Bootsrap 4 and CSS  

## File Structure:
- Pizzerito => Main project with wwwroot, controllers, and Razor Pages
- Pizzerito.DataAccess => 
    - Project to handle data such as Migrations, Repositories, ApplicationDbContext  
- Pizzerito.Models => Project that Holds our blueprints (Models) and View Models
- Pizzerito.Utility => 
    - Project that holds static definitions, email client, and Stripe Ordering


# Instructions For Installing 

**1.**  VS Studio 2019  
**2.** NUGET packages used:  
  - Microsoft.AspNetCore.Authentication.Facebook
  - Microsoft.AspNetCore.Authentication.MicrosoftAccount
  - Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
  - Microsoft.AspNetCore.Identity.UI
  - Microsoft.AspNetCore.Mvc
  - Microsoft.AspNetCore.Mvc.NewtonsoftJson
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools
  - Microsoft.Extensions.Configuration.AzureKeyVault
  - Stripe.net
  
**3.** Using Microsoft SQL and Manger for database   
**4.** Update connectionstring to reflect your local database name  
**5.** Add-migration, update-database to add tables (code first migration)  
**6.** Make any changes you like or help with issues that I find  
**7.** Don't forget to use Azure Vault or local secretes for connection strings and SSO
  
    
    
