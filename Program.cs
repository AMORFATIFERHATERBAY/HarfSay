using System;

namespace calisma01
{
    class Program
    {

        static void Sirala(int[] sayi, char[] harf)
        {
           
            int gecici, j;
            char chGeciciHarf;
            for (int i = 0; i < sayi.Length; ++i)
            {
                for (j = i + 1; j < sayi.Length; j++)
                    if (sayi[i] < sayi[j])
                    {
                        gecici = sayi[i];
                        chGeciciHarf = harf[i];
                        sayi[i] = sayi[j];
                        harf[i] = harf[j];
                        sayi[j] = gecici;
                        harf[j] = chGeciciHarf;
                    }



            }
           
        }

        static void HarfBul(string cümle)
        {
            //int toplam = 0;
            char[] butunharfler = new char[35];
            int[] sayi = new int[35];
            char[] harf = cümle.ToCharArray(0, cümle.Length);
            char gecici;
            int sonIndex = 0;
            //int i=0;
            Array.Sort(harf);
            for (int i = 0; i < harf.Length; ++i)
            {
                gecici = harf[i];
                bool eslestimi = false;


                for (int j = 0; j < butunharfler.Length; ++j)
                {
                    if (gecici.ToString().ToLower() == butunharfler[j].ToString())
                    {
                        eslestimi = true;
                        sayi[j]++;
                        break;

                    }
                }
                if (!eslestimi)
                {
                    butunharfler[sonIndex] = gecici;
                    sayi[sonIndex] = 1;
                    sonIndex++;

                }



                // //butunharfler[0]=harf[i];
                // Console.WriteLine(eslestimi);
                // if (harf[i].ToString().ToLower() == "a")
                //     toplam++;

            }
            int k;
            Sirala(sayi, butunharfler);
         
            for (k = 0; k < sonIndex; ++k)
            {


                Console.WriteLine("{0,2} Adet --> {1,2} bulundu ", sayi[k], butunharfler[k]);
            }

            //Console.WriteLine($"{toplam} adet A bulundu.");
            // for(int i=0; i<=sayi.GetUpperBound(0); ++i)
            // {
            //     Console.WriteLine("{0,2} Adet --> :" , sayi[i]);
            //     for (int j=0; j<butunharfler.GetUpperBound(0); j++)
            //     Console.WriteLine("{1,2} :" ,  butunharfler[j]);
            // }


        }
        static float ToCelcius(float fahrenayt)
        {
            return ((float)5 / 9) * (fahrenayt - 32);
        }
        static double ToFahrenayt(float celcius)
        {
            return (9d / 5) * (celcius) + 32;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // c=(5/9)*(f-32)
            Console.WriteLine("Fahrenayt'dan Celciusa'a dönüşüm için : C/c");
            Console.WriteLine("Celsiusdan  Fahrenayt'a dönüşüm için : F/f");
            Console.Write("Seçiminizi Yapınız.");
            string secim = Console.ReadLine();
            if (secim.ToLower() == "c")
            {
                Console.Write("fahranayt değerini giriniz :");
                float fah = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("{0} Cel", ToCelcius(fah));

            }
            else if (secim.ToLower() == "f")
            {
                Console.Write("celcius değerini giriniz :");
                float cel = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("{0} Fah", ToFahrenayt(cel));
            }
            else
            {
                Console.WriteLine("yanlış seçim");
            }


            Console.Write("Cümleyi giriniz :");
            string cümle = Console.ReadLine();
            HarfBul(cümle);
            // char[] harf = cümle.ToCharArray(0, cümle.Length);
            // Console.WriteLine(harf);
            // Console.WriteLine(harf[3]);
            // Console.WriteLine(harf.Length);
            // Console.WriteLine(harf.GetUpperBound(0));



        }
    }
}
