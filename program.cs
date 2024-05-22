using System
class Program
{
    static void Main()
    {
        Dizileri_Tanımlama();







    }
    static void Dizileri_Tanımlama()
{
        #region Dizileri tanımlama
        string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Mamut", "Kurbağa", "At" };
        int[] dizi;
        dizi = new int[5];
        renkler[0] = "mavi";
        dizi[3] = 10;
        Console.WriteLine(hayvanlar[3]); Console.WriteLine(dizi[3]); Console.WriteLine(renkler[0]);
        // Döngülerle Dizi Kullanımı
        // klavyeden girilen n tane sayınının ortalamasını alma
        Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");

        int diziler=int.Parse(Console.ReadLine());
        int[] sayıdizisi = new int[diziler];

        for (int i = 0; i < diziler; i++)
        {
            Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i+1);
            sayıdizisi[i]=int.Parse(Console.ReadLine());
        }
        int toplam = 0;

        foreach (var sayi in sayıdizisi)
        {
            toplam += sayi;
            
        
        }
        Console.WriteLine("Ortalaması : " + toplam / diziler);
        #endregion

    }
}
