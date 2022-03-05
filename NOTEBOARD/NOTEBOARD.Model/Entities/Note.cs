using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.Model.Entities
{
    public class Note : BaseEntity
    {
       
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; } //kullanıcı notunu silerse ben notu silmek istemiyorum o notu pasife düşereceğim.
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
