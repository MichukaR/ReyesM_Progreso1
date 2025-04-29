using System.ComponentModel.DataAnnotations;

namespace MichelleReyesP1.Models;

public class Cliente
{
    [Key]
    [MaxLength(10)]
    [Display(Name = "Ingrese su ID")]
    public string Id {get; set;}
    [Display(Name = "Nombre")]
    [MaxLength(50)]
    public string Nombre {get; set;}
    [Display(Name = "Edad")]
    [MaxLength(3)]
    public int edad {get; set;}
    [MaxLength(10)]
    [Display(Name = "Número de telefono")]
    public string Telefono {get; set;}
    [Display(Name = "Se ha hospedado antes?")]
    public bool pregunta {get; set;}
}