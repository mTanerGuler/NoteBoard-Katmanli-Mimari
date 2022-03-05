
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
    class NoteConfiguration : EntityTypeConfiguration<Note>
    {
        public NoteConfiguration()
        {
            //modelBuilder.Entity<Note>()
            Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Content)
                .IsRequired();

            Property(a => a.Title)
            .IsRequired()
            .HasMaxLength(100);

           
        }
    }
}
