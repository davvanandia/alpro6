using System;

class pinAtm
{
    static void Main()
    {
        int pin = 11001100;
        int saldo = 10000000;

        Console.WriteLine("=TARIK TUNAI ATM=");

        Console.Write("Masukkan PIN: ");
        int inputPin = int.Parse(Console.ReadLine());

        if (inputPin == pin) {
            Console.WriteLine("Saldo Anda: " + saldo);
            Console.Write("Masukkan Nominal Penarikan: ");
            int nominal = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("RECEIPT: ");
            Console.WriteLine("Saldo Awal: " + saldo);
            Console.WriteLine("Nominal Penarikan: " + nominal);

            int saldoAkhir = 0;
            if (saldo >= nominal)
            {
                saldoAkhir = saldo - nominal;
                Console.WriteLine("BERHASIL!");
                Console.WriteLine("Saldo Akhir: " + saldoAkhir);
            } else
            {
                Console.WriteLine("Saldo Kurang");
            }

        } else
        {
            Console.WriteLine("PIN Salah");
        }
    }
}