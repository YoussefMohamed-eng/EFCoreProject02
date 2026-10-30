using EFCoreProject02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject02.Configurations
{
    public class OrganizerProfileConfiguration :IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(
          EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Organizer)
                   .WithOne(x => x.OrganizerProfile)
                   .HasForeignKey<OrganizerProfile>(
                       x => x.OrganizerId);
        }
    }
}
