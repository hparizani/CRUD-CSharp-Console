# CRUD em modo console

Aplicação de linha de comando que demonstra as operações de CRUD (Create, Read, Update, Delete) para produtos agrícolas.

## Tecnologias

- C# (.NET Framework 4.8)
- Transact-SQL para criação do banco de dados

## Pré-requisitos

- Microsoft SQL Server
- .NET Framework 4.8

## Conectando ao banco de dados

1. Abra `console-crud/App.config`.
2. Substitua o valor da connection string pelo endereço do seu servidor SQL Server. Você pode alterar também o nome utilizado na propriedade `name`:

```xml
<add name="MEU_SERVIDOR" providerName="System.Data.SqlClient" connectionString="Data Source=MEU_SERVIDOR;Initial Catalog=PIM;Integrated Security=True" />
```

3. No arquivo `console-crud/Product.cs` utilize o mesmo nome definido acima ao recuperar a connection string:

```csharp
connectionStrings = ConfigurationManager.ConnectionStrings["MEU_SERVIDOR"].ConnectionString;
```

4. Execute o script `V1__product.sql` para criar a tabela `Product` caso ela ainda não exista.

## Como utilizar

1. Clone este repositório.
2. Ajuste a connection string conforme mostrado na seção anterior.
3. Abra `console-crud.sln` e realize o build do projeto.
4. Rode o executável gerado em `bin/`.
