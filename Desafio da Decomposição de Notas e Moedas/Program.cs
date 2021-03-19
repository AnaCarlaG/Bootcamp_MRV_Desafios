using System; 

public class ValorMonetario {

  public static void Main(string[] args) { 

            decimal valor;
            int nota, auxMoedas;

            
            valor = Convert.ToDecimal(Console.ReadLine().Replace(",","."));

	  		valor = Math.Round(valor,2);
            nota = (int)valor;
            auxMoedas = (int)((valor - nota)*100);


            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", nota/100);
            nota = nota - ((nota/100) * 100);
            
            Console.WriteLine("{0} nota(s) de R$ 50.00", nota/50);
            nota = nota - ((nota/50) * 50);
            
            Console.WriteLine("{0} nota(s) de R$ 20.00", nota/20);
            nota = nota - ((nota/20) * 20);
            
            Console.WriteLine("{0} nota(s) de R$ 10.00", nota/10);
            nota = nota - ((nota/10) * 10);
            
            Console.WriteLine("{0} nota(s) de R$ 5.00", nota/5);
            nota = nota - ((nota/5) * 5);

            Console.WriteLine("{0} nota(s) de R$ 2.00", nota/2);
            nota = nota - ((nota/2) * 2);

            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", nota);
  
            Console.WriteLine("{0} moeda(s) de R$ 0.50", auxMoedas / 50);
            auxMoedas = auxMoedas % 50;

            Console.WriteLine("{0} moeda(s) de R$ 0.25", auxMoedas / 25);
            auxMoedas = auxMoedas % 25;
	  
	  		    Console.WriteLine("{0} moeda(s) de R$ 0.10", auxMoedas / 10);
            auxMoedas = auxMoedas % 10;
            
            Console.WriteLine("{0} moeda(s) de R$ 0.05", auxMoedas / 5);
            auxMoedas = auxMoedas % 5;
            
            Console.WriteLine("{0} moeda(s) de R$ 0.01", auxMoedas);
  }

}