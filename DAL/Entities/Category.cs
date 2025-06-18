using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Category : BaseModel
    {
        public string Name { get; set; }

        // Navigation Property
        public virtual ICollection<Product> Products { get; set; }
    }
}
