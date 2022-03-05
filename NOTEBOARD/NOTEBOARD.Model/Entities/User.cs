
using NOTEBOARD.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.Model.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Passwords = new HashSet<Password>();
            Notes = new HashSet<Note>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public UserType UserType { get; set; } //kulllanıcı admin mi user mi ?
        public bool IsActive { get; set; } //admin tarafından onaylandı mı ? onaylanmadı mı ?
        public virtual ICollection<Password> Passwords { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
