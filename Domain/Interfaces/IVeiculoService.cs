using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.NovaPasta
{
    public interface IVeiculoService
    {
        //Interface é um contrato, apenas usamos para adicionar métodos não é feita implementação de nada
        Task PostAsync(VeiculoCommand command);
        void PostAsync();
        void GetAsync();
    }
}
