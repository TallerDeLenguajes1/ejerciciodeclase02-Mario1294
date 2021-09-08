using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    class Cuenta_Bancaria
    {
        private int dinero;
        private int dineroAlmacenado;
        private string tipoCeunta;
        private string operacion;
        private int cajero;

        public int Dinero { get => dinero; set => dinero = value; }
        public int DineroAlmacenado { get => dineroAlmacenado; set => dineroAlmacenado = value; }
        public string TipoCeunta { get => tipoCeunta; set => tipoCeunta = value; }
        public int Cajero { get => cajero; set => cajero = value; }
        public string Operacion { get => operacion; set => operacion = value; }

        public Cuenta_Bancaria()
        {
            dineroAlmacenado = 0;
            if (tipoCeunta == "CorrienPesos")
            {
                if (cajero == 2)
                {
                    if (dinero <= (dineroAlmacenado - 5000) && dinero <== 20000)
                    {
                        Console.WriteLine("Extracion realizada con exito");
                    }
                    else
                    {

                    }
                }
            }

          
        }
    }
}
