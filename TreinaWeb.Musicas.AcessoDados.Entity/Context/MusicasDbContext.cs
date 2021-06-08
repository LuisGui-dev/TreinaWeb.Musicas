﻿using System.Data.Entity;
using TreinaWeb.Musicas.AcessoDados.Entity.TypeConfiguration;
using TreinaWeb.Musicas.Dominio;

namespace TreinaWeb.Musicas.AcessoDados.Entity.Context
{
    public class MusicasDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Musica> Musicas { get; set; }

        public MusicasDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumTypeConfiguration());
            modelBuilder.Configurations.Add(new MusicaTypeConfiguration());
        }
    }
}