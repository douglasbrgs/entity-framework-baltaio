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
            using var context = new BlogDataContext();

            // var user = new User
            // {
            //     Name = "Douglas Borges",
            //     Slug = "douglasborges",
            //     Email = "douglas@borges.com",
            //     Bio = "Mestre Eng Computação",
            //     Image = "https://borges.com",
            //     PasswordHash = "12334543543"
            // };

            // var category = new Category
            // {
            //     Name = "Backend",
            //     Slug = "Backend"
            // };

            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello world</p>",
            //     Slug = "comecando-com-ef-core",
            //     Summary = "Neste artigo vamos aprender EF Core",
            //     Title = "Começando com EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now,
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            var posts = context
                .Posts
                .AsNoTracking()
                .Include(x => x.Author)
                .OrderByDescending(x => x.LastUpdateDate)
                .ToList();

            foreach (var post in posts)
            {
                Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");
            }
        }
    }
}
