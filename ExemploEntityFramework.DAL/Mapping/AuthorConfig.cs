using ExemploEntityFramework.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.DAL.Mapping
{
    public class AuthorConfig : EntityTypeConfiguration<Author>
    {
        public AuthorConfig()
        {
            this.ToTable("Author");

            this.HasKey(t => t.AuthorId);
            this.Property(t => t.AuthorId).HasColumnName("AuthorId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
