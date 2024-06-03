using NewTalents;

namespace TesteNewTalents
{
    public class UnitTest1
    {
        private Calculadora calc;

        public UnitTest1()
        {
           calc = new Calculadora();
        }
        

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TesteSomar(int val1, int val2, int res)
        {
     
            int resultado = calc.Somar(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 2, 3)]
        public void TesteSubtrair(int val1, int val2, int res)
        {

            int resultado = calc.Subtrair(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int res)
        {

            double resultado = calc.Multiplicar(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(1, 2, 0.5)]
        [InlineData(4, 5, 0.8)]
        public void TesteDividir(double val1, double val2, double res)
        {

            double resultado = calc.Dividir(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Fact]
        public void TestarHistorico()
        {
    
            int val1 = 1, val2 = 3;
            calc.Somar(val1, val2);
            val1++;
            val2++;

            calc.Somar(val1, val2);
            val1++;
            val2++;

            calc.Somar(val1, val2);
            val1++;
            val2++;

            calc.Somar(val1, val2);
            val1++;
            val2++;

            calc.Somar(val1, val2);

            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(3, lista.Count);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {

            Assert.Throws<DivideByZeroException>
                (
                    () => calc.Dividir(3, 0)
                );
        }
    }
}