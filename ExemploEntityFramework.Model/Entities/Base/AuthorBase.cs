﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Model.Entities.Base
{
    public class AuthorBase
    {
        public virtual int AuthorId { get; set; }
        public virtual string Name { get; set; }
    }
}
