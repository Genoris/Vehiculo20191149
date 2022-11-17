using System.ComponentModel.DataAnnotations;
namespace Vehiculos20191149.Data.Models;

public class Vehiculo 
{ 
           [Key]
    public string? VehiculoID { get; set; }
    public string? Marca { get; set; }
    public string? Modelo  { get; set; }
    public string? Año  { get; set; }
    public string? Color  { get; set; }

    public static Vehiculo Crear(string VehiculoID, string Marca, string Modelo, string Color){
        return new Vehiculo(){
            VehiculoID = "",
            Marca= "",
            Modelo = "",
           Año ="",
            Color="",
            };
    }
public void Update(string VehiculoID, string Marca, string Modelo, string Color)
    {
        VehiculoID = "";
            Marca= "";
            Modelo = "";
           Año ="";
            Color="";
    }
}


