using Domain.Commands;

namespace Infrastructure.Repository
{
    public interface IVeiculoRepository
    {
        Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveis();
        Task<string> PostAsync(VeiculoCommand command);
    }
}