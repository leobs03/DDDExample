using Dapper;
using Domain.Entidades;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class VeiculoRepository: IVeiculoRepository
    {
        private String stringconnection = "";
        public async Task <string> PostAsync(Veiculo command)
        {
            string queryInsert = @"
            INSERT INTO Veiculo(Placa, AnoFabricacao, TipoVeiculo, Estado, MontadoraID)
            VALUES(@Placa, @AnoFabricacao, @TipoVeiculo, @Estado, @MontadoraID)";

            using (var conn = new SqlConnection())
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculo = command.TipoVeiculo,
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

    }
}
