using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Program k = new Program();
            // k.kangaroo();
            //k.viralAdver();
            //k.sumpair();
            //k.AngryProfessor();
            k.CutStick();
            Console.ReadLine();
        }

        public void kangaroo()
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            if (v2 >= v1)
            {
                Console.WriteLine("NO");
            }
            else {
                int result = 0;
                while (result == 0)
                {
                    x1 = x1 + v1;
                    x2 = x2 + v2;
                    if (x1 == x2)
                    {
                        result = 1;
                        Console.WriteLine("YES");
                    }
                    else if (x1 > x2)
                    {
                        result = 1;
                        Console.WriteLine("NO");
                    }
                }

            }
            Console.ReadLine();
        }

        public void viralAdver()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int result = 2;
            int final = 0;
            for (int i = 1; i <= input; i++)
            {
                result = (result *3/ 2);
                final = final + result;
            }
            Console.WriteLine(result);
        }

        public void sumpair()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int result = 0;
            int count = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    result = ((a[i] + a[j]) % k);
                    if (result == 0)
                    {
                        count++;
                    }
                }
                
            }
            Console.WriteLine(count);
        }

        public void AngryProfessor()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (a[i] > 0)
                    {
                        count++;
                    }
                }
                if (count < k)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        public void CutStick()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            List<int> li = new List<int>();
            li = arr.ToList();
            int count = n;
            int i = 0;
            //li.Sort();
            //Console.WriteLine(li.Count());
            //foreach (var item in li)
            //{
            //    Console.WriteLine(item);
            //}
            //li.RemoveAt(i);
            //Console.WriteLine(li.Count());
            //int input = 0;
            while (li.Count != 0)
            {
                Console.WriteLine(li.Count());
               
                li.Sort();
                //foreach (var item in li)
                //{
                //    Console.WriteLine(item);
                //}
                //if(i<li.Count())
                //{
                //    input = li[i];
                //}

                for (int j = i; j < li.Count; j++)
                {
                    li[j] = li[j] - li[i];
                   
                    if (li[j] == 0)
                    {
                        li.RemoveAt(j);
                        break;
                        
                    }

                }

            }

        }
    }
}
    

    

