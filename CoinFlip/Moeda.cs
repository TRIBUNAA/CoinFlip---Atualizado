using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    public class Moeda
    {
        private String ladoSorteado;

        public String LadoSorteado { get; set; }

        public void SortearLado()
        {
            int lado = new Random().Next(2);
            if (lado == 0)
            {
                LadoSorteado = "cara";
            }
            else { LadoSorteado = "coroa"; }

        }
    }
}