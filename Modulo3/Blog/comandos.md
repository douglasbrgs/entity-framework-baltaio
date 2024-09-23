1. Instalar EntityFrameworkCore.Design
    * dotnet add package Microsoft.EntityFrameworkCore.Design
2. Instalar dotnet-ef
    * dotnet tool install --global dotnet-ef
3. Criar migração
    * dotnet ef migrations add [NomeDaMigracao]
4. Aplicar migração ao banco
    * dotnet ef database update
5. Gerar script do banco 
    * dotnet ef migrations script -o ./script.sql
