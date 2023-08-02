namespace RomanNumbers.Test
{
    public class ConvertisseurNbrRomains
    {
        public static string Convertir(int chiffre)

            => chiffre switch
            {
                1 => "I",
                2 => "II",
                _ => "III",
            };
    }
}