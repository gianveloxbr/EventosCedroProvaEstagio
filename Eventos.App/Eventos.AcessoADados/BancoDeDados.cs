﻿using Eventos.AcessoADados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.AcessoADados
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Participante> Participantes {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder opcoes)
        {
            opcoes.UseMySql("server = localhost; " + "userid=root;" + "password=root;" + "database=eventos;");
        }
    }
}
