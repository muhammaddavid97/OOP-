using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass.Latihan
{
    public class Lat_5
    {
        public static void main()
        {
            Bilangan2 bil = new Bilangan2();
            int[] nums = new int[] { 4, 1, 3, 6, 5, 2 };

            Console.WriteLine("Sebelum elemen array di urutkan");
            foreach(var item in nums)
            {
                Console.WriteLine(item);
            }

            // pass by refference jadi ketika parameter melewati nilai argumen berupa referensi
            bil.sorting(nums);

            Console.WriteLine("Setelah elemen array di urutkan");
            foreach(var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Bilangan2
    {
        public void sorting(int[] arr)
        {
            Console.WriteLine("Menampilkan isi dari array : ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int temp = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[temp])
                    {
                        temp = j;
                    }
                }

                int swapp = arr[i];
                arr[i] = arr[temp];
                arr[temp] = swapp;
            }

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
