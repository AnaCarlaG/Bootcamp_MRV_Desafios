using System; 

public class TeoremaDivisaoEuclidiana {

	public static void Main(string[] args) { 

            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int q, r = a%b;
            
            if (b > 0)
                r = a % b;
            
            if ( r < 0 ) 
              r = r + Math.Abs(b);
              
            q = ( a - r ) / b;
            a = b * q + r;

            Console.WriteLine("{0} {1}", q, r);
    }
}