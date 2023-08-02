namespace RomanNumbers.Test
{
    public class RomanNumbersTest
    {

        [Fact]
        public void Test1()
        {
            // ETANT DONNE UN CHIFFRE 1
            const int chiffre = 1;
            // QUAND JE LE CONVERTIS EN CHIFFRE ROMAIN
            var nombreRomain = ConvertisseurNbrRomains.Convertir(chiffre);
            // ALORS J'OBTIENS 1 EN NBR ROMAINS
            Assert.Equal("I", nombreRomain);
        }
        [Fact]
        public void Test2()
        {
            // ETANT DONNE UN CHIFFRE 2
            const int chiffre = 2;
            // QUAND JE LE CONVERTIS EN CHIFFRE ROMAIN
            var nombreRomain = ConvertisseurNbrRomains.Convertir(chiffre);
            // ALORS J'OBTIENS 1 EN NBR ROMAINS
            Assert.Equal("I", nombreRomain);
        }
    }
}