using advance.Genaric;

namespace advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region no Gematric swap 
            /*  int A = 10; int B = 20;
               Console.WriteLine($"A={A}");
               Console.WriteLine($"B={B}");
               helper<int>.SWAP( ref A,ref B );
               Console.WriteLine("aftre swap ");
               Console.WriteLine($"A={A}");
               Console.WriteLine($"B={B}");
                  double X= 2.3; double Y = 5.6;
                 Console.WriteLine($"A={X}");
                 Console.WriteLine($"B={Y}");
                 helper<double>.SWAP(ref A, ref B);
                 Console.WriteLine("aftre swap ");
                 Console.WriteLine($"A={A}");
                 Console.WriteLine($"B={B}");


                         point p01=new point (1,2);
                         point p02 = new point(10, 20);
                         Console.WriteLine(p01);
                         Console.WriteLine(p02);
                         helper<point>.SWAP(ref p01, ref p02);*/

            #endregion
            #region Gematric
         /*   int[] Number = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int Index = helper.SearchArry(Number, 6);
                Console.WriteLine($"index={Index}");*/
            #endregion
             
            Employee E01 = new Employee() { Id = 1 ,Name="MOSTY" ,Salary= 6000};
            Employee E02 = new Employee() { Id = 2, Name = "AHMED", Salary = 1000 };
            Console.WriteLine($"hashcode of employee 01={E01.GetHashCode()}  ");
            Console.WriteLine($"hashcode of employee 02={E02.GetHashCode()}  ");




            if (E01 == E02)

                Console.WriteLine("equal ");
            else Console.WriteLine("not equal");


            if (E01.Equals(E02)) Console.WriteLine("equal");
            else Console.WriteLine("not equal ");


            #region MyRegion
            int[] Numbers = { 21, 15, 17, 15, 14, 25 };
            foreach (int item in Numbers)
                Console.WriteLine($"{item}");
            helper.BubbleSort(Numbers);
         
            foreach (int item in Numbers) ;





            #endregion

            #region MyRegion
            Employee[] employees = new Employee[]
            {
              new Employee() { Id = 10 , Name="mosty"   ,Salary= 1000 },
              new Employee() { Id = 20 , Name ="fahed" , Salary=2000 } ,
              new Employee() { Id = 30 , Name="faha" , Salary=3000 } ,
              new Employee() { Id = 40 , Name = "MO7MAD" , Salary =4000 },
              };

            helper.<employees>.BubbleSort(employees);
                
             
            
            
            
            }




            #endregion


        
    }
}
