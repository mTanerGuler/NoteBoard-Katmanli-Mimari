using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.Model.Entities
{
    public class Password : BaseEntity
    {
        public string Text { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
