﻿using ExemploEntityFramework.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Model.Entities
{
    public class Comment : CommentBase
    {
        public virtual Post Post { get; set; }
    }
}
