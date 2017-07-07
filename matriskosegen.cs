static void Main(string[] args)
        {
            int toplam=0,toplam2=0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
                
              

            }
            for (int i=0; i<n; i++)
            {
                toplam = (a[0][2] + a[1][1] + a[2][0]);
                toplam2 = (a[0][0] + a[1][1] + a[2][2]);
            }
                int fark = toplam - toplam2;
                Console.WriteLine("mutlak deger =" + Math.Abs(fark));

              Console.ReadKey();
              
