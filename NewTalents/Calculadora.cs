using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TDD = NÃO CODIFICAR ANTES DE TER CODIFICADO UM TESTE

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;
        public Calculadora(string data) {
            listaHistorico = new  List<string>();
            this.data = data;
        }
        public int Somar(int num1, int num2) {
            int result = num1 + num2;
            listaHistorico.Insert(0, "Resp: " + result + "data" + data);
            return result;
        }
        public int Subtrair(int num1, int num2)
        {
            int result = num1 - num2;
            listaHistorico.Insert(0, "Resp: " + result + "data" + data);
            return result;
        }
        public int Dividir(int num1, int num2)
        {
            int result = num1 / num2;
            listaHistorico.Insert(0, "Resp: " + result + "data" + data);
            return result;
        }
        public int Multiplicar(int num1, int num2)
        {
            int result = num1 * num2;
            listaHistorico.Insert(0, "Resp: " + result + "data" + data);
            return result;
        }
        public List<string> historico() {

            List<string> resultado;
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico; 
        }
    }
}
