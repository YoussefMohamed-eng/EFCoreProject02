using EFCoreProject02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject02.Configurations
{
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(
           EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.BadgeNumber)
                   .IsUnique();

            builder.HasOne(x => x.Attendee)
                   .WithOne(x => x.Badge)
                   .HasForeignKey<Badge>(
                       x => x.AttendeeId);
        }
    }
}
