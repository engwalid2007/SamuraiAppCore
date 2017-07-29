using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SamuraiAppCore.Data;

namespace SamuraiAppCore.Data.Migrations
{
    [DbContext(typeof(SamuraiDataContext))]
    partial class SamuraiDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SamuraiAppCore.Domains.Buttle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Buttles");
                });

            modelBuilder.Entity("SamuraiAppCore.Domains.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("SamuraiId");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("SamuraiAppCore.Domains.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ButtleId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ButtleId");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("SamuraiAppCore.Domains.Quote", b =>
                {
                    b.HasOne("SamuraiAppCore.Domains.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SamuraiAppCore.Domains.Samurai", b =>
                {
                    b.HasOne("SamuraiAppCore.Domains.Buttle")
                        .WithMany("Samurais")
                        .HasForeignKey("ButtleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
