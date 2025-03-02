﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class AgentaEmTexto
    {

        //Desenvolva um algoritmo que solicite a entrada de nome, e-mail, telefone e RG de um determinado usuário
        //e grave em um arquivo de texto. Exiba as informações na tela a partir do arquivo de texto gerado.

        public static void Execute()
        {
            string acao = "";
            string caminho = "usuario.txt";
            string nome = "";
            string email = "";
            string telefone = "";
            string rg = "";

            Console.WriteLine("##########################");
            Console.WriteLine("##########################");
            Console.WriteLine("G- Gravar ################");
            Console.WriteLine("L- Ler ###################");
            Console.WriteLine("S - Sair #################");
            Console.WriteLine("##########################");
            Console.WriteLine("##########################");
            Console.Write("Digite uma operação: ");

            acao = Console.ReadLine().ToUpper();
            Console.WriteLine();

            while (acao != "S")
            {

                if (acao == "G")
                {
                    Console.Write("Informe seu nome: ");
                    nome = Console.ReadLine();

                    Console.Write("Informe seu e-mail: ");
                    email = Console.ReadLine();

                    Console.Write("Informe seu Telefone: ");
                    telefone = Console.ReadLine();

                    Console.Write("Informe seu RG: ");
                    rg = Console.ReadLine();

                    StreamWriter sw = new StreamWriter(caminho, true); //Implementa um TextReader que lê
                                                                       //caracteres de um fluxo de bytes em uma
                                                                       //codificação específica.

                    sw.WriteLine("Nome: " + nome);
                    sw.WriteLine("E-mail: " + email);
                    sw.WriteLine("Telefone: " + telefone);
                    sw.WriteLine("RG: " + rg);
                    sw.WriteLine("--------------------------------------------------");

                    sw.Close();
                }
                else if (acao == "L")
                {
                    StreamReader sr = new StreamReader(caminho);

                    while (sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }

                Console.WriteLine();
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("##########################");
                Console.WriteLine("##########################");
                Console.WriteLine("G- Gravar ################");
                Console.WriteLine("L- Ler ###################");
                Console.WriteLine("S - Sair #################");
                Console.WriteLine("##########################");
                Console.WriteLine("##########################");
                Console.Write("Digite uma operação: ");

                acao = Console.ReadLine().ToUpper();
                Console.WriteLine();
            }
        }
    }
}