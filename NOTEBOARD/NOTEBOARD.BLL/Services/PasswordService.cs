using NOTEBOARD.DAL.Repositories;
using NOTEBOARD.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.BLL.Services
{
    public class PasswordService
    {
        PasswordRepository passwordRepository;
        public PasswordService()
        {
            passwordRepository = new PasswordRepository();
        }

        public bool CheckLastThreePassword(Password password)
        {
            List<Password> lastPasswords = passwordRepository.GetLastThreePassword(password.UserID);
            foreach (Password item in lastPasswords)
            {
                if (item.Text == password.Text)
                {
                    throw new Exception("Bu şifre son üç şifreden biridir.");
                }
            }
            return true;
        }

        public bool Insert(Password password)
        {
            if (CheckLastThreePassword(password))
            {
                password.CreatedDate = DateTime.Now;
                return passwordRepository.Insert(password);
            }
            return false;
        }

        public Password GetActivePassword(int userID)
        {
            if (userID == 0)
            {
                throw new Exception("parametre geçersiz");
            }
            return passwordRepository.GetActivePassword(userID);
          
        }
    }
}
