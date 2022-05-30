int opcao;
do
{
    do
    {
        Console.Write("Qual exercicio deseja corrigir\n" +
            "Eexrcicio (1)\n" +
            "Eexrcicio (2)\n" +
            "Eexrcicio (3)\n" +
            "Eexrcicio (4)\n" +
            "Eexrcicio (5)\n" +
            "Eexrcicio (6)\n" +
            "Para sair (7)\n" +
            "Opção: ");
        if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 7)
        {
            Console.WriteLine("Opção invalida!");
        }
    } while (opcao < 1 || opcao > 7);

    Console.Clear();

    switch (opcao)
    {
        case 1:
            /*
            O código do programa abaixo efetua leitura de 10 valores inteiros. Em seguida o
            usuário envia um outro número X qualquer. O programa deverá enviar a mensagem
            “Valor X encontrado no array” se o valor X estiver presente em alguma posição do
            Array. Caso contrário, o programa deverá enviar a mensagem “Valor X não
            encontrado no array”. Implementar o programa na plataforma .NET – Visual Studio
            C# ou em ambiente online.
            */

            int[] valores = new int[10];
            int valorX;
            bool verificado;
            int contador = 0;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write($"Digite o {i + 1}° valor inteiro do Array: ");
                    if (!int.TryParse(Console.ReadLine(), out valores[i]))
                    {
                        i--;
                        Console.WriteLine("Valor inválido");
                    }
                } while (valores.Length < 10);
            }
            Console.Clear();
            do
            {
                verificado = true;
                Console.Write($"Digite um valor para procurar no Array: ");
                if (!int.TryParse(Console.ReadLine(), out valorX))
                {
                    Console.WriteLine("Valor inválido");
                    verificado = false;
                }
            } while (!verificado);

            for (int i = 0; i < 10; i++)
            {
                if (valorX == valores[i])
                {
                    contador++;
                }
            }
            if (contador > 0)
            {
                Console.WriteLine($"Valor {valorX} encontrado no Array {contador}x.");
            }
            else
            {
                Console.WriteLine("Valor não encontrado!");
            }
            break;

        case 2:
            /*
            Escrever um programa na Linguagem C# que permita a leitura das notas de uma
            turma de 10 alunos. Calcular a média da turma e contar quantos alunos obtiveram
            nota acima desta média calculada. Escrever a média da turma e o resultado da
            contagem.
            */
            double[] notas = new double[10];
            double mediaTurma = 0;
            int alunoAcimaM = 0;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write($"Nota do aluno {i + 1}: ");
                    if (!double.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 10)
                    {
                        i--;
                        Console.WriteLine("Nota inválida");
                    }
                } while (notas.Length < 10);
            }

            for (int i = 0; i < 10; i++)
            {
                mediaTurma += notas[i];
            }
            mediaTurma = mediaTurma / 10;
            for (int i = 0; i < 10; i++)
            {
                if (notas[i] > mediaTurma)
                {
                    alunoAcimaM++;
                }
            }
            Console.WriteLine($"A média da turma foi: {mediaTurma}");
            Console.WriteLine($"{alunoAcimaM} estão acima da média.");
            break;

        case 3:
            /*
            Escrever um programa com a Linguagem C# para ler um array Q de 10 posições
            (aceitar somente números positivos). Em seguida, exibir na console o valor do maior
            elemento de Q e a respectiva posição por ele ocupada no array.
            */

            double[] valoresx = new double[10];
            double maior = 0;
            int posicao = 0;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write($"Digite o valor positvo {i + 1}: ");
                    if (!double.TryParse(Console.ReadLine(), out valoresx[i]) || valoresx[i] < 0)
                    {
                        i--;
                        Console.WriteLine("Valor inválido");
                    }
                } while (valoresx.Length < 10);
            }
            for (int i = 0; i < 10; i++)
            {
                if (maior < valoresx[i])
                {
                    maior = valoresx[i];
                    posicao = i;
                }
            }
            Console.WriteLine($"O maior valor foi {maior} informado na {posicao + 1}° entrada.");
            break;

        case 4:
            /*
            Escrever um programa com a Linguagem C# para ler um array Q de 10 posições
            (aceitar somente números positivos). Em seguida, exibir na console o valor do
            menor elemento de Q e a respectiva posição por ele ocupada no array.
            */

            double[] valoresy = new double[10];
            double menor = 0;
            int posicaox = 0;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write($"Digite o valor positvo {i + 1}: ");
                    if (!double.TryParse(Console.ReadLine(), out valoresy[i]) || valoresy[i] < 0)
                    {
                        i--;
                        Console.WriteLine("Valor inválido");
                    }
                } while (valoresy.Length < 10);
            }
            menor = valoresy[0];
            for (int i = 0; i < 10; i++)
            {
                if (menor > valoresy[i])
                {
                    menor = valoresy[i];
                    posicao = i;
                }
            }
            Console.WriteLine($"O menor valor foi {menor} informado na {posicaox + 1}° entrada.");
            break;

        case 5:
            /*
            Escrever um programa com a Linguagem C# para Ler um array A de 10 números.
            Em seguida, ler mais um número e armazená-lo em uma variável X. Armazenar em
            um array M o resultado de cada elemento de A multiplicado pelo valor X. Logo após,
            exibir na console todos os elementos do array M.
            */

            double[] valorest = new double[10];
            double[] resultado = new double[10];
            double valorA;
            bool verificadoR;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write($"Digite o {i + 1}° valor: ");
                    if (!double.TryParse(Console.ReadLine(), out valorest[i]))
                    {
                        i--;
                        Console.WriteLine("Valor inválido");
                    }
                } while (valorest.Length < 10);
            }

            do
            {
                verificadoR = true;
                Console.Write("Digite um valor para multiplicar os anteriores: ");
                if (!double.TryParse(Console.ReadLine(), out valorA))
                {
                    Console.WriteLine("Valor inválido");
                    verificadoR = false;
                }
            } while (!verificadoR);

            Console.WriteLine("\nO resultado das multiplicações é: ");
            for (int i = 0; i < 10; i++)
            {
                resultado[i] = valorest[i] * valorA;
                Console.WriteLine($"{valorest[i]} * {valorA} = {resultado[i]}");
            }
            break;

        case 6:
            /*
            Escrever um programa com a Linguagem C# para ler 10 números e armazená-los
            em um array. Após a leitura total destes 10 números, o programa deverá exibir na
            console esses 10 números em ordem inversa.
            */

            double[] valoresZ = new double[10];

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write($"Digite o {i + 1}° valor: ");
                    if (!double.TryParse(Console.ReadLine(), out valoresZ[i]))
                    {
                        i--;
                        Console.WriteLine("Valor inválido");
                    }
                } while (valoresZ.Length < 10);
            }

            Console.WriteLine("\nOs valores informados ao contrário são: ");

            for (int i = 9; i > -1; i--)
            {
                Console.WriteLine($"{valoresZ[i]}");
            }
            break;

        case 7:
            return;
            break;
    }
} while (true);
