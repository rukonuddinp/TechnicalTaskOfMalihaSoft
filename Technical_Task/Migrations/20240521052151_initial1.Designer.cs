﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Technical_Task.Context;

#nullable disable

namespace Technical_Task.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240521052151_initial1")]
    partial class initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Technical_Task.Models.Step1", b =>
                {
                    b.Property<int>("Step1Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Step1Id"), 1L, 1);

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<bool?>("IsChecked")
                        .HasColumnType("bit");

                    b.Property<int>("Step1Value")
                        .HasColumnType("int");

                    b.HasKey("Step1Id");

                    b.ToTable("Step1s");
                });

            modelBuilder.Entity("Technical_Task.Models.Step2", b =>
                {
                    b.Property<int>("Step2Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Step2Id"), 1L, 1);

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<bool?>("IsChecked")
                        .HasColumnType("bit");

                    b.Property<int>("Step2Value")
                        .HasColumnType("int");

                    b.HasKey("Step2Id");

                    b.ToTable("Step2s");
                });
#pragma warning restore 612, 618
        }
    }
}
