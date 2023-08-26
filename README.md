# GameExperiment

## .NET CLI

[Documentation](https://learn.microsoft.com/en-us/dotnet/core/tools/)

- Create solution:

```console
dotnet new sln --name mysolution
```

- Create library project:

```console
dotnet new classlib -o StringLibrary
```

- Create API project

```console
dotnet new webapi -o WebApi
```

- Add project to the solution:

```console
dotnet sln add StringLibrary/StringLibrary.csproj
```

- Add project reference:

```console
dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj
```

### Create new Module

```console
    mkdir NewModule
    cd NewModule
    dotnet new sln --name Renuity.CRM.NewModule
    dotnet new classlib -o Renuity.CRM.NewModule.Api
    dotnet sln add Renuity.CRM.NewModule.Api/Renuity.CRM.NewModule.Api.csproj
    dotnet new classlib -o Renuity.CRM.NewModule.Domain
    dotnet sln add Renuity.CRM.NewModule.Domain/Renuity.CRM.NewModule.Domain.csproj
    dotnet new classlib -o Renuity.CRM.NewModule.Services
    dotnet sln add Renuity.CRM.NewModule.Services/Renuity.CRM.NewModule.Services.csproj
    dotnet new classlib -o Renuity.CRM.NewModule.WebApi
    dotnet sln add Renuity.CRM.NewModule.WebApi/Renuity.CRM.NewModule.WebApi.csproj
```
