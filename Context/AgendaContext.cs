using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using primeira_webapi.Entities;

namespace primeira_webapi.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base (options)
        {

        }

        //Contexto da conexão do banco de dados

        public DbSet<Contato> Contatos { get; set; }

        internal object Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}