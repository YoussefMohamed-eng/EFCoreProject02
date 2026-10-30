using EFCoreProject02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject02.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(
           EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Organizer)
                   .WithMany(x => x.Events)
                   .HasForeignKey(x => x.OrganizerId);
        }
    }
}
