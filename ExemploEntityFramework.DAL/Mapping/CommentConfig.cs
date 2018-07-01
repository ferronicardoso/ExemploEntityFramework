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
    internal class CommentConfig : EntityTypeConfiguration<Comment>
    {
        public CommentConfig()
        {
            this.ToTable("Comment");

            this.HasKey(t => t.CommentId);
            this.Property(t => t.CommentId).HasColumnName("CommentId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.UserEmail).HasColumnName("UserEmail");
            this.Property(t => t.DateTimePublish).HasColumnName("DateTimePublish");
        }
    }
}
