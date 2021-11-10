using System.ComponentModel.DataAnnotations;
namespace ApiAndroid.Models {
    public class Productos {
        [Key]
        public int idProducto {get; set;}
        public string producto {get; set;}
        public int idMarca {get; set;}
        public string descripcion {get; set;}
        public string imagen {get; set;}
        public double precioCosto {get; set;}
        public double precioVenta {get; set;}
        public int existencia {get; set;}
        public string fechaIngreso {get; set;}
    }
}