using Domain.Commands;
using Domain.Enums;
using Domain.NovaPasta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class VeiculoService : IVeiculoService
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(VeiculoCommand command)
        {
            if (command == null)
                return "Todos os campos são obrigatórios";

            int anoAtual = DateTime.Now.Year;
            if (anoAtual - command.AnoFabricacao > 5)
                return "O Ano do veículo é menor que  permitido";

            if (command.TipoVeiculo != ETipoVeiculo.SUV
              && command.TipoVeiculo != ETipoVeiculo.Hatch
              && command.TipoVeiculo != ETipoVeiculo.Sedan)
                return "O tipo de veículo não é permitido";

            return _veiculoRepository.PostAsync(command);
        }
    }
}


