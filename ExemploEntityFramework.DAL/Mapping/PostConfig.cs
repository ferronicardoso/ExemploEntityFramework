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
    public class PostConfig : EntityTypeConfiguration<Post>
    {
        public PostConfig()
        {
            this.ToTable("Post");

            this.HasKey(t => t.PostId);
            this.Property(t => t.PostId).HasColumnName("PostId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
            this.Property(t => t.AuthorId).HasColumnName("AuthorId");
            this.Property(t => t.DateTimePublish).HasColumnName("DateTimePublish");
        }
    }
}
