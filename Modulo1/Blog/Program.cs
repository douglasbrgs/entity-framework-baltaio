using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                // CREATE
                // var tag = new Tag
                // {
                //     Name = "ASP.NET",
                //     Slug = "aspnet"
                // };

                // var tag = new Tag
                // {
                //     Name = ".NET",
                //     Slug = "dotnet"
                // };

                // context.Tags.Add(tag);
                // context.SaveChanges();

                // UPDATE
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 5);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";

                // context.Update(tag);
                // context.SaveChanges();

                // DELETE
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 5);

                // context.Remove(tag);
                // context.SaveChanges();

                // TOLIST (Executa a query)
                // Deve ser colocado sempre no final da query para não prejudicar a perfomance
                // var tags = context
                //     .Tags
                //     .AsNoTracking()
                //     .ToList();

                // foreach (var tag in tags)
                // {
                //     Console.WriteLine(tag.Name);
                // }

                // AsNoTracking: ganho de performance na leitura, usar APENAS para visualização dos dados

                var tag = context
                    .Tags
                    .AsNoTracking()
                    .FirstOrDefault(x => x.Id == 6);

                Console.WriteLine(tag?.Name);

                // Single/SingleOrDefault: da erro se tiver mais de um erro com o mesmo Id
            }
        }
    }
}
