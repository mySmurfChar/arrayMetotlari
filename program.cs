namespace patika_arrays
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        int n = Convert.ToInt32(Console.ReadLine().Trim());

                        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                        Result.plusMinus(arr);
            */

            int[] sayiDizisi = new int[] { 32, 42, 64, 69, 20, 19, 21, 29, 30, 31, 32, };
            Console.WriteLine("**** Sırasız dizi ****");
            foreach (int sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Array.Sort(sayiDizisi);
            Console.WriteLine("**** Sıralı dizi ****");
            foreach (int sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            Array.Clear(sayiDizisi,0,2);
            Console.WriteLine("**** En küçük iki sayı gitti ****");
            foreach (int sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Array.Reverse(sayiDizisi);
            Console.WriteLine("**** Array Reverse ****");
            foreach (int sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }



            Console.WriteLine("**** 31 sayısının indis numarası ****");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 31));

            Console.WriteLine("**** Array Resize ****");
            Array.Resize<int>(ref sayiDizisi, 12);
            sayiDizisi[11] = 99;
            foreach (int sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }



        }
    }
}
