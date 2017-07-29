using SamuraiAppCore.Data;
using SamuraiAppCore.Domains;
using System;

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
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }
    }
}