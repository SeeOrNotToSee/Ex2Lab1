/**
 * Author       : Daniel Silva | Carlos Silva
 * Date         : 2019-04-04
 * version      : v0.1
 * 
 * Description  : Class que disponibiliza os diferentes tipos
 *                de serviços
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Lab1
{
    class Services
    {
        #region ATTRIBUTES
            int service, vehicle, nifCliente;
            #endregion
                
        #region CONSTRUTORES
                // metodo insere serviço
                /// <summary>
                /// Construtor para dados vindos do exterior
                /// </summary>
                /// <param name="s">Tipo de serviço 1-Limpeza 2-Substituicao 3-Reparacao 4-Abate</param>
                /// <param name="v">Tipo de veiculo 1-Motorizada 2-Bicicleta</param>
                /// <param name="n">Contribuinte do Cliente</param>
                /// <param name="phone">Numero de telefone do cliente</param>
                public Services(string s, int v, int n)
            {
                
            }
        #endregion


        
    }
}

/*enum VEHICLE
        {
            mota,
            bike
        }*/
