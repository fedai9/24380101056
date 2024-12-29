namespace _24380101056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Kaç öğrenci kaydetmek istiyorsunuz:");
                int ogrencisayisi = int.Parse(Console.ReadLine());

                string[,] ogrenciler = new string[ogrencisayisi, 7];
                double[] ortalamalar = new double[ogrencisayisi];

                for (int i = 0; i < ogrencisayisi; i++)
                {
                    Console.WriteLine($"\n{i + 1}. Öğrencinin bilgilerini giriniz:");

                    Console.Write("Numara:");
                    ogrenciler[i, 0] = Console.ReadLine();

                    Console.Write("Ad:");
                    ogrenciler[i, 1] = Console.ReadLine();
                    
                    Console.Write("Soyad:");
                    ogrenciler[i, 2] = Console.ReadLine();
                    
                    int vize;
                    while (true)
                    {
                        Console.Write("Vize Notu (0-100): ");
                        vize = int.Parse(Console.ReadLine());
                        if (vize >= 0 && vize <= 100) break;
                        Console.WriteLine("Hata: Vize notu 0 ile 100 arasında olmalıdır!");
                    }
                    ogrenciler[i, 3] = vize.ToString();

                    int final;
                    while (true)
                    {
                        Console.Write("Final Notu (0-100): ");
                        final = int.Parse(Console.ReadLine());
                        if (final >= 0 && final <= 100) break;
                        Console.WriteLine("Hata: Final notu 0 ile 100 arasında olmalıdır!");
                    }
                    ogrenciler[i, 4] = final.ToString();

                    double ortalama = (vize * 0.4) + (final * 0.6);
                    ortalamalar[i] = ortalama;
                    ogrenciler[i, 5] = ortalama.ToString();

                    string harfNotu;
                    if (ortalama >= 90) harfNotu = "AA";
                    else if (ortalama >= 80) harfNotu = "BA";
                    else if (ortalama >= 70) harfNotu = "BB";
                    else if (ortalama >= 60) harfNotu = "CB";
                    else if (ortalama >= 50) harfNotu = "CC";
                    else harfNotu = "FF";
                    ogrenciler[i, 6] = harfNotu;
                }

                Console.WriteLine("\nÖğrenci Bilgileri:");
                Console.WriteLine("Numara\tAd\tSoyad\tVize\tFinal\tOrtalama\tHarf Notu");
                for (int i = 0; i < ogrencisayisi; i++)
                {
                    Console.WriteLine($"{ogrenciler[i, 0]}\t{ogrenciler[i, 1]}\t{ogrenciler[i, 2]}\t{ogrenciler[i, 3]}\t{ogrenciler[i, 4]}\t{ogrenciler[i, 5]}\t\t{ogrenciler[i, 6]}");
                }

                double sinifOrtalamasi = 0;
                double enDusukNot = ortalamalar[0];
                double enYuksekNot = ortalamalar[0];

                for (int i = 0; i < ortalamalar.Length; i++)
                {
                    sinifOrtalamasi += ortalamalar[i];
                    if (ortalamalar[i] < enDusukNot) enDusukNot = ortalamalar[i];
                    if (ortalamalar[i] > enYuksekNot) enYuksekNot = ortalamalar[i];
                }
                sinifOrtalamasi /= ogrencisayisi;

                Console.WriteLine($"\nSınıf Ortalaması: {sinifOrtalamasi}");
                Console.WriteLine($"En Düşük Not: {enDusukNot}");
                Console.WriteLine($"En Yüksek Not: {enYuksekNot}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata var: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
