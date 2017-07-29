using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SamuraiAppCore.Data;

namespace SamuraiAppCore.Data.Migrations
{
    [DbContext(typeof(SamuraiDataContext))]
    [Migration("20170729125924_ManyToMany")]
    partial class ManyToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("SamuraiAppCore.Domains.SamuraiButtle", b =>
                {
                    b.Property<int>("ButtleId");

                    b.Property<int>("SamuraiId");

                    b.HasKey("ButtleId", "SamuraiId");

                    b.HasIndex("SamuraiId");

                    b.ToTable("SamuraiButtles");
                });

            modelBuilder.Entity("SamuraiAppCore.Domains.Quote", b =>
                {
                    b.HasOne("SamuraiAppCore.Domains.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SamuraiAppCore.Domains.SamuraiButtle", b =>
                {
                    b.HasOne("SamuraiAppCore.Domains.Buttle", "Buttle")
                        .WithMany()
                        .HasForeignKey("ButtleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SamuraiAppCore.Domains.Samurai", "Samurai")
                        .WithMany()
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
