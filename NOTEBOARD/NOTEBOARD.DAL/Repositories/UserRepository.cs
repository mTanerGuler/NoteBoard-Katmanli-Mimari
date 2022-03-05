using NOTEBOARD.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.DAL.Repositories
{
    public class UserRepository
    {
        NoteBoardDbContext context;
        public UserRepository()
        {
            context = new NoteBoardDbContext();
        }

        //user kayıt olacak
        public bool Insert(User user)
        {
            context.Users.Add(user);
            //TODO : Password ekleme işlemini yönet 
            return context.SaveChanges() > 0;
        }

        //user login olacak
        public User CheckLogin(string userName, string password)
        {
            User user = context.Users.Where(a => a.UserName == userName).SingleOrDefault();
            if (user != null)
            {
                Password userPassword = user.Passwords.Where(a => a.UserID == user.ID).OrderByDescending(a => a.CreatedDate).FirstOrDefault();
                if (userPassword != null && userPassword.Text == password)
                {
                    return user;
                }
            }
            return null;
        }
        //user aktifleşecek
        public void UserActived(User user)
        {
            User activedUser = context.Users.SingleOrDefault(a => a.ID == user.ID);
            activedUser.IsActive = true;
            context.SaveChanges();
        }

        public User GetUserById(int userId)
        {
            return context.Users.SingleOrDefault(a => a.ID == userId);
        } 

        public List<User> GetPasiveUser() //Aktif olmayan kullanıcılar.
        {
            return context.Users.Where(a => !a.IsActive).ToList();
        }
    }
}
