using Microsoft.EntityFrameworkCore;
namespace ApiAndroid.Models
{
    class Conexion : DbContext {
        public Conexion(DbContextOptions<Conexion> options) : base (options) {}
        public DbSet<Productos> Productos {get; set;}
}
    class Conectar {
        private const string cadenaConexion = "server=localhost;port=3306;database=proyecto_progra22021;userid=user1;pwd=user1";
        public static Conexion Create() {
            var constructor = new DbContextOptionsBuilder<Conexion>();
            constructor.UseMySQL(cadenaConexion);
            var cn = new Conexion(constructor.Options);
            return cn;
        }
    }
}