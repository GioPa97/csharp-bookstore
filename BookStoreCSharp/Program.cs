// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        string titolo = "cleaCode";
        string autore = "RobertC.Martin";
        long isbn = 9780132350884;
        int numeroPagine = 431;
        int peso = 800;
        float larghezza = 17.73f;
        float altezza = 2.79f;
        float profondita = 23.37f;

        int valutazione = 5;
        int numeroRecensioni = 4571;
        bool versioneKindle = true;

        Console.WriteLine($"----IL LIBRO DI OGGI: {titolo} di {autore} ----------------"
            + $"ISBN: {isbn},"
            + $"Numero delle pagine: {numeroPagine} pagine"
            + $"Peso del libro:{peso}kg"
            + $"Dimensioni del libro:{larghezza} cm x {altezza}cm x {profondita} cm"
            + "Informazioni Amazon:"
            + $"Numero di recensioni: {numeroRecensioni} recensioni"
            + $"Valutazione media: {valutazione} stelline"
            + "Kindle disponibile: Si o No"
            + "Copertina flessibile disponibile: Si o No"
            + "---------------------------------------------------------------------------------"

            );
    }
}