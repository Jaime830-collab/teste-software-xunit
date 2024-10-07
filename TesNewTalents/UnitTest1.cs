using NewTalents;


//A referencia de projeto só pode adicionar no projeto de teste
//e nunca o projeto de teste no Projeto normal
namespace TesNewTalents
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse() {
            string data = " 02 / 02 / 2020";
            Calculadora calc = new Calculadora(" 02 / 02 / 2020");
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse();
            int resultadoCalculo = calc.Somar(val1,val2);
            Assert.Equal(resultado, resultadoCalculo);
        }

        [Theory]
        [InlineData(1, 2, 4)]
        [InlineData(1, 5, 9)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse();
            int resultadoCalculo = calc.Subtrair(val1, val2);
            Assert.Equal(resultado, resultadoCalculo);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse();
            int resultadoCalculo = calc.Dividir(val1, val2);
            Assert.Equal(resultado, resultadoCalculo);
        }
        [Theory]
        [InlineData(1, 2, 2, 0)]
        [InlineData(4, 5, 20, 0)]
        public void TestMultiplicar(int val1, int val2, int val3, int resultado)
        {
            Calculadora calc = ConstruirClasse();
            int resultadoCalculo = calc.Multiplicar(val1, val2);
            Assert.Equal(resultado, resultadoCalculo);
        }
        [Fact]
        public void TestarDivisaoPorZero() {
            Calculadora calc = ConstruirClasse();
            Assert.Throws<DivideByZeroException>(  () => calc.Dividir(3, 0));
        }
        [Fact]
        public void TestarHistorico() {
            Calculadora calc = ConstruirClasse();

            calc.Somar(1,2);
            calc.Somar(8, 2);
            calc.Somar(3, 7);
            calc.Somar(1, 4);

            var lista = calc.historico();

            Assert.NotEmpty(lista); 
            Assert.Equal(3, lista.Count);

        }
    }
}