using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MichelleReyesP1.Models;

public class Reserva
{
    [Key]
    [MaxLength(10)]
    public int id { get; set; }
    public DateTime fecha_entrada { get; set; }
    public DateTime fecha_salida { get; set; }
    [Required]
    public double ValorAPagar { get; set; } 
    
    public string infromacionCliente {get; set;}
    [ForeignKey("informacionCliente")]
    public Cliente? Cliente { get; set; }
}