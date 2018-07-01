using ExemploEntityFramework.DAL.Repositories.Base;
using ExemploEntityFramework.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.DAL.Repositories
{
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(ApplicationContext model) 
            : base(model)
        {
        }
    }
}
