internal class Program
{
        private static void Main(string[] args)
        {
                


                void ExibirMensagemDeBoasVindas()
                {
                        Console.WriteLine("🅢🅡🅔🅔🅝 🅢🅞🅤🅝🅓");
                        Console.WriteLine("");

                        Console.WriteLine("Bem Vindo ! ");
                        Console.WriteLine("");

                }

                void ExibirMenuDeOpcoes()
                {
                        Console.WriteLine("Digite 1 para registrar uma banda : ");
                        Console.WriteLine("Digite 2 para mostrar todas as bandas : ");
                        Console.WriteLine("Digite 3 para para avaliar uma banda  : ");
                        Console.WriteLine("Digite 4 para exibir a média de uma banda  : ");
                        Console.WriteLine("Digite -1 para sair : ");

                        Console.Write("\nDigite sua escolha:  ");
                        string opcaoEscolhida = Console.ReadLine()!;
                        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
                        switch (opcaoEscolhidaNumerica)
                        {
                                case 1:
                                        RegistrarBandas();
                                        Console.WriteLine("Você escolheu a opção : " + opcaoEscolhidaNumerica);
                                        break;

                                case 2:
                                        Console.WriteLine("Você escolheu a opção : " + opcaoEscolhidaNumerica);
                                        break;

                                case 3:
                                        Console.WriteLine("Você escolheu a opção : " + opcaoEscolhidaNumerica);
                                        break;

                                case 4:
                                        Console.WriteLine("Você escolheu a opção : " + opcaoEscolhidaNumerica);
                                        break;
                                case -1:
                                        Console.WriteLine("Programa encerrado, até mais !");
                                        break;
                                default:
                                        Console.WriteLine("Opcção inválida");
                                        break;

                        }

                        void RegistrarBandas()
                        {
                                Console.WriteLine("Registro de bandas : ");
                                Console.Write("Digite o nome da banda que deseja : ");
                                string nomeDaBanda = Console.ReadLine()!;
                                Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso !");
                                Thread.Sleep(2000);
                                ExibirMenuDeOpcoes();
                        }
                }
                ExibirMenuDeOpcoes();
                ExibirMensagemDeBoasVindas();
        }
}