﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4Assignment_ZM.Models;

namespace Mission4Assignment_ZM.Migrations
{
    [DbContext(typeof(MovieAppContext))]
    partial class MovieAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4Assignment_ZM.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("Mission4Assignment_ZM.Models.MovieAdd", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Title");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            Title = "Inception",
                            CategoryId = 1,
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "",
                            Notes = "Best Movie EVER!",
                            Rating = "PG-13",
                            Year = 2010
                        },
                        new
                        {
                            Title = "Rudy",
                            CategoryId = 2,
                            Director = "David Anspaugh",
                            Edited = false,
                            LentTo = "",
                            Notes = "Gave me chills",
                            Rating = "PG-13",
                            Year = 1993
                        },
                        new
                        {
                            Title = "The Lion King",
                            CategoryId = 3,
                            Director = "Roger Allers",
                            Edited = false,
                            LentTo = "",
                            Notes = "SO inspirational",
                            Rating = "G",
                            Year = 1994
                        });
                });

            modelBuilder.Entity("Mission4Assignment_ZM.Models.MovieAdd", b =>
                {
                    b.HasOne("Mission4Assignment_ZM.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
