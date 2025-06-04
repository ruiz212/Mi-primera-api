using Microsoft.EntityFrameworkCore;

namespace API2M6SIS.Data
{
    public class EstudianteContex : DbContext
    {
       public DbSet<Models.Estudiante> Estudiantes { get; set; }
        public EstudianteContex(DbContextOptions<EstudianteContex> options) : base(options)
        {

        }


    }

}

