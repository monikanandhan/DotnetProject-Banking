﻿// <auto-generated />
using System;
using Banking.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Banking.Migrations
{
    [DbContext(typeof(BankingDbContext))]
    partial class BankingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BankCustomer", b =>
                {
                    b.Property<int>("CustomerdetailsId")
                        .HasColumnType("int");

                    b.Property<int>("banksId")
                        .HasColumnType("int");

                    b.HasKey("CustomerdetailsId", "banksId");

                    b.HasIndex("banksId");

                    b.ToTable("BankCustomer");
                });

            modelBuilder.Entity("Banking.Model.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Bank_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Branch_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Contact_Number")
                        .HasColumnType("bigint");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IFSC")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("pincode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("bank");
                });

            modelBuilder.Entity("Banking.Model.BankLoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Interest_Rate")
                        .HasColumnType("float");

                    b.Property<int>("Loan_Tenure")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("bankloan");
                });

            modelBuilder.Entity("Banking.Model.Cibil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("CIBIL_Score")
                        .HasColumnType("float");

                    b.Property<string>("CIBIL_year")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("cibil");
                });

            modelBuilder.Entity("Banking.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aadhar")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Account_Number")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Account_Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Mobile_Number")
                        .HasColumnType("bigint");

                    b.Property<float>("age")
                        .HasColumnType("float");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("pincode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Banking.Model.Customer_Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<int?>("BankLoanId")
                        .HasColumnType("int");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("BankLoanId");

                    b.HasIndex("customerId");

                    b.ToTable("customer_Banks");
                });

            modelBuilder.Entity("Banking.Model.Customer_LoanDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CsutomerId")
                        .HasColumnType("int");

                    b.Property<int>("LoanDetailsDemoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CsutomerId");

                    b.HasIndex("LoanDetailsDemoId");

                    b.ToTable("customer_LoanDetails");
                });

            modelBuilder.Entity("Banking.Model.Loan_Loandetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BankLoanId")
                        .HasColumnType("int");

                    b.Property<int>("LoanDetailsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BankLoanId");

                    b.HasIndex("LoanDetailsId");

                    b.ToTable("loan_loanDetails");
                });

            modelBuilder.Entity("Banking.Model.LoanDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float>("Loan_Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Loan_Provided")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("payment_Mode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("loanDetail");
                });

            modelBuilder.Entity("BankCustomer", b =>
                {
                    b.HasOne("Banking.Model.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomerdetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Banking.Model.Bank", null)
                        .WithMany()
                        .HasForeignKey("banksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Banking.Model.Cibil", b =>
                {
                    b.HasOne("Banking.Model.Customer", "Customer")
                        .WithOne("cibilDetails")
                        .HasForeignKey("Banking.Model.Cibil", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Banking.Model.Customer_Bank", b =>
                {
                    b.HasOne("Banking.Model.Bank", "Bank")
                        .WithMany("Customer_Banks")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Banking.Model.BankLoan", null)
                        .WithMany("customer_Banks")
                        .HasForeignKey("BankLoanId");

                    b.HasOne("Banking.Model.Customer", "customer")
                        .WithMany("Customer_Banks")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");

                    b.Navigation("customer");
                });

            modelBuilder.Entity("Banking.Model.Customer_LoanDetails", b =>
                {
                    b.HasOne("Banking.Model.Customer", "customer")
                        .WithMany("loanDetailsCusList")
                        .HasForeignKey("CsutomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Banking.Model.LoanDetails", "loanDetails")
                        .WithMany("loanDetailsCusList")
                        .HasForeignKey("LoanDetailsDemoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("loanDetails");
                });

            modelBuilder.Entity("Banking.Model.Loan_Loandetails", b =>
                {
                    b.HasOne("Banking.Model.BankLoan", "BankLoan")
                        .WithMany("loan_loanDetails")
                        .HasForeignKey("BankLoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Banking.Model.LoanDetails", "LoanDetails")
                        .WithMany("loan_loanDetails")
                        .HasForeignKey("LoanDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BankLoan");

                    b.Navigation("LoanDetails");
                });

            modelBuilder.Entity("Banking.Model.LoanDetails", b =>
                {
                    b.HasOne("Banking.Model.Customer", null)
                        .WithMany("loanDetailsCus")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Banking.Model.Bank", b =>
                {
                    b.Navigation("Customer_Banks");
                });

            modelBuilder.Entity("Banking.Model.BankLoan", b =>
                {
                    b.Navigation("customer_Banks");

                    b.Navigation("loan_loanDetails");
                });

            modelBuilder.Entity("Banking.Model.Customer", b =>
                {
                    b.Navigation("Customer_Banks");

                    b.Navigation("cibilDetails")
                        .IsRequired();

                    b.Navigation("loanDetailsCus");

                    b.Navigation("loanDetailsCusList");
                });

            modelBuilder.Entity("Banking.Model.LoanDetails", b =>
                {
                    b.Navigation("loanDetailsCusList");

                    b.Navigation("loan_loanDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
