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

            context.Users.Add(new User
            {
                Bio = "Mestre em Engenharia de Computação",
                Email = "douglasborges19@gmail.com",
                Image = "https://borges.br",
                Name = "Douglas Borges",
                PasswordHash = "1234",
                Slug = "douglas-borges",
                Github = "douglasbrgs"
            });

            context.SaveChanges();

            // var user = context.Users.FirstOrDefault();
            // var category = new Category
            // {
            //     Name = "Backend",
            //     Slug = "backend"
            // };
            // var post = new Post
            // {
            //     Author = user,
            //     Body = "Meu artigo",
            //     Category = category,
            //     CreateDate = System.DateTime.Now,
            //     Slug = "meu-artigo",
            //     Summary = "Nesse artigo vamos conferir...",
            //     Title = "Meu artigo"
            // };
            // context.Posts.Add(post);
            // context.SaveChanges();
        }
    }
}
