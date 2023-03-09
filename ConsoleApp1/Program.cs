namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.Clear();

                Console.WriteLine("Calculadora");

                Console.WriteLine();

                Console.WriteLine("Digite 1 para Somar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");
                Console.WriteLine("Digite 5 para gerar a tabuada");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5")
                {
                    Console.WriteLine("Operação Inválida, tente novamente!");
                    Console.ReadLine();
                    continue;
                }

                if (operacao == "5")
                {
                    Console.WriteLine("Digite o número para gerar a tabuada");
                    int tabuada = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i <= 10; i++)
                    {

                    
                    
                        int resultadoMultiplicacao = tabuada * i;

                        Console.WriteLine(tabuada + "x" + i + "=" + resultadoMultiplicacao);

                    }

                    #region motando a tabuada com While
                    //int numero = 1;

                    //while (numero <= 10)
                    //{
                    //    int resultadoMultiplicacao = tabuada * numero;

                    //    Console.WriteLine(tabuada + "x" + numero + "-" + resultadoMultiplicacao)

                    //    numero = numero +1;
                    //}
                    #endregion 

                    Console.ReadLine();
                    continue;
                }
            Console.WriteLine();
                Console.Write("Digite o primeiro número: ");

                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite o segundo número: ");

                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                switch (operacao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;
                    case "2": resultado = primeiroNumero - segundoNumero; break;
                    case "3": resultado = primeiroNumero * segundoNumero; break;
                    case "4":
                        {
                            while (segundoNumero == 0)
                            {
                                Console.WriteLine("O segundo número não pode ser ZERO, tente novamente.");

                                Console.ReadLine();

                                Console.Write("Digite o segundo número: ");

                                segundoNumero = Convert.ToInt32(Console.ReadLine());
                            }

                            resultado = primeiroNumero / segundoNumero;
                        }
                        break;

                    default: 
                        break;
                }

                #region verifica operações com "if-else if"
                //if (operacao == "1")
                //{
                //    resultado = primeiroNumero + segundoNumero;
                //}
                //else if (operacao == "2")
                //{
                //    resultado = primeiroNumero - segundoNumero;
                //}
                //else if (operacao == "3")
                //{
                //    resultado = primeiroNumero * segundoNumero;
                //}
                //else if (operacao == "4")
                //{
                //    while (segundoNumero == 0)
                //    {
                //        Console.WriteLine("O segundo número não pode ser ZERO, tente novamente.");

                //        Console.ReadLine();

                //        Console.Write("Digite o segundo número: ");

                //        segundoNumero = Convert.ToInt32(Console.ReadLine());
                //    }

                //    resultado = primeiroNumero / segundoNumero;
                //}
                #endregion

                decimal resultadoFormatado = Math.Round(resultado, 2);

                Console.WriteLine("o resultado da sua operação é: " + resultadoFormatado);

                Console.ReadLine();

            } while (true);
         
        }

    }

}

#region minnha resolução

//            {

//                while (true)
//                {


//                    double num1;
//                    double num2;


//                    Console.WriteLine("Calculaddora Dona Mariana\n");

//                    Console.WriteLine("Qual a operação desejada?");
//                    Console.WriteLine(" 1 Adição         ");
//                    Console.WriteLine(" 2 Subtração      ");
//                    Console.WriteLine(" 3 Multiplicação  ");
//                    Console.WriteLine(" 4 Divisão        ");
//                    Console.WriteLine(" Digite S para sair  ");



//                    string operacao = Console.ReadLine();

//                    Console.WriteLine("Digite o primeiro número");
//                    num1 = double.Parse(Console.ReadLine());

//                    Console.WriteLine("Digite o segundo número");
//                    num2 = double.Parse(Console.ReadLine());



//                    if (operacao == "S" || operacao == "s")
//                    {
//                        break;
//                    }

//                    if (num2 == 0)
//                    {
//                        Console.WriteLine("Seu segundo numero precisa ser diferente de zero!");
//                        Console.WriteLine("Digite o segundo número novamente");
//                        num2 = double.Parse(Console.ReadLine());
//                    }

//                    if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4")
//                    {
//                        Console.WriteLine("operação inválida, tente novamente!");
//                        Console.WriteLine();
//                        continue;
//                    }

//                    switch (operacao)
//                    {

//                        case "1":
//                            {
//                                double resultado = num1 + num2;

//                                Console.WriteLine("O resultado da sua equação foi de: " + resultado);
//                                break;
//                            }



//                        case "2":
//                            {
//                                double resultado = num1 - num2;

//                                Console.WriteLine("O resultado da sua equação foi de: " + resultado);
//                                break;
//                            }



//                        case "3":
//                            {
//                                double resultado = num1 * num2;

//                                Console.WriteLine("O resultado da sua equação foi de: " + resultado.ToString("N2"));
//                                break;
//                            }


//                        case "4":
//                            {
//                                double resultado = num1 / num2;

//                                Console.WriteLine("O resultado da sua equação foi de: " + resultado);
//                                break;
//                            }



//                        default:
//                            {
//                                Console.WriteLine("Opção Invalida!!!");

//                                break;
//                            }


//                    }
//                    Console.ReadLine();
//                    Console.Clear();
//                }
//            }
//        }
//    }
//}
#endregion

