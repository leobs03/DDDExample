using Dapper;
using Domain.Commands;
using Domain.Entidades;
using Domain.Enums;
using Domain.Interfaces;
using System.Data.SqlClient;

namespace Infrastructure.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        String conexao = @"Server=(localdb)\mssqllocaldb;Database=AluguelVeiculos;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostAsync(VeiculoCommand command)
        {
            string queryInsert = @"
            INSERT INTO Veiculo(Placa, AnoFabricacao, TipoVeiculo, Estado, MontadoraID)
            VALUES(@Placa, @AnoFabricacao, @TipoVeiculo, @Estado, @Montadora)";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculo = (int)command.TipoVeiculo,
                    Estado = command.Estado,
                    Montadora = (int)command.Montadora
                });
                return "Veiculo cadastrado com sucesso";
            }

        }
        public void PostAsync()
        {

        }
        public void GetAsync()
        {

        }
        public async Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveis()
        {
            string queryBuscarVeiculosDisponiveis = @"
                SELECT * FROM Veiculo WHERE ALUGADO = 0";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                return conn.QueryAsync<VeiculoCommand>(queryBuscarVeiculosDisponiveis).Result.ToList();
            }
        }
        public async Task<VeiculoPrecoCommand> GetPrecoDiaria(ETipoVeiculo tipoVeiculo)
        {
            string queryGetPrecoDiaria = @"SELECT * FROM VeiculoPreco WHERE TipoVeiculo = @TipoVeiculo";
        }
        using(SqlConnection conn = new SqlConnection(conexao))
        {
        return conn.QueryAsync<VeiculoPrecoCommand>(queryGetPrecoDiaria, new)
    

    }
}
