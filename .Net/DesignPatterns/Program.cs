using System;
using DesignPatterns.FactoryMethod;
using ExecucaoAbstractFactory = DesignPatterns.AbstractFactory.ExecucaoAbstractFactory;

namespace DesignPatterns
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine(@"_____                                 _     _              _____ ____   ");
            Console.WriteLine(@"|  __ \                               | |   | |            |_   _/ __ \ ");
            Console.WriteLine(@"| |  | | ___  ___  ___ _ ____   _____ | | __| | ___  _ __    | || |  | |");
            Console.WriteLine(@"| |  | |/ _ \/ __|/ _ \ '_ \ \ / / _ \| |/ _` |/ _ \| '__|   | || |  | |");
            Console.WriteLine(@"| |__| |  __/\__ \  __/ | | \ V / (_) | | (_| | (_) | |     _| || |__| |");
            Console.WriteLine(@"|_____/ \___||___/\___|_| |_|\_/ \___/|_|\__,_|\___/|_|    |_____\____/ ");
            Console.WriteLine("\n\nCurso Fundamentos de Arquitetura de Software\n\n");
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Creational Patterns          Structural Patterns         Behavorial Patterns");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("1 - Abstract Factory         4 - Adapter                 7 - Command");
            Console.WriteLine("2 - Method Factory           5 - Facade                  8 - Strategy");
            Console.WriteLine("3 - Singleton                6 - Composite               9 - Observer");

            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("");

            switch (opcao.KeyChar)
            {
                case '1':
                    ExecucaoAbstractFactory.Executar();
                    break;
                case '2':
                    ExecucaoFactoryMethod.Executar();
                    break;
                case '3':
                    ExecucaoSingleton.Executar();
                    break;
                case '4':
                    ExecucaoAdapter.Executar();
                    break;
                case '5':
                    ExecucaoFacade.Executar();
                    break;
                case '6':
                    ExecucaoComposite.Executar();
                    break;
                case '7':
                    ExecucaoCommand.Executar();
                    break;
                case '8':
                    ExecucaoStrategy.Executar();
                    break;
                case '9':
                    ExecucaoObserver.Executar();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
