﻿// <auto-generated />
using System;
using Infrastructure.Persistences;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ProductionContext))]
    [Migration("20221216154151_UpdateJobStepIdPrimaryKey")]
    partial class UpdateJobStepIdPrimaryKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CoCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CodeProduct")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("PSE")
                        .HasColumnType("double");

                    b.Property<double>("PSW")
                        .HasColumnType("double");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Saler")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("Domain.Group", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Groups", (string)null);
                });

            modelBuilder.Entity("Domain.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("App")
                        .HasColumnType("int");

                    b.Property<int>("CSOId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DeliverType")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("InputInfo")
                        .HasColumnType("longtext");

                    b.Property<int>("InputNumber")
                        .HasColumnType("int");

                    b.Property<string>("Instruction")
                        .HasColumnType("longtext");

                    b.Property<string>("JobId")
                        .HasColumnType("longtext");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<string>("OutputInfo")
                        .HasColumnType("longtext");

                    b.Property<int>("OutputNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductLevelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CSOId");

                    b.HasIndex("ProductLevelId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Domain.JobStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EstimationInSeconds")
                        .HasColumnType("int");

                    b.Property<string>("InputInfo")
                        .HasColumnType("longtext");

                    b.Property<int>("InputNumber")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("OutputInfo")
                        .HasColumnType("longtext");

                    b.Property<int>("OutputNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ShiftId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StepId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("ShiftId");

                    b.HasIndex("StepId");

                    b.HasIndex("WorkerId");

                    b.ToTable("JobSteps");
                });

            modelBuilder.Entity("Domain.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NoterId")
                        .HasColumnType("int");

                    b.Property<int>("ObjectId")
                        .HasColumnType("int");

                    b.Property<string>("ObjectName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Domain.ProductLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ProductLevels");
                });

            modelBuilder.Entity("Domain.Role", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Domain.Shift", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Shifts", (string)null);
                });

            modelBuilder.Entity("Domain.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CurrentShiftId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsAssigned")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("Domain.StaffGroup", b =>
                {
                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.HasKey("StaffId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("StaffGroups");
                });

            modelBuilder.Entity("Domain.StaffProductLevel", b =>
                {
                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<int>("ProductLevelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.HasKey("StaffId", "ProductLevelId");

                    b.HasIndex("ProductLevelId");

                    b.ToTable("StaffProductLevels");
                });

            modelBuilder.Entity("Domain.StaffRole", b =>
                {
                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.HasKey("StaffId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("StaffRoles");
                });

            modelBuilder.Entity("Domain.StaffShift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("InShiftAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("OutShiftAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ShiftId")
                        .HasColumnType("int");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("Id");

                    b.HasIndex("ShiftId");

                    b.HasIndex("StaffId");

                    b.ToTable("StaffShifts");
                });

            modelBuilder.Entity("Domain.Step", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DateDeleted")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EstimationInSeconds")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductLevelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductLevelId");

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("Domain.Job", b =>
                {
                    b.HasOne("Domain.Staff", "CSO")
                        .WithMany()
                        .HasForeignKey("CSOId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.ProductLevel", "ProductLevel")
                        .WithMany("Jobs")
                        .HasForeignKey("ProductLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CSO");

                    b.Navigation("ProductLevel");
                });

            modelBuilder.Entity("Domain.JobStep", b =>
                {
                    b.HasOne("Domain.Job", "Job")
                        .WithMany("JobSteps")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Shift", "Shift")
                        .WithMany("JobSteps")
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Domain.Step", "Step")
                        .WithMany("JobSteps")
                        .HasForeignKey("StepId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Staff", "Worker")
                        .WithMany("JobSteps")
                        .HasForeignKey("WorkerId");

                    b.Navigation("Job");

                    b.Navigation("Shift");

                    b.Navigation("Step");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("Domain.StaffGroup", b =>
                {
                    b.HasOne("Domain.Group", "Group")
                        .WithMany("StaffGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Staff", "Staff")
                        .WithMany("StaffGroup")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Domain.StaffProductLevel", b =>
                {
                    b.HasOne("Domain.ProductLevel", "ProductLevel")
                        .WithMany("StaffProductLevels")
                        .HasForeignKey("ProductLevelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Staff", "Staff")
                        .WithMany("StaffProductLevels")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ProductLevel");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Domain.StaffRole", b =>
                {
                    b.HasOne("Domain.Role", "Role")
                        .WithMany("StaffRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Staff", "Staff")
                        .WithMany("StaffRoles")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Domain.StaffShift", b =>
                {
                    b.HasOne("Domain.Shift", "Shift")
                        .WithMany("StaffShifts")
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Staff", "Staff")
                        .WithMany("StaffShifts")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shift");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Domain.Step", b =>
                {
                    b.HasOne("Domain.ProductLevel", "ProductLevel")
                        .WithMany("Steps")
                        .HasForeignKey("ProductLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductLevel");
                });

            modelBuilder.Entity("Domain.Group", b =>
                {
                    b.Navigation("StaffGroups");
                });

            modelBuilder.Entity("Domain.Job", b =>
                {
                    b.Navigation("JobSteps");
                });

            modelBuilder.Entity("Domain.ProductLevel", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("StaffProductLevels");

                    b.Navigation("Steps");
                });

            modelBuilder.Entity("Domain.Role", b =>
                {
                    b.Navigation("StaffRoles");
                });

            modelBuilder.Entity("Domain.Shift", b =>
                {
                    b.Navigation("JobSteps");

                    b.Navigation("StaffShifts");
                });

            modelBuilder.Entity("Domain.Staff", b =>
                {
                    b.Navigation("JobSteps");

                    b.Navigation("StaffGroup");

                    b.Navigation("StaffProductLevels");

                    b.Navigation("StaffRoles");

                    b.Navigation("StaffShifts");
                });

            modelBuilder.Entity("Domain.Step", b =>
                {
                    b.Navigation("JobSteps");
                });
#pragma warning restore 612, 618
        }
    }
}
