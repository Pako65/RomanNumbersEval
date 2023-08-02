namespace RomanNumbers.Test
{
    public class RomanNumbersTest
    {

        [Theory(DisplayName = "ETANT DONNE UN <chiffreseul> " +
                              "QUAND JE LE CONVERTIS EN CHIFFRE ROMAIN " +
                              "ALORS J'OBTIENS <chiffreseul> EN NOMBRE ROMAINS")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void TestSeul(int chiffreSeul)
        {
            var nombreRomain = ConvertisseurNbrRomains.Convertir(chiffreSeul);
            var resultat = new string(Enumerable.Repeat('I', chiffreSeul).ToArray());
            Assert.Equal(resultat, nombreRomain);   
           
        }
        //[Fact]
        //public void Test2()
        //{
        //    // ETANT DONNE UN CHIFFRE 2
        //    const int chiffre = 2;
        //    // QUAND JE LE CONVERTIS EN CHIFFRE ROMAIN
        //    var nombreRomain = ConvertisseurNbrRomains.Convertir(chiffre);
        //    // ALORS J'OBTIENS 1 EN NBR ROMAINS
        //    Assert.Equal("I", nombreRomain);
        //}
    }
}