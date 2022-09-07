using System;

namespace exercicio1

{
    class Program
    {
        static void Main (string [] args)
        {
          // Instanciar objeto da classe Aluno
          Aluno a = new Aluno();

          //Digite o nome do Aluno
          Console.WriteLine("Digite o nome do Aluno: ");
          a.nome= Console.ReadLine();

          //Digite a primeira nota do Aluno
          Console.WriteLine("Digite a Primeira nota do Aluno");
          a.nota1 = double.Parse(Console.ReadLine());
          
          //Digite a segunda nota do Aluno
          Console.WriteLine("Digite a segunda nota do Aluno");
          a.nota2 = double.Parse(Console.ReadLine());

          //Exibir Mensagem
          a.Mensagem();
        }
    }
}
