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
    public class StatusConfig : EntityTypeConfiguration<Status>
    {
        public StatusConfig()
        {
            this.ToTable("Status");

            this.HasKey(t => t.StatusId);
            this.Property(t => t.StatusId).HasColumnName("StatusId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
