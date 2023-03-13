// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        string ulang = "";
        do
        {
            Console.Write(
                "Selamat Datang di Program Perhitungan" +
                "\nMenu Operasi (+, -, *, :)" +
                "\n(angka)(operasi)(angka)=" +
                "\nInput Operasi : "
            );

            string input = Console.ReadLine();
            char[] operasi = { '+', '-', '*', ':' };
            int posisi = input.IndexOfAny(operasi);
            int posisisd = input.IndexOf('=');
            int pp = input.Length - (posisi + 1) - 1;
            int a1 = Convert.ToInt32(input.Substring(0, posisi));
            int a2 = Convert.ToInt32(input.Substring(posisi + 1, pp));
            char execute = input[posisi];
            int hasil;

            switch (execute)
            {
                case '+':
                    // int a1, angka2;
                    hasil = a1 + a2;
                    Console.WriteLine($"Hasil dari {input}{hasil}");
                    break;
                case '-':
                    // int a1, angka2;
                    hasil = a1 - a2;
                    Console.WriteLine($"Hasil dari {input}{hasil}");
                    break;
                case ':':
                    // int a1, angka2;
                    hasil = a1 / a2;
                    Console.WriteLine($"Hasil dari {input}{hasil}");
                    break;
                case '*':
                    // int a1, angka2;
                    hasil = a1 * a2;
                    Console.WriteLine($"Hasil dari {input}{hasil}");
                    break;
                default:
                    Console.WriteLine("Maaf yang anda inputkan tidak tersedia");
                    break;
            }
            Console.WriteLine("\nApakah anda akan melakukan Program Perhitungan lagi? (ya/tidak)");
            ulang = Console.ReadLine();
        } while (ulang == "ya");
        Console.WriteLine("Terimakasih telah melakukan program perhitungan ini \nHave a nice day!!");

    }
}