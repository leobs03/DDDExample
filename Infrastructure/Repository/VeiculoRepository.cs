using Dapper;
using Domain.Commands;
using Domain.Entidades;
using Domain.Interfaces;
using System.Data.SqlClient;

namespace Infrastructure.Repository
{
    public class VeiculoRepository: IVeiculoRepository
    {
        String conexao = @"Server=(localdb)\\mssqllocaldb;Database=AluguelVeiculos;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task <string> PostAsync(VeiculoCommand command)
        {
            string queryInsert = @"
            INSERT INTO Veiculo(Placa, AnoFabricacao, TipoVeiculo, Estado, MontadoraID)
            VALUES(@Placa, @AnoFabricacao, @TipoVeiculo, @Estado, @MontadoraID)";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculoID = (int)command.TipoVeiculo,
                    Estado = command.Estado,
                    MontadoraID = command.Montadora
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

        public Task<string> PostAsync(VeiculoCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
