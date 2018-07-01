using ExemploEntityFramework.DAL.Repositories.Base;
using ExemploEntityFramework.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.DAL.Repositories
{
    public class PostRepository : GenericRepository<Post>
    {
        public PostRepository(ApplicationContext model) 
            : base(model)
        {
        }
    }
}
