using System;

class pinAtmClean
{
    static void Main()
    {
        int pin = 11001100;
        int saldo = 10000000;

        Console.WriteLine("Masukkan PIN: ");
        int checkpin = int.Parse(Console.ReadLine());

        if (checkpin != pin)
        {
            Console.WriteLine("Akses Ditolak karna PIN salah");
            return;
        }

        Console.WriteLine("Saldo");
    }
}