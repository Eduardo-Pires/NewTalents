using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {

        private List<string> listaHistorico;
        private DateTime agora;

        public Calculadora()
        {
            listaHistorico = new List<string>();
            agora = DateTime.Now;
        }

        private void InsereEmHistorico(object res)
        {
            listaHistorico.Insert(0, $"Resultado : {res}, data - {agora:dd/MM/yy - HH:mm:ss}");
        }

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            InsereEmHistorico(res);
            return res;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            InsereEmHistorico (res);
            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            InsereEmHistorico(res);
            return res;
        }

        public double Dividir(double val1, double val2)
        {
            if (val2 == 0)
            {
                throw new DivideByZeroException();
            }

            double res = val1 / val2;
            InsereEmHistorico(res);
            return res;
        }

        public List<string> Historico()
        {
            if (listaHistorico.Count < 1)
            {
                throw new Exception("Lista vazia");
            }

            int counter = listaHistorico.Count - 3;
            listaHistorico.RemoveRange(0, counter);

            return listaHistorico;
        }

    }
}
