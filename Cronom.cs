using System;
using System.Threading;
namespace cronometro
{
  class Cronom
  {
    static void Main()
    { 

      Start(5);
      
      
      
    } 
    static void Start(int time)
    {  
        int val=0;// a variavel tem q ser cadastrada fora do loop 
      
        while (val<time)
       { 
          Console.Clear(); // limpar a tela dando a impressão de contagem e não poluido a tela
          val++; // no incremento não presciso por "=" posso por apenas "val++" que ja vai add mais 1
          Console.WriteLine(val);
          Thread.Sleep(1000);// deixa a aplicação mais lenta esta dentro de System.threading
          
       }
       Console.WriteLine("acho q deu certo");
       Thread.Sleep(2500);
       
       Menu();
    }
    static void Menu()
       {
         Console.Clear();
         Console.WriteLine("s = segundos - ex: 10s = 10 segundos");
         Console.WriteLine("m = minutos - ex: 10m = 10 minutos");
         Console.WriteLine("0 = encerrar a aplicação");
         Console.WriteLine("vamos começar !!");

         string hr = Console.ReadLine().ToLower();// .ToLower = converte letras maiusculas em minusculas
         char type = char.Parse(hr.Substring(hr.Length-1,1));
         Console.WriteLine(hr);
         Console.ReadKey();
         
         //string var.Subtring seleciona um caracter na sequencia com os parametros (numero total de caract ,quantidade que será escolhida) ex: string bola .subtring(1,1) == b 1º posição 1 elemento.

         //string var .Length conta a quantidade de caracteres passado como parametro dentro de .substring da a quantidade total de posições deixando mais faciu add ou subtrair a quantidade e poder selecionar a letra q desejo
       }
        
  }
  
}