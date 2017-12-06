Installing the command line tools:
dotnet restore

Creating a migration:
dotnet ef migration add <MIGRATION_NAME>

Applying a migration:
dotnet ef database update -c <CONTEXT_NAME> <MIGRATION_NAME>
