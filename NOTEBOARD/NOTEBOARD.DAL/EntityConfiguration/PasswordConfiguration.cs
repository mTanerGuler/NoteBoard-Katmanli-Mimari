using NOTEBOARD.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.DAL.EntityConfiguration
{
    class PasswordConfiguration : EntityTypeConfiguration<Password>
    {
        public PasswordConfiguration()
        {
            Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Text)
                .IsRequired()
                .HasMaxLength(20);


        }
    }
}
