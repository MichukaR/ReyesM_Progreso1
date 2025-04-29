using System.ComponentModel.DataAnnotations;

namespace MichelleReyesP1.Models;

public class PlanDeRecompensas
{
    [Key]
    [Display(Name = "Ingrese su ID")]
    public int id { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime fecha_de_inicio { get; set; }
    [MaxLength(20)]
    [Display(Name = "Ingrese su nombre")]
    public String nombre { get; set; }

    public int puntosAcumulados { get; set; }

    public string tipoDeRecompensa
    {
        get { return puntosAcumulados < 500 ? "SILVER" : "GOLD"; }
    }
}