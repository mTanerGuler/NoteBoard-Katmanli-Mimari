using NOTEBOARD.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.DAL.Repositories
{
    public class PasswordRepository
    {
        NoteBoardDbContext context;
        public PasswordRepository()
        {
            context = new NoteBoardDbContext();
        }

        //son üç password'ten birimi ??


        public List<Password> GetLastThreePassword(int userID)
        {
            return context.Passwords.Where(a => a.UserID == userID).OrderByDescending(a => a.CreatedDate).Take(3).ToList();
        }


        //password ekle
        public bool Insert(Password password)
        {
            //ikinci veya üçünkü ekleme 
            context.Passwords.Add(password);
            return context.SaveChanges() > 0;
        }

        public Password GetActivePassword(int userID)
        {
            return context.Passwords.Where(a => a.UserID == userID).OrderByDescending(a => a.CreatedDate).FirstOrDefault();

        }
    }
}
