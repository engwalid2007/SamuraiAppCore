using SamuraiAppCore.Data;
using SamuraiAppCore.Domains;
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

namespace UICore
{
    class Program
    {
        static void Main(string[] args)
        {
            Samurai samurai = new Samurai()
            {
                CreationDate = DateTime.Now,
                Name = "New Samurai"
            };
            using (SamuraiDataContext context = new SamuraiDataContext())
            {
                context.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}