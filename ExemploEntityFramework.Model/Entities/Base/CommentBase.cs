using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Model.Entities.Base
{
    public class CommentBase
    {
        public virtual int CommentId { get; set; }
        public virtual int PostId { get; set; }
        public virtual string Content { get; set; }
        public virtual string UserName { get; set; }
        public virtual string UserEmail { get; set; }
        public virtual DateTime DateTimePublish { get; set; }
    }
}
