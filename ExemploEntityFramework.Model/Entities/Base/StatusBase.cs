using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Model.Entities.Base
{
    public class StatusBase
    {
        public virtual int StatusId { get; set; }
        public virtual string Name { get; set; }
    }
}
