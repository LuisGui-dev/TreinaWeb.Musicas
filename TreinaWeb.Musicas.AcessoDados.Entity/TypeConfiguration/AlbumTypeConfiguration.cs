﻿using System.ComponentModel.DataAnnotations.Schema;
using TreinaWeb.Comum.Entity;
using TreinaWeb.Musicas.Dominio;

namespace TreinaWeb.Musicas.AcessoDados.Entity.TypeConfiguration
{
    class AlbumTypeConfiguration : TreinaWebEntityAbstractConfig<Album>
    {
        protected override void ConfigurarNomeTabela()
        {
            ToTable("ALB_ALBUNS");
        }

        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("ALB_ID");

            Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("ALB_NOME")
                .HasMaxLength(100);

            Property(p => p.Ano)
                .IsRequired()
                .HasColumnName("ALB_ANO");

            Property(p => p.Observacoes)
                .IsOptional()
                .HasColumnName("ALB_OBSERVACOES")
                .HasMaxLength(1000);

            Property(p => p.Email)
                .IsRequired()
                .HasColumnName("ALB_EMAIL")
                .HasMaxLength(50);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarChaveEstrangeiras()
        {
            //HasMany(p => p.Musicas)
            //    .WithRequired(p => p.Album)
            //    .HasForeignKey(fk => fk.IdAlbum);
        }
    }
}