using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace PROJETO01.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = @"Data source = 201.62.57.93;  
                                    Database = BD040684; 
                                    User ID = RA040684;  
                                    Password = 040684";
            optionsBuilder.UseSqlServer(conn);
        }

    

        //Nome das Classes que representarão o Banco de Dados
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet <Barbeiro> Barbeiro { get; set; }
        public DbSet <EspecialidadeB> EspecialidadeB { get; set; }


       

        //Definição das características das classes com as tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         modelBuilder.Entity<Estado>()
         .ToTable("Estado")
         .HasKey("UF");

         modelBuilder.Entity<Estado>()
         .Property("UF")
         .HasColumnName("UF")
         .HasColumnType("char(2)")
         .IsRequired();

         modelBuilder.Entity<Estado>()
         .Property("Nome")
         .HasColumnName("Nome")
         .HasColumnType("varchar(100)")
         .IsRequired();

             modelBuilder.Entity<Cidade>()
             .ToTable("Cidade")
             .HasKey("IdCidade");

             modelBuilder.Entity<Cidade>()
             .Property("IdCidade")
             .HasColumnName("IdCidade")
             .HasColumnType("int")
             .IsRequired();

             modelBuilder.Entity<Cidade>()
             .Property("Nome")
             .HasColumnName("Nome")
             .HasColumnType("vachar(200)")
             .IsRequired();

             modelBuilder.Entity<Cidade>()
             .Property("Uf")
             .HasColumnName("UF")
             .HasColumnType("char(2)")
             .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .ToTable("Cliente")
                         .HasKey("IdCliente");

                         modelBuilder.Entity<Cliente>()
                         .Property("Nome")
                         .HasColumnName("Nome")
                         .HasColumnType("varchar(200)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property("Cpf")
                         .HasColumnName("Cpf")
                         .HasColumnType("char(11)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property("Sexo")
                         .HasColumnName("Sexo")
                         .HasColumnType("char(2)")
                         .IsRequired();


                         modelBuilder.Entity<Cliente>()
                         .Property("Telefone")
                         .HasColumnName("Telefone")
                         .HasColumnType("varchar(200)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property("Cep")
                         .HasColumnName("Cep")
                         .HasColumnType("varchar(20)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property("Logradouro")
                         .HasColumnName("Logradouro")
                         .HasColumnType("varchar(200)")
                         .IsRequired();


                         modelBuilder.Entity<Cliente>()
                         .Property("Complemento")
                         .HasColumnName("Complemento")
                         .HasColumnType("varchar(200)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property("Bairro")
                         .HasColumnName("Bairro")
                         .HasColumnType("varchar(200)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property("Numero")
                         .HasColumnName("Numero")
                         .HasColumnType("varchar(20)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property("IdCidade")
                         .HasColumnName("IdCidade")
                         .HasColumnType("int")
                         .IsRequired();


            base.OnModelCreating(modelBuilder);
        }
        
        
    }
}
