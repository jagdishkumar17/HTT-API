﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HTT.Models;
using HTT.Enums;

namespace HTT.Repository.SeedData
{
    /// <summary>
    /// confirgure Symptom data
    /// </summary>
    public class SymptomConfiguration : IEntityTypeConfiguration<Symptom>
    {
        /// <summary>
        /// configure master data
        /// </summary>
        public void Configure(EntityTypeBuilder<Symptom> builder)
        {
            builder.HasData
                 (
                    new Symptom
                    {
                        Id = 1,
                        Name = "Fever",
                        Order = 1,
                        Status = EntityStatus.Active

                    },
                     new Symptom
                     {
                         Id = 2,
                         Name = "Shortness Of Breath",
                         Order = 2,
                         Status = EntityStatus.Active
                     },
                      new Symptom
                      {
                          Id = 3,
                          Name = "Dry Cough",
                          Order = 3,
                          Status = EntityStatus.Active
                      },
                       new Symptom
                       {
                           Id = 4,
                           Name = "Running Nose",
                           Order = 4,
                           Status = EntityStatus.Active
                       },
                        new Symptom
                        {
                            Id = 5,
                            Name = "Sore Throat",
                            Order = 5,
                            Status = EntityStatus.Active
                        }

                 );
        }
    }
}
