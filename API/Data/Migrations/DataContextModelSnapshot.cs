﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<string>("dbstffid")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("dbstffpswd")
                        .HasColumnType("longtext");

                    b.HasKey("dbstffid");

                    b.ToTable("ftstaff");
                });

            modelBuilder.Entity("API.Entities.Keywords", b =>
                {
                    b.Property<int>("KeywordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("dbkeyskilltype")
                        .HasColumnType("longtext");

                    b.Property<string>("dbkeyword")
                        .HasColumnType("longtext");

                    b.HasKey("KeywordId");

                    b.ToTable("ftkeywords");
                });

            modelBuilder.Entity("API.Entities.TiKeyword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("idkeyword")
                        .HasColumnType("int");

                    b.Property<bool>("quickkeyword")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("idkeyword")
                        .IsUnique();

                    b.ToTable("ti_keyword");
                });

            modelBuilder.Entity("API.Entities.TiKeyword", b =>
                {
                    b.HasOne("API.Entities.Keywords", "Keywords")
                        .WithOne("ti_keyword")
                        .HasForeignKey("API.Entities.TiKeyword", "idkeyword")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Keywords");
                });

            modelBuilder.Entity("API.Entities.Keywords", b =>
                {
                    b.Navigation("ti_keyword");
                });
#pragma warning restore 612, 618
        }
    }
}