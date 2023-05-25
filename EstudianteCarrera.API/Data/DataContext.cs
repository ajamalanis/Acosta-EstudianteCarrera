using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EstudianteCarrera.Models;

    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<EstudianteCarrera.Models.Estudiante> Estudiante { get; set; } = default!;

        public DbSet<EstudianteCarrera.Models.Carrera>? Carrera { get; set; }
    }
