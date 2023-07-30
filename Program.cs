// See https://aka.ms/new-console-template for more information
string[] renkler = new string[5];
string[] hayvanlar = {"kedi", "kopek", "kus", "maymun"};
int[] dizi;
dizi = new int[5];
renkler[0] = "mavi";
dizi[3] = 10;
Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

Console.WriteLine("Dizinin eleman sayisi: ");
int uzunluk = int.Parse(Console.ReadLine());
int[] sayidizisi = new int[uzunluk];
for ( int i = 0; i<uzunluk; i++)
{
    Console.WriteLine("Lutfen {0}. sayisini giriniz: ", i+1);
    sayidizisi[i] = int.Parse(Console.ReadLine());
}
int toplam = 0;
foreach (var sayi in sayidizisi)
{
    toplam += sayi;
}
Console.WriteLine("Ort: " + toplam/uzunluk);