using Vehiculos20191149.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculos20191149.Data.Context;

public class Vehiculos2019114DbContext:DbContext
{
    public  Vehiculos2019114DbContext(DbContextOptions options):base (options)
    {

    }

 public virtual DbSet<Vehiculo> Vehiculo {get; set;}= null!;
 
}
 public interface Vehiculos2019114
 {
    
 public  DbSet<Vehiculo> Vehiculos {get; set;}
 }