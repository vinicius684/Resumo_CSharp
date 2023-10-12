using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._7Enumeracoes_E_Composicao._01Enumerarcoes.Entities.Enuns
{
    enum OrderStatus : int 
    {
        Pendingpayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
