using System; 

class URI {

    static void Main(string[] args) { 

                 double A, B, MEDIA;

            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            MEDIA = ((A * 3.5) + ( B*7.5)) /11;

            Console.WriteLine("MEDIA = {0}",MEDIA.ToString("F5"));

    }

}