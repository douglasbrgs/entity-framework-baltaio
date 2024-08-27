using System;
using System.Linq;
using Blog.Data;
using Blog.Models;

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
            }
        }
    }
}
