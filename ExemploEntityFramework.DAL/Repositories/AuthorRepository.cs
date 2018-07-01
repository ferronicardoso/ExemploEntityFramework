using ExemploEntityFramework.DAL.Repositories.Base;
using ExemploEntityFramework.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.DAL.Repositories
{
    public class AuthorRepository : GenericRepository<Author>
    {
        public AuthorRepository(ApplicationContext model) 
            : base(model)
        {
        }
    }
}
