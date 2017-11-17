using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Exam.Entities;

namespace Exam.Migrations
{
    [DbContext(typeof(ExamContext))]
    [Migration("20171117085725_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Exam.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Car_Brand");

                    b.Property<string>("Car_Model");

                    b.Property<string>("Color");

                    b.Property<string>("Plate");

                    b.Property<string>("Year");

                    b.HasKey("Id");

                    b.ToTable("Licence_plates");
                });
        }
    }
}
