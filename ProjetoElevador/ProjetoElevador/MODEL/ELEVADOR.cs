using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoElevador.MODEL
{
    public class ELEVADOR
    {
        private int CAPMAX;     //CAPACIDADE MÁXIMA//
        private int TOTFLOOR;   //TOTAL DE DE ANDARES//
        private int QUANTP=0;   //QUANTIDADE DE PESSOAS//
        private int FLOOR = 0;  //ANDAR//

        public void Inicializar(int CAP, int FLOORS){
            this.CAPMAX = CAP;
            this. TOTFLOOR = FLOORS;
        }

        public void Entrar()
        {

            if (this.QUANTP == this.CAPMAX) {
                Console.WriteLine("Capacidade Máxima Atingida! Por Favor, Aguarde!");
            } else if (this.QUANTP < this.CAPMAX){
                this.QUANTP += 1;
                Console.WriteLine($"Quantidade de Pessoas no Elevador:{this.QUANTP}");
            }
        }
        public void Sair(){
            if (this.QUANTP == 0)
            {
                Console.WriteLine("Elevador Vazio!");
            } else if (this.QUANTP > 0)
            {
                this.QUANTP -= 1;
                Console.WriteLine($"Quantidade de Pessoas no Elevador: {this.QUANTP}");
            }
        }
        public void Subir()
        {
        if (this.FLOOR == this.TOTFLOOR)
            {
                Console.WriteLine("Limite Atingido");
            }else { this.FLOOR+=1;
                Console.WriteLine($"Andar: {this.FLOOR}");
            }
        }
        public void Descer()
        {
            if (this.FLOOR == 0)
            {
                Console.WriteLine("Térreo.");
            }
            else
            {
                this.FLOOR -= 1;
                if (this.FLOOR == 0)
                {
                    Console.WriteLine("Térreo.");
                }
                else
                {
                    Console.WriteLine($"Andar: {this.FLOOR}");
                }

            }


        }

     }
}
