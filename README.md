# CRUD em modo console

- Essa aplicação console simula o CRUD (Create, Read, Update, Delete) de produtos agrícolas.
- Linguagens utilizadas: C# e Transact-SQL (para criação do banco de dados).
## Como utilizar
1. Clone o repositório para a sua máquina.
2. Necessário .NET Framework 4.8.
3. É necessário realizar a conexão com o seu banco de dados (Microsoft SQL Server), para isso acesse o arquivo [App.config](https://github.com/hparizani/CRUD-CSharp-Console/blob/main/console-crud/App.config) e passe o endereço de conexão do seu banco para a tag `conectionStrings`.
4. Após isso, altere a linha 22  da classe [Product.cs](https://github.com/hparizani/CRUD-CSharp-Console/blob/main/console-crud/Product.cs) com o nome do seu servidor `connectionStrings = ConfigurationManager.ConnectionStrings["nome_do_seu_servidor"].ConnectionString;`
5. Crie o seu banco e sua tabela, ou acesse [V1__product.sql](https://github.com/hparizani/console-crud/blob/main/V1__product.sql) e copie o script e execute no seu banco de dados.
6. Após fazer a alteração da `connectionString` dê um build no projeto gerando o novo arquivo `.EXE` com as suas alterações.
7. Execute o programa.
