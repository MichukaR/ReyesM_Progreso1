using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MichelleReyesP1.Models;

public class Reserva
{
    [Key]
    [MaxLength(10)]
    public int id { get; set; }
    
    [Display(Name = "Fecha de ingreso")]
    public DateTime fecha_entrada { get; set; }
    
    [Display(Name = "Fecha de salida")]
    public DateTime fecha_salida { get; set; }

    [Display(Name = "Valor de la reserva")]
    public double ValorAPagar  { get; set; }
    
    [Display(Name = "Reserva a nombre de:")]
    public string infromacionCliente {get; set;}
    [ForeignKey("informacionCliente")]
    public Cliente? Cliente { get; set; }
}