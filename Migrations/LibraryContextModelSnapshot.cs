﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using librarygraphql.Models;

namespace librarygraphql.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0-preview2.19525.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("librarygraphql.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnName("surname")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("librarygraphql.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnName("authorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnName("categoryId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnName("countryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<int>("LanguageId")
                        .HasColumnName("languageId")
                        .HasColumnType("int");

                    b.Property<int>("PublisherId")
                        .HasColumnName("publisherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CountryId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("librarygraphql.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("librarygraphql.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("librarygraphql.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("librarygraphql.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("librarygraphql.Models.Book", b =>
                {
                    b.HasOne("librarygraphql.Models.Author", "Author")
                        .WithMany("Book")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK_Book_Author")
                        .IsRequired();

                    b.HasOne("librarygraphql.Models.Category", "Category")
                        .WithMany("Book")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Book_Category")
                        .IsRequired();

                    b.HasOne("librarygraphql.Models.Country", "Country")
                        .WithMany("Book")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_Book_Country")
                        .IsRequired();

                    b.HasOne("librarygraphql.Models.Language", "Language")
                        .WithMany("Book")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("FK_Book_Language")
                        .IsRequired();

                    b.HasOne("librarygraphql.Models.Publisher", "Publisher")
                        .WithMany("Book")
                        .HasForeignKey("PublisherId")
                        .HasConstraintName("FK_Book_Publisher")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
