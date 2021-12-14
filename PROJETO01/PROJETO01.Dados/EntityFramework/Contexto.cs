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
        public DbSet<SolicitarCorte> SolicitarCorte { get; set; }

        //Definição das características das classes com as tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        //
         modelBuilder.Entity<Estado>()
         .ToTable("Estado")
         .HasKey("UF");

         modelBuilder.Entity<Estado>()
         .Property(f => f.UF)
         .HasColumnName("UF")
         .HasColumnType("char(2)")
         .IsRequired();

         modelBuilder.Entity<Estado>()
         .Property(f => f.Nome)
         .HasColumnName("Nome")
         .HasColumnType("varchar(100)")
         .IsRequired();


        //
             modelBuilder.Entity<Cidade>()
             .ToTable("Cidade")
             .HasKey("IdCidade");

             modelBuilder.Entity<Cidade>()
             .Property(f => f.IdCidade)
             .HasColumnName("IdCidade")
             .HasColumnType("int")
             .IsRequired();

             modelBuilder.Entity<Cidade>()
             .Property(f => f.Nome)
             .HasColumnName("Nome")
             .HasColumnType("vachar(200)")
             .IsRequired();

             modelBuilder.Entity<Cidade>()
             .Property(f => f.UF)
             .HasColumnName("UF")
             .HasColumnType("char(2)")
             .IsRequired();

            modelBuilder.Entity<Cidade>()
                .HasOne(f => f.Estado)
                .WithMany()
                .HasForeignKey(f => f.UF);
            //
            modelBuilder.Entity<Cliente>()
                         .ToTable("Cliente")
                         .HasKey("IdCliente");

                         modelBuilder.Entity<Cliente>()
                         .Property(f => f.Nome)
                         .HasColumnName("Nome")
                         .HasColumnType("varchar(200)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property(f => f.Cpf)
                         .HasColumnName("Cpf")
                         .HasColumnType("char(11)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property(f => f.Sexo)
                         .HasColumnName("Sexo")
                         .HasColumnType("char(2)")
                         .IsRequired();


                         modelBuilder.Entity<Cliente>()
                         .Property(f => f.Telefone)
                         .HasColumnName("Telefone")
                         .HasColumnType("varchar(200)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property(f => f.Cep)
                         .HasColumnName("Cep")
                         .HasColumnType("varchar(20)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property(f => f.Logradouro)
                         .HasColumnName("Logradouro")
                         .HasColumnType("varchar(200)")
                         .IsRequired();


                         modelBuilder.Entity<Cliente>()
                         .Property(f => f.Complemento)
                         .HasColumnName("Complemento")
                         .HasColumnType("varchar(200)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property(f => f.Bairro)
                         .HasColumnName("Bairro")
                         .HasColumnType("varchar(200)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property(f => f.Numero)
                         .HasColumnName("Numero")
                         .HasColumnType("varchar(20)")
                         .IsRequired();

                         modelBuilder.Entity<Cliente>()
                         .Property(f => f.IdCidade)
                         .HasColumnName("IdCidade")
                         .HasColumnType("int")
                         .IsRequired();

                        modelBuilder.Entity<Cliente>()
                           .HasOne(f => f.Cidade)
                           .WithMany()
                           .HasForeignKey(f => f.IdCidade);
            //
            modelBuilder.Entity<Barbeiro>()
                            .ToTable("Barbeiro")
                            .HasKey("IdBarbeiro");

                             modelBuilder.Entity<Barbeiro>()
                            .Property(f => f.Nome)
                            .HasColumnName("Nome")
                            .HasColumnType("varchar(200)")
                            .IsRequired();

                             modelBuilder.Entity<Barbeiro>()
                            .Property(f => f.cpf)
                            .HasColumnName("Cpf")
                            .HasColumnType("char(11))")
                            .IsRequired();

                            modelBuilder.Entity<Barbeiro>()
                            .Property(f => f.PrecoCorte)
                            .HasColumnName("PrecoCorte")
                            .HasColumnType("decimal(16,2)")
                            .IsRequired();

                            modelBuilder.Entity<Barbeiro>()
                            .Property(f => f.Telefone)
                            .HasColumnName("Telefone")
                            .HasColumnType("varchar(20)")
                            .IsRequired();


                            modelBuilder.Entity<Barbeiro>()
                            .Property(f => f.IdEspecialidade)
                            .HasColumnName("IdEspecialidade")
                            .HasColumnType("int")
                            .IsRequired();

            modelBuilder.Entity<Barbeiro>()
                .HasOne(f => f.EspecialidadeB)
                .WithMany()
                .HasForeignKey(f => f.IdEspecialidade);




            //

            modelBuilder.Entity<EspecialidadeB>()
                                   .ToTable("Especialidade_B")
                                   .HasKey("IdEspecialidade");

            modelBuilder.Entity<EspecialidadeB>()
                                  .Property(f => f.IdEspecialidade)
                                  .HasColumnName("IdEspecialidade")
                                  .HasColumnType("int")
                                  .IsRequired();

            modelBuilder.Entity<EspecialidadeB>()
                                   .Property(f => f.Especialidade)
                                   .HasColumnName("Especialidade")
                                   .HasColumnType("varchar(20)")
                                   .IsRequired();



                                        modelBuilder.Entity<SolicitarCorte>()
                                       .ToTable("solicitarCorte")
                                       .HasKey("IdSolicitacao");

                                        modelBuilder.Entity<SolicitarCorte>()
                                        .Property(f => f.IdSolicitacao)
                                        .HasColumnName("IdSolicitacao")
                                        .HasColumnType("int")
                                        .IsRequired();

                                        modelBuilder.Entity<SolicitarCorte>()
                                        .Property(f => f.IdCliente)
                                        .HasColumnName("IdCliente")
                                        .HasColumnType("int")
                                        .IsRequired();

                                         modelBuilder.Entity<SolicitarCorte>()
                                       .Property(f => f.IdBarbeiro)
                                       .HasColumnName("IdBarbeiro")
                                       .HasColumnType("int")
                                       .IsRequired();

                                        modelBuilder.Entity<SolicitarCorte>()
                                                                   .Property(f => f.IdCidade)
                                                                   .HasColumnName("IdCidade")
                                                                   .HasColumnType("int")
                                                                   .IsRequired();

                                        modelBuilder.Entity<SolicitarCorte>()
                                        .Property(f => f.PrecoCorte)
                                        .HasColumnName("PrecoCorte")
                                        .HasColumnType("float")
                                        .IsRequired();


                                        modelBuilder.Entity<SolicitarCorte>()
                                        .Property(f => f.Logradouro)
                                        .HasColumnName("Logradouro")
                                        .HasColumnType("varchar(200)")
                                        .IsRequired();

                                        modelBuilder.Entity<SolicitarCorte>()
                                        .Property(f => f.Complemento)
                                        .HasColumnName("Complemento")
                                        .HasColumnType("varchar(100)")
                                        .IsRequired();

                                       modelBuilder.Entity<SolicitarCorte>()
                                     .Property(f => f.Bairro)
                                     .HasColumnName("Bairro")
                                     .HasColumnType("varchar(200)")
                                     .IsRequired();

                                       modelBuilder.Entity<SolicitarCorte>()
                                     .Property(f => f.Numero)
                                     .HasColumnName("Numero")
                                     .HasColumnType("varchar(200)")
                                     .IsRequired();

                        modelBuilder.Entity<SolicitarCorte>()
                           .HasOne(f => f.cliente)
                           .WithMany()
                           .HasForeignKey(f => f.IdCliente);


                        modelBuilder.Entity<SolicitarCorte>()
                           .HasOne(f => f.barbeiro)
                           .WithMany()
                           .HasForeignKey(f => f.IdBarbeiro);

                        modelBuilder.Entity<SolicitarCorte>()
                         .HasOne(f => f.cidade)
                         .WithMany()
                         .HasForeignKey(f => f.IdCidade);





            base.OnModelCreating(modelBuilder);



        }
        
        
    }
}
