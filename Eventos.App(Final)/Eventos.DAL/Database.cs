using Eventos.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.DAL
{
    public class DataBase : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
		public DbSet<Participante> Participantes {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql("server = localhost; " + "userid=root;" +"password=root;"+"database=eventos;");
        }

    }
}
