using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Model.Entities.Base
{
    public class PostBase
    {
        public virtual int PostId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string Content { get; set; }
        public virtual int StatusId { get; set; }
        public virtual int AuthorId { get; set; }
        public virtual DateTime DateTimePublish { get; set; }
    }
}
