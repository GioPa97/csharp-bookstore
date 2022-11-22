// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        string titolo = "cleanCode";
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
        bool copertinaFlessibile = true;

        Console.WriteLine($"----IL LIBRO DI OGGI: {titolo} di {autore} ----------------" + "\n"
            + "\n"
            + $"ISBN: {isbn}" + "\n"
            + $"Numero delle pagine: {numeroPagine} pagine" + "\n"
            + $"Peso del libro:{peso}kg" + "\n"
            + $"Dimensioni del libro:{larghezza} cm x {altezza}cm x {profondita} cm" + "\n"
            + "Informazioni Amazon:" + "\n"
            + $"Numero di recensioni: {numeroRecensioni} recensioni" + "\n"
            + $"Valutazione media: {valutazione} stelline" + "\n"
            +"\n"
            + "-------------------------------------------------------------------" + "\n"

            );
        if (versioneKindle && copertinaFlessibile == true)
        {
            Console.WriteLine($"------------------INFO AGGIUNTIVE----------------------------------" + "\n"
                +"\n"
                + "La versione kindle è disponibile!" + "\n"
                + "La versione con copertina flessibile è disponibile!" + "\n"
                +"\n"
                + "-------------------------------------------------------------------"

                );
        }

    }
}