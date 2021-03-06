using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using RecommendationNetw.Models;

namespace RecommendationNetw.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160607013927_migration")]
    partial class migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("RecommendationNetw.Models.Answer", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("Category");

                    b.Property<string>("OwnerId");

                    b.Property<string>("QuestionId");

                    b.Property<int>("Value");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RecommendationNetw.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("RecommendationNetw.Models.Question", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("Category");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RecommendationNetw.Models.Recommendation", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("Category");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("IsModerated");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("OwnerId");

                    b.Property<DateTime>("PostedOn");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RecommendationNetw.Models.Set", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("Category");

                    b.Property<double>("Coeficient");

                    b.Property<DateTime>("OwnerModifiedOn");

                    b.Property<string>("OwnerUserId")
                        .IsRequired();

                    b.Property<DateTime>("TargetModifiedOn");

                    b.Property<string>("TargetUserId")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RecommendationNetw.Models.Variant", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("NumericValue");

                    b.Property<string>("QuestionId");

                    b.Property<string>("TextValue")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RecommendationNetw.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RecommendationNetw.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("RecommendationNetw.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RecommendationNetw.Models.Answer", b =>
                {
                    b.HasOne("RecommendationNetw.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.HasOne("RecommendationNetw.Models.Question")
                        .WithMany()
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("RecommendationNetw.Models.Recommendation", b =>
                {
                    b.HasOne("RecommendationNetw.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("RecommendationNetw.Models.Variant", b =>
                {
                    b.HasOne("RecommendationNetw.Models.Question")
                        .WithMany()
                        .HasForeignKey("QuestionId");
                });
        }
    }
}
