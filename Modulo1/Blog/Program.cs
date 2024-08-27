using System;
using System.Linq;
using Blog.Data;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var context = new BlogDataContext();
            context.Categories.ToList();
        }
    }
}
