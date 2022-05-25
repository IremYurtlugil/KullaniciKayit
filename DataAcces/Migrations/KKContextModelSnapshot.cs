﻿// <auto-generated />
using DataAcces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAcces.Migrations
{
    [DbContext(typeof(KKContext))]
    partial class KKContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Concrete.Adres", b =>
                {
                    b.Property<long>("AdresId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdresAcıklama")
                        .IsRequired();

                    b.Property<long>("CariId");

                    b.HasKey("AdresId");

                    b.HasIndex("CariId");

                    b.ToTable("Adres");
                });

            modelBuilder.Entity("Entities.Concrete.Cari", b =>
                {
                    b.Property<long>("CariId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Unvan")
                        .IsRequired();

                    b.HasKey("CariId");

                    b.ToTable("Cari");
                });

            modelBuilder.Entity("Entities.Concrete.Kullanici", b =>
                {
                    b.Property<long>("KullanciId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Password");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("KullanciId");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("Entities.Concrete.Telefon", b =>
                {
                    b.Property<long>("TelefonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CariId");

                    b.Property<string>("TelefonNo")
                        .IsRequired();

                    b.HasKey("TelefonId");

                    b.HasIndex("CariId");

                    b.ToTable("Telefon");
                });

            modelBuilder.Entity("Entities.Concrete.Adres", b =>
                {
                    b.HasOne("Entities.Concrete.Cari", "cari")
                        .WithMany("Adresler")
                        .HasForeignKey("CariId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.Concrete.Telefon", b =>
                {
                    b.HasOne("Entities.Concrete.Cari", "cari")
                        .WithMany("Telefonlar")
                        .HasForeignKey("CariId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
