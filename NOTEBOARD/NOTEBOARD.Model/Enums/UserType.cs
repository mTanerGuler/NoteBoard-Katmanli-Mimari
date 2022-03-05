using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.Model.Enums
{
    public enum UserType
    {
        //Enumları database'e kayıt ediyorsanız 1den başlatmak best practicedir
        Admin = 0,
        Standard = 1
    }
}
