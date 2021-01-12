# Centrumbiblioteket
---
Centrumbiblioteket ASP.NET Core Web API + EF Core back end, that uses Database code first approach and adds a simple view using MVC that shows late rentals.
---
### Installation
---
##### Prerequisites

* IDE - Visual Studio or VS Code
* Framework - [.NET Core 3.0 or Greater](https://docs.microsoft.com/en-us/ef/)
* Database - SSMS

##### Clone

* Clone this repo to your local machine https://github.com/nidjuru/Centrumbiblioteket.git


##### Setup
* Centrumbiblioteket Database.
    1. In SSMS, create the database and for security reasons create a user and connect it with the database.
    2. In the connection string ""DefaultConnection": "Server=(localdb)\\MSSQLLocalDB; Database=***DataBaseName***; Trusted_Connection=true;User Id=***UserName***; password=***Password***""
    
* Centrumbiblioteket Solution
    1. Open the project and install the Nuget packages if they are not with your solution.
         * Microsoft.EntityFrameworkCore (3.1.10)
    	 * Microsoft.EntityFrameworkCore.Design (3.1.10)
    	 * Microsoft.EntityFrameworkCore.SqlServer (3.1.10)
    	 * Microsoft.AspNetCore.Mvc.NewtonsoftJson (3.1.10)
         * Microsoft.Visualstudio.Web.CodeGeneration.Design (3.1.4)
    2. Project should be fully functional at this point and you should be able to run it and experience the full functionality.
    
    
---
