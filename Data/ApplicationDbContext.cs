using Microsoft.EntityFrameworkCore;

namespace MichelleReyesP1.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<MichelleReyesP1.Models.Cliente> Clientes { get; set; } = default!;
    public DbSet<MichelleReyesP1.Models.Reserva> Reservas { get; set; } = default!;
    public DbSet<MichelleReyesP1.Models.PlanDeRecompensas> PlanDeRecompensas { get; set; } = default!;

}