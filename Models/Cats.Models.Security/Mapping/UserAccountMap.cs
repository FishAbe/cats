﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Models.Security.Mapping
{
    public class UserAccountMap : EntityTypeConfiguration<UserAccount>
    {
        public UserAccountMap()
        {
            // Primary Key
            this.HasKey(t => t.UserAccountId);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Password)
                .IsRequired();

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.GrandFatherName)
                .HasMaxLength(200);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.LanguageCode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Calendar)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Keyboard)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.PreferedWeightMeasurment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.DefaultTheme)
                .IsRequired()
                .HasMaxLength(50);


            // Table & Column Mappings
            this.ToTable("UserAccount");
            this.Property(t => t.UserAccountId).HasColumnName("UserAccountId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Disabled).HasColumnName("Disabled");
            this.Property(t => t.LoggedIn).HasColumnName("LoggedIn");
            this.Property(t => t.LogginDate).HasColumnName("LogginDate");
            this.Property(t => t.LogOutDate).HasColumnName("LogOutDate");
            this.Property(t => t.FailedAttempts).HasColumnName("FailedAttempts");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.GrandFatherName).HasColumnName("GrandFatherName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.CaseTeam).HasColumnName("CaseTeam");
            this.Property(t => t.LanguageCode).HasColumnName("LanguageCode");
            this.Property(t => t.Calendar).HasColumnName("Calendar");
            this.Property(t => t.Keyboard).HasColumnName("Keyboard");
            this.Property(t => t.PreferedWeightMeasurment).HasColumnName("PreferedWeightMeasurment");
            this.Property(t => t.DefaultTheme).HasColumnName("DefaultTheme");

        }
    }
}
