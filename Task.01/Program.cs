using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Task._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            // 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir.
            //Console.Write("Ededi daxil et:");
            //int a = int.Parse(Console.ReadLine());

            //if (a >= 1000 & a <= 9999)
            //{
            //    int result = (70000 + a) * 10 + 4;
            //    Console.WriteLine($"Cavab: {result}");
            //}
            #endregion

            #region Task 2
            // 3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir.
            //Console.Write("Ededi daxil et:");

            //int a = int.Parse(Console.ReadLine());

            //if (a >= 100 & a <= 999)
            //{
            //    int result = (a * 1000) + a;

            //    Console.WriteLine($"Cavab: {result}");
            //}
            #endregion

            #region Task 3
            // 5 reqemli eded verilib. Bu ededin evvel  18 % sonra ise 3 % tap.
            //Console.Write("Ededi daxil et:");
            //int a = int.Parse(Console.ReadLine());

            //if (a >= 10000 & a <= 99999)
            //{
            //    double b = (a * 18) / 100;
            //    double result = (b * 3) / 100;
            //    Console.WriteLine($"Cavab: {result}");
            //}
            #endregion

            #region Task 4 
            // 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;
            //Console.Write("Ededi daxil et: ");
            //int a = int.Parse(Console.ReadLine());

            //if (a >= 100 & a <= 999)
            //{
            //    double b = (a * 10) + 7;
            //    double result = (b * 7) / 100;

            //    Console.WriteLine($"Cavab: {result}");
            //}
            #endregion

            #region Task 5
            // 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi ,
            //axirina ise 44 ededini artir. Alinan cavabin 44 % tap.

            //Console.Write("Ededi daxil et: ");
            //int a = int.Parse(Console.ReadLine());

            //if (a >= 1000 & a <= 9999)
            //{
            //    double b = (40000 + a) * 100 + 44;
            //    double result = (b * 44) / 100;

            //    Console.WriteLine($"Cavab: {result}");
            //}
            #endregion

            #region Task 6
            // 4 reqemli eded verilib. Bu ededin evvel 20%-ni
            //sonra ise cavabin 10% tap.  Alinan  cavabin kvadratini tap.  

            //Console.Write("Ededi daxil et: ");
            //int a = int.Parse(Console.ReadLine());

            //if (a >= 1000 & a <= 9999)
            //{
            //    double b = (a * 20) / 100;
            //    double c = (b * 10) / 100;
            //    double result = (c * c);

            //    Console.WriteLine($"Cavab: {result}");
            //}
            #endregion

            #region Task 7
            // 2 dene 5 reqemli eded verilib. Bu ededleri toplayib.
            //Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap

            //Console.Write("A: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a >= 10000 & a <= 99999)

            //Console.Write("B: ");
            //int b = int.Parse(Console.ReadLine());
            //if (b >= 10000 & b <= 99999)
            //{

            //}
            //double sum = a + b;
            //double add = (sum + 500000) * 10 + 5;
            //double result = (add * 5) / 10;

            //Console.WriteLine($"Cavab: {result}");
            #endregion

            #region Task 8
            // 2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
            // I ededin 4 % -ni tap.
            // Sonra II ededin 9 % ni tap.
            // Sonra Cavalari toplayib 10 % ni tap.

            //Console.Write("A:");
            //int a = int.Parse(Console.ReadLine());
            //if (a >= 1000 & a <= 9999)

            //Console.Write("B:");
            //int b = int.Parse(Console.ReadLine());
            //if (b >= 1000000 & b <= 9999999)
            //{ 

            //}

            //double x = (a * 4) / 100;
            //double y = (b * 9) / 100;
            //double z = (x + y);
            //double result = z / 10;

            //Console.WriteLine($"Cavab: {result}");
            #endregion

            #region Task 9
            // 3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla.
            // Alinan cavabin 10% tap.

            //Console.Write("A:");
            //int a = int.Parse(Console.ReadLine());
            //if (a >= 100000 & a <= 999999)

            //Console.Write("B:");
            //int b = int.Parse(Console.ReadLine());
            //if (b >= 100000 & b <= 999999)

            //Console.Write("C:");
            //int c = int.Parse(Console.ReadLine());
            //if (c >= 100000 & c <= 999999)
            //{

            //}

            //double x = (a / 10);
            //double y = (b / 10);
            //double z = (c / 10);
            //double f = (x + y + z);
            //double result = f / 10;

            //Console.WriteLine($"Cavab: {result}");
            #endregion

            #region Task 10
            // 3 dene 4 reqemli eded verilib.  I ededin 1%-ni, II ededin 2% , III ededin 3 % tap. 
            //Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel


            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());
            if (a >= 1000 & a <= 9999)

                Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());
            if (b >= 1000 & b <= 9999)

                Console.Write("C: ");
            int c = int.Parse(Console.ReadLine());
            if (c >= 1000 & c <= 9999)
            {

            }
            double x = a / 10;
            double y = (b * 2) / 100;
            double z = (c * 3) / 100;
            double result = (x - y - z) + (c * 7) / 100;


            Console.WriteLine($"Cavab: {result}");
            #endregion

            #region Task 11
            // 4 dene 5 reqemli eded verilib.Her I ededin ustune III ededi gel.
            // II ededin usutune IV eeddi gel. 
            //Sonra cavablari vur birbirine. Alinan neticeden III ededin 3 % -ni cix.


            //Console.Write("A: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a >= 10000 & a <= 99999)

            //Console.Write("B: ");
            //int b = int.Parse(Console.ReadLine());
            //if (b >= 10000 & b <= 99999)

            //Console.Write("C: ");
            //int c = int.Parse(Console.ReadLine());
            //if (c >= 10000 & c <= 99999)

            //Console.Write("D: ");
            //int d = int.Parse(Console.ReadLine());
            //if (d >= 10000 & d <= 99999)
            //{

            //}
            //long x = a + c;
            //long y = b + d;
            //long z = x * y;
            //long result = (z - (c * 3) / 100);

            //Console.WriteLine($"Cavab: {result}");
            #endregion

            #region Task 12
            //4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla.
            //Sonra hamisinin 15 faizini tap ve topla. 
            //Sonra yekunda alinanlar iki cavabi vur biri birine.
            //Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.

            //Console.Write("A: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a >= 100000 & a <= 999999)


            //Console.Write("B: ");
            //int b = int.Parse(Console.ReadLine());
            //if (b >= 100000 & b <= 999999)


            //Console.Write("C: ");
            //int c = int.Parse(Console.ReadLine());
            //if (c >= 100000 & c <= 999999)


            //Console.Write("D: ");
            //int d = int.Parse(Console.ReadLine());
            //if (d >= 100000 & d <= 999999)
            //{
            //    double x = a * 0.1;
            //    double y = b * 0.1;
            //    double z = c * 0.1;
            //    double g = d * 0.1;
            //    double sum = x + y + g + z;

            //    double x1 = a * 0.15;
            //    double y1 = b * 0.15;
            //    double z1 = c * 0.15;
            //    double g1 = d * 0.15;
            //    double sum1 = x1 * y1 + z1 * g1;
            //    double sum2 = sum1 * sum;
            //    double result = (sum2 * 0.1 * 0.11);

            //    Console.WriteLine($"Cavab: {result}");
            //}
            #endregion

            #region Task 13
            //5 dene eded verilib.Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir.
            //5 reqemli ededlerin 5 % tap ,neticeleri vur bir birine. 
            // Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla.
            // Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.

            //Console.Write("A: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a >= 10000 & a <= 99999)

            //Console.Write("B: ");
            //int b = int.Parse(Console.ReadLine());
            //if (b >= 10000 & b <= 99999)

            //Console.Write("C: ");
            //int c = int.Parse(Console.ReadLine());
            //if (c >= 10000 & c <= 99999)

            //Console.Write("D: ");
            //int d = int.Parse(Console.ReadLine());
            //if (d >= 100 & d <= 999)

            //Console.Write("E: ");
            //int e = int.Parse(Console.ReadLine());
            //if (e >= 100 & e <= 999)
            //{
            //    double x = a * 0.05;
            //    double y = b * 0.05;
            //    double z = c * 0.05;
            //    double sum1 = x * y * z;
            //    double g = e * 0.03;
            //    double j = d * 0.05;
            //    double sum2 = g + j;
            //    double result = sum1 *0.1;
            //    double result2 = sum2 * 0.1;
            //    double result3 = result + result2;
            //    Console.WriteLine($"Cavab: {result3}");

            //}
            #endregion

            #region Task 14
            //6 dene 6 reqemli eded verilib.Evvel hamisini topla.
            //Sonra I ve III ededi bir birine yapishdir ve bir eded al.  
            //I neticeden II neticeni cix.Alinan cavabin 10 % tap.
            //Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11 % tap.

            //Console.Write("A: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a >= 100000 & a <= 999999)

            //Console.Write("B: ");
            //int b = int.Parse(Console.ReadLine());
            //if (b >= 100000 & b <= 999999)

            //Console.Write("C: ");
            //int c = int.Parse(Console.ReadLine());
            //if (c >= 100000 & c <= 999999)

            //Console.Write("D: ");
            //int d = int.Parse(Console.ReadLine());
            //if (d >= 100000 & d <= 999999)

            //Console.Write("E: ");
            //int e = int.Parse(Console.ReadLine());
            //if (e >= 100000 & e <= 999999)

            //Console.Write("F: ");
            //int f = int.Parse(Console.ReadLine());
            //if (f >= 100000 & f <= 999999)
            //{
            //    double result1 = (a + b + c + d + e + f);
            //    double result2 = (a * 10000000) + c;
            //    double result3 = (result1 - result2) * 0.1;
            //    double result4 = (result3 + e + f) * 0.11;
            //    Console.WriteLine($"Cavab: {result4}");
            //}
            #endregion

            #region Task 15

            //Console.Write("A: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a >= 100 & a <= 999)

            //Console.Write("B: ");
            //int b = int.Parse(Console.ReadLine());
            //if (b >= 100 & b <= 999)

            //Console.Write("C: ");
            //int c = int.Parse(Console.ReadLine());
            //if (c >= 1000 & c <= 9999)

            //Console.Write("D: ");
            //int d = int.Parse(Console.ReadLine());
            //if (d >= 1000 & d <= 9999)

            //Console.Write("E: ");
            //int e = int.Parse(Console.ReadLine());
            //if (e >= 10000 & e <= 99999)

            //Console.Write("F: ");
            //int f = int.Parse(Console.ReadLine());
            //if (f >= 10000 & f <= 99999)

            //Console.Write("G: ");
            //int g = int.Parse(Console.ReadLine());
            //if (g >= 100000 & g <= 999999)
            //{
            //    double result = a + b + (c * d); 
            //    double result2 = (result * 10) + 7 + (e * f);
            //    double result3 = result2 - ((a * b) * 10 + 1);
            //    double result4 = result3 + g;
            //    double result5 = result4 - (a + b + c + d);
            //    double result6 = result5 * 0.18 * 0.03 * 0.01;
            //    double end = result6 + (e + f);
            //    Console.WriteLine($"Cavab: {end}");
            //}
            #endregion

        }
    }
}