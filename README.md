# EFCore.Transactions

This is a .NET Core 8 application demonstrating the use of Entity Framework Core for managing database transactions with a code-first approach.

## Project Structure

- **Controllers**: Contains the controllers that handle incoming requests and return responses.
  - `TransactionController.cs`: Manages requests related to database transactions.

- **Data**: Contains the database context and migration files.
  - `ApplicationDbContext.cs`: Defines the database context for the application, including transaction management.
  - `Migrations`: Contains migration files for managing database schema changes.

- **Models**: Contains the data models used in the application.
  - `TransactionModel.cs`: Represents a data model for transactions in the application.

- **Services**: Contains the business logic and service classes.
  - `TransactionService.cs`: Implements the logic for handling database transactions.

- **Configuration Files**: 
  - `appsettings.json`: General configuration settings for the application.
  - `appsettings.Development.json`: Configuration settings for the development environment.

- **Program.cs**: The entry point of the application.

- **Tests**: Contains unit tests for the application.
  - `TransactionServiceTests.cs`: Unit tests for the TransactionService class.

## Setup Instructions

1. Clone the repository.
2. Navigate to the project directory.
3. Restore the dependencies using the command:
   ```
   dotnet restore
   ```
4. Update the connection string in `appsettings.json` or `appsettings.Development.json` as needed.
5. Apply the migrations to the database using the command:
   ```
   dotnet ef database update
   ```
6. Run the application using the command:
   ```
   dotnet run
   ```

## Usage

Once the application is running, navigate to `http://localhost:5000` to interact with the transaction management endpoints. You can modify the controllers, models, and services as needed to extend the functionality of the application.

## Testing

Run the tests using the command:
```
dotnet test
```

This will execute the unit tests defined in the `EFCore.Transactions.Tests` project.


### Made with Copilot --> Full of bugs and no sense atm
