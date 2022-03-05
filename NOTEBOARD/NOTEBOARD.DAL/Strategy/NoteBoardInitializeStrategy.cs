
using NOTEBOARD.Model.Entities;
using NOTEBOARD.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.DAL.Strategy
{
    class NoteBoardInitializeStrategy : DropCreateDatabaseIfModelChanges<NoteBoardDbContext>
    {
        protected override void Seed(NoteBoardDbContext context)
        {
            User user = new User
            {
                FirstName = "Admin",
                LastName = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true,
                UserName = "admin",
                UserType = UserType.Admin
            };
            user.Passwords.Add(new Password()
            {
                CreatedDate = DateTime.Now,
                Text = "qwerty"
            });
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
