/*using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LivrariaControleEmprestimo.WEB.Models;

public partial class ControleEmprestimoLivroContext : DbContext
{
    public ControleEmprestimoLivroContext()
    {
    }

    public ControleEmprestimoLivroContext(DbContextOptions<ControleEmprestimoLivroContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Cliente { get; set; }

    public virtual DbSet<Livro> Livro { get; set; }

    public virtual DbSet<Livro_Cliente_Emprestimo> Livro_Cliente_Emprestimo { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LUCGOMROC\\SQLEXPRESS;Initial Catalog=ControleEmprestimoLivro;Persist Security Info=True;User ID=sa;Password=123;Trust Server Certificate=True;Command Timeout=300");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.cliBairro)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.cliCPF)
                .IsRequired()
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.cliCidade)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.cliEndereco)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.cliNome)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.cliNumero)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.cliTelefoneCelular)
                .IsRequired()
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.cliTelefoneFixo)
                .IsRequired()
                .HasMaxLength(13)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Livro>(entity =>
        {
            entity.Property(e => e.livroAnoPublicacao).HasColumnType("datetime");
            entity.Property(e => e.livroAutor)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.livroEdicao)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.livroEditora)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.livroNome)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Livro_Cliente_Emprestimo>(entity =>
        {
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.lceDataDevolucao).HasColumnType("datetime");
            entity.Property(e => e.lceDataEmprestimo).HasColumnType("datetime");

            entity.HasOne(d => d.idNavigation).WithOne(p => p.Livro_Cliente_Emprestimo)
                .HasForeignKey<Livro_Cliente_Emprestimo>(d => d.id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Livro_Cliente_Emprestimo_Cliente");

            entity.HasOne(d => d.id1).WithOne(p => p.Livro_Cliente_Emprestimo)
                .HasForeignKey<Livro_Cliente_Emprestimo>(d => d.id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Livro_Cliente_Emprestimo_Livro");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
*/