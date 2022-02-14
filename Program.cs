using System;

class Program
{
    static void Main()
    {
        string name;
        int note;
        string validation;
        int option;
        name = null;
        note = 0;
        do
        {
            Console.WriteLine();
            Console.WriteLine("1- Adicior Notas");
            Console.WriteLine("2- Ver Notas ");
            Console.WriteLine("3- Sair");
            Console.WriteLine();
            Console.WriteLine("Escolha sua Opção");
            option = Convert.ToInt32(Console.ReadLine());



            switch (option)
            {
                case 1:

                    Console.WriteLine("Qual o nome do Aluno?");
                    name = Console.ReadLine();
                    Console.WriteLine("O nome está correto? S ou N");
                    validation = Console.ReadLine().ToUpper();
                    if (validation == "S");
                    else{
                        System.Console.WriteLine("Retornando ao Inicio");
                        break;
                    }
                    Console.WriteLine("Qual a nota do Aluno?");
                    note = Convert.ToInt32(Console.ReadLine());


                    break;

                case 2:
                    if (name == null && note == 0)
                    {
                        Console.WriteLine("Ainda não há notas cadastradas");
                    }
                    else
                    {
                        Console.WriteLine("Aluno ="+" "+name +"\r\n"+"Nota ="+" " +note);
                    }
                    break;

                default:

                    break;


            }

        }
        while
            (option == 1 || option == 2);

    }
   
}




