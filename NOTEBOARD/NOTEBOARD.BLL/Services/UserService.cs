using NOTEBOARD.DAL.Repositories;
using NOTEBOARD.Model.Entities;
using NOTEBOARD.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.BLL.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }

        public bool Insert(User user)
        {
            if (string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName))
            {
                throw new Exception("FirstName ve LastName bilgileri boş geçilemez");
            }
            //userName unique mi ???
            Password firstPassword = user.Passwords.FirstOrDefault();
            if (firstPassword == null)
            {
                throw new Exception("Password datası boş geçilemez");
            }
            user.CreatedDate = DateTime.Now;
            user.Passwords.FirstOrDefault().CreatedDate = DateTime.Now;
            user.IsActive = false;
            user.UserType = UserType.Standard;
            return userRepository.Insert(user);
        }

        public User CheckLogin(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Login bilgileri boş geçilemez");
            }
            return userRepository.CheckLogin(userName, password);
        }

        public void UserActived(User user)
        {
            CheckUserID(user);
            userRepository.UserActived(user);
        }

        private void CheckUserID(User user)
        {
            if (user.ID == 0)
            {
                throw new Exception("User Id boş geçilemez");
            }
        }

        public void UserActived(int id)
        {
            User user = userRepository.GetUserById(id);
            CheckUserID(user);
            userRepository.UserActived(user);
        }

        public List<User> GetPasiveUser() //Aktif olmayan kullanıcılar.
        {
            return userRepository.GetPasiveUser();
        }
    }
}
