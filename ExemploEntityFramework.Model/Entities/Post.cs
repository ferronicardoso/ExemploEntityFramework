using ExemploEntityFramework.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Model.Entities
{
    public class Post : PostBase
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public virtual Author Author { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
