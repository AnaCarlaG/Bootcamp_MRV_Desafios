using System; 

class QuantidadePimentoes{

    static void Main(string[] args) { 

            int pimentoesAmarelos, pimentoesVermelhos, x;
            string[] pimentoes = Console.ReadLine().Split(' ');
            
            
            pimentoesAmarelos = Convert.ToInt32(pimentoes[0]);
            pimentoesVermelhos = Convert.ToInt32(pimentoes[1]);

            x = pimentoesAmarelos + pimentoesVermelhos; 
            Console.WriteLine("X = {0}", x);
    }
}