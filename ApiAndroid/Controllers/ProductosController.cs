using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using ApiAndroid.Models;
namespace ApiAndroid.Controllers {
    [Route("api/[controller]")]
    public class ProductosController : Controller {
        private Conexion dbConexion;
        public ProductosController() {
            dbConexion = Conectar.Create();
        }
        [HttpGet]
        public ActionResult Get() {
            return Ok(dbConexion.Productos.ToArray());
        }
        /*[HttpGet("{id}")]
        public async Task<ActionResult> Get(int id){
        var clientes = await dbConexion.Productos.FindAsync(id);
            if (clientes !=null) {
                return Ok(clientes);

            }else{
                return NotFound();

            }
        }*/
    }
}