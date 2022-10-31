using System;
using System.Threading;
namespace cronometro
{
  class Cronom
  {
    static void Main()
    { 
      start(); 
    } 
    static void start()
    {  
      int val=0;// a variavel tem q ser cadastrada fora do loop 
      int time =10; 
        while (val<time)
       { 
          Console.Clear(); // limpar a tela dando a impressão de contagem e não poluido a tela
          val++; // no incremento não presciso por "=" posso por apenas "val++" que ja vai add mais 1
          Console.WriteLine(val);
          Thread.Sleep(1000);// deixa a aplicação mais lenta esta dentro de System.threading
       }

    }
  }
  
}