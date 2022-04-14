using Csharp_Shop_2;

Console.WriteLine("BENVENUTO NEL MIO PROGRAMMA!\n");

Acqua acqua = new Acqua("Sant'anna", "Acqua più fresca non esiste!", 3, 11, 1, 7.6, "Monte Bianco");

acqua.stampaProdotto();
acqua.bevi(0.5);
Console.WriteLine(acqua.litri);
acqua.riempi(0.6);
Console.WriteLine(acqua.litri);
acqua.svuota();
Console.WriteLine(acqua.litri);

try
{
    acqua.bevi(1);
} catch (Exception e) {
    Console.WriteLine("MESSAGGIO DI ERRORE: " + e.Message);    
}


