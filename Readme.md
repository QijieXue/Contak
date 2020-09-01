This are general steps to create Web API with dotnet core:
1. Install Visual Studio Code, and install the C# extension (`C# for visual studio code`).
1. Create a new project with CLI `dotnet new webapi -n Contak`
1. Open the project in Visual Studio Code with CLI `code -r Contak`
1. Create a model class *Contact* in Models folder.
1. Create a repository interface *IContakRepo* in Data folder.
    ```
    GetAllContacts();
    GetContactById(int Id);
    ```
1. Create a mock repository *MockContakRepo* in Data folder to implement the interface.
1. Create a *ContactsController* class in Controllers folder.
1. Use Dependency injection in *ContactsController* 
    ```
        private readonly IContakRepo _repository;

        public ContactsController(IContakRepo repository)
        {
            _repository = repository;
        }
    ```

    And in `Startup` class, add this code in `ConfigureServices`:
    ```
    services.AddScoped<IContakRepo, MockContakRepo>();
    ```
1. Update appsettings.json for the database connection.
1. Add references in terminal
    ```
    dotnet add package Microsoft.EntityFrameworkCore 
    dotnet add package Microsoft.EntityFrameworkCore.Design 
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer 
    ```
1. Migrate the model
    ```
    dotnet ef migrations add InitialMigration
    ```
1. Update the migrations to database
    ```
    dotnet ef database update
    ```
1. Create a SqlContakRepo in Data folder
1. Create ContakContext in Data folder
1. Switch to SqlContakRepo in Startup file
    ```
    services.AddScoped<IContakRepo, SqlContakRepo>();
    ```
1. Use Dtos to decompose the data and model.