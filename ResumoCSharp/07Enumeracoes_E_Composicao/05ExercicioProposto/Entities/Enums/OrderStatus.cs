using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._7Enumeracoes_E_Composicao._05ExercicioProposto.Entities.Enums
{
    enum OrderStatus : int
    {
        PENDING_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED = 2,
        DELIVERED = 3
    }
}