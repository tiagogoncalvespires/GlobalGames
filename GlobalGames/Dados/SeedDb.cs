using GlobalGames.Dados.Entidades;
using GlobalGames.Helpers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGames.Dados
{
    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private readonly Random random;
        

        public SeedDb(DataContext context,IUserHelper userHelper )
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmailAsync("pirestiago2001@gmail.com");
            if(user == null)
            {
                user = new User
                {
                    FirstName = "Tiago",
                    LastName = "Pires",
                    Email = "pirestiago2001@gmail.com",
                    UserName = "pirestiago2001@gmail.com",
                    PhoneNumber = "21234556"
                };

                var result = await this.userHelper.AddUserAsync(user, "123456");
                if(result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

            if (!this.context.Inscricoes.Any())
            {
                this.AddInscricoes("Alberto Correia", user);
                this.AddInscricoes("Ricardo Corresma", user);
                this.AddInscricoes("Gonçalo Gonçalves", user);
                this.AddInscricoes("Pedro Lima", user);
                this.AddInscricoes("Alves Pereira", user);
                await this.context.SaveChangesAsync();
            }
        }

        private void AddInscricoes(string name, User user)
        {
            this.context.Inscricoes.Add(new Inscricoes
            {
                Nome = name,
                Apelido = name,
                CC = this.random.Next(30000000),
                User = user
            });
        }
    }
}
