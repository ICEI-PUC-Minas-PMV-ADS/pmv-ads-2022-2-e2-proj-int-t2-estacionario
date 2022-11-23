using System;
using EasyPark.EasyPark.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EasyPark.EasyPark.Persistence.Context
{
    public partial class EasyParkContext : DbContext
    {
        public EasyParkContext()
        {
        }

        public EasyParkContext(DbContextOptions<EasyParkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estacionamento> Estacionamentos { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<PrestadorServico> PrestadorServicos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Estacionamento>(entity =>
            {
                entity.ToTable("estacionamento");

                entity.Property(e => e.EstacionamentoId).HasColumnName("estacionamentoId");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.HorarioFuncionamento)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("horarioFuncionamento");

                entity.Property(e => e.NomeEstacionamento)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nomeEstacionamento");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.Property(e => e.TotaisVagas).HasColumnName("totaisVagas");

                entity.Property(e => e.UsuarioCriador).HasColumnName("usuarioCriador");

                entity.Property(e => e.VagasComuns).HasColumnName("vagasComuns");

                entity.Property(e => e.VagasEletricas).HasColumnName("vagasEletricas");

                entity.Property(e => e.VagasPreferenciais).HasColumnName("vagasPreferenciais");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Estacionamentos)
                    .HasForeignKey(d => d.Estado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estado");

                entity.HasOne(d => d.UsuarioCriadorNavigation)
                    .WithMany(p => p.Estacionamentos)
                    .HasForeignKey(d => d.UsuarioCriador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UsuarioCriador");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.ToTable("estados");

                entity.Property(e => e.EstadoId).HasColumnName("estadoId");

                entity.Property(e => e.NomeEstado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("nomeEstado");
            });

            modelBuilder.Entity<PrestadorServico>(entity =>
            {
                entity.HasKey(e => e.PrestadorServicosId)
                    .HasName("PK__prestado__AC21B381B2191A9C");

                entity.ToTable("prestadorServicos");

                entity.Property(e => e.PrestadorServicosId).HasColumnName("prestadorServicosId");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.HorarioFuncionamento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("horarioFuncionamento");

                entity.Property(e => e.NomePrestador)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomePrestador");

                entity.Property(e => e.NomeServico)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nomeServico");

                entity.Property(e => e.PrestadorCriador).HasColumnName("prestadorCriador");

                entity.Property(e => e.TelefonePrestador)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefonePrestador");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.PrestadorServicos)
                    .HasForeignKey(d => d.Estado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_estadoAtendimento");

                entity.HasOne(d => d.PrestadorCriadorNavigation)
                    .WithMany(p => p.PrestadorServicos)
                    .HasForeignKey(d => d.PrestadorCriador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prestadorCriador");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuarios");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.NivelAcesso).HasColumnName("nivelAcesso");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("senha");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
