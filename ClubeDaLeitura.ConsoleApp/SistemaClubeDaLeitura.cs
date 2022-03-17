using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class SistemaClubeDaLeitura
    {
        public Caixa[] caixa;
        public Revista[] revista;
        public Cadastro[] cadastro;
        public Emprestimo[] emprestimo;

        public void IniciarMenu()
        {


            Console.WriteLine("===================================== CLUBE DA LEITURA : MENU PRINCIPAL =====================================\n");
            Console.WriteLine("-Digite 1: Para acessar o menu da caixa.\n-Digite 2: Para acessar o menu da revista.\n" +
                "-Digite 3: Para acessar o menu de cadastro de amigo.\n-Digite 4: Para acessar o menu de emprestimo.\n-Digite 5: para fechar o programa\n");
            Console.WriteLine("==============================================================================================================\n");

            int opcaoDeMenu;
            Console.Write("Digite a opção desejada: ");
            opcaoDeMenu = int.Parse(Console.ReadLine());

            while (opcaoDeMenu == 1 || opcaoDeMenu == 2 || opcaoDeMenu == 3 || opcaoDeMenu == 4)
            {

                if (opcaoDeMenu == 1)
                {
                    AcessarMenuDaCaixa();
                }
                else if (opcaoDeMenu == 2)
                {
                    AcessarMenuDaRevista();
                }
                else if (opcaoDeMenu == 3)
                {
                    AcessarMenuDeCadastro();
                }
                else if (opcaoDeMenu == 4)
                {
                    AcessarMenuDeEmprestimo();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Opcão de menu invalida!!! \n");
                    Console.ResetColor();
                    Console.Write("Digite uma opção de menu valida: ");
                    opcaoDeMenu = int.Parse(Console.ReadLine());
                }
            }
        }

        public void AcessarMenuDaCaixa()
        {

            Console.Clear();

            Console.WriteLine("===================================== CLUBE DA LEITURA : MENU DA CAIXA =====================================\n");
            Console.WriteLine("-Digite 1: Para criar uma caixa.\n-Digite 2: Para editar uma caixa\n-Digite 3: Para visualizar as caixas existentes. \n-Digite 4: para sair do menu caixa\n");
            Console.WriteLine("==============================================================================================================\n");

            int opcaoDeMenuCaixa;
            Console.Write("Digite a opção desejada:");
            opcaoDeMenuCaixa = int.Parse(Console.ReadLine());
            Caixa caixa = new Caixa();
            Caixa[] caixas = new Caixa[3];
            while (opcaoDeMenuCaixa == 1 || opcaoDeMenuCaixa == 2 || opcaoDeMenuCaixa == 3)
            {
                if (opcaoDeMenuCaixa == 1)
                {

                    for (int i = 0; i < 3; i++)
                    {

                        Console.WriteLine("-Digite o numero da caixa: ");
                        caixa.numeroDaCaixa = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a cor da caixa: ");
                        caixa.corDacaixa = Console.ReadLine();
                        Console.WriteLine("Digite o que está na etiqueta da caixa: ");
                        caixa.etiqueta = Console.ReadLine();

                        caixas[i] = caixa;
                    }
                }
                else if (opcaoDeMenuCaixa == 2)
                {
                    int opcaoDeEdicaoDaCaixa;
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"CAIXA :{i + 1} ");
                        Console.WriteLine($"-Numero da caixa: {caixas[i].numeroDaCaixa}\n-Cor da Caixa: {caixas[i].corDacaixa}\n-Etiqueta da Caixa: {caixas[i].etiqueta}\n");
                    }
                    Console.WriteLine("Digite qual o numero da caixa que deseja editar: ");
                    opcaoDeEdicaoDaCaixa = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Digite a nova cor da caixa: ");
                    caixas[opcaoDeEdicaoDaCaixa].corDacaixa = Console.ReadLine();
                    Console.WriteLine("Digite a nova etiqueta da caixa: ");
                    caixas[opcaoDeEdicaoDaCaixa].etiqueta = Console.ReadLine();

                }
                else if (opcaoDeMenuCaixa == 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"CAIXA :{i + 1} ");
                        Console.WriteLine($"-Numero da caixa: {caixas[i].numeroDaCaixa}\n-Cor da Caixa: {caixas[i].corDacaixa}\n-Etiqueta da Caixa: {caixas[i].etiqueta}\n");
                    }
                }
                else if (opcaoDeMenuCaixa == 4)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Opcão de menu invalida!!! ");
                    Console.ResetColor();
                    Console.Write("Digite uma opção de menu valida: ");
                    opcaoDeMenuCaixa = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            IniciarMenu();
        }
        public void AcessarMenuDaRevista()
        {
            Console.Clear();

            Console.WriteLine("===================================== CLUBE DA LEITURA : MENU DA REVISTA =====================================\n");
            Console.WriteLine("-Digite 1: Para adicionar uma nova revista.\n-Digite 2: Para editar uma revista\n-Digite 3: Para visualizar as revistas existentes. \n-Digite 4: para sair do menu de revistas.\n");
            Console.WriteLine("==============================================================================================================\n");

            int opcaoDeMenuRevista;
            Console.Write("Digite a opção desejada:");
            opcaoDeMenuRevista = int.Parse(Console.ReadLine());
            Revista revista = new Revista();
            Revista[] revistas = new Revista[3];
            while (opcaoDeMenuRevista == 1 || opcaoDeMenuRevista == 2 || opcaoDeMenuRevista == 3)
            {
                if (opcaoDeMenuRevista == 1)
                {

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Digite o nome da revista: ");
                        revista.nomeDaRevista = Console.ReadLine();
                        Console.WriteLine("Digite o tipo de colecao: ");
                        revista.tipoDaColecao = Console.ReadLine();
                        Console.WriteLine();
                       
                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine($"CAIXA :{j + 1} ");
                            Console.WriteLine($"-Numero da caixa: {caixa[j].numeroDaCaixa}\n-Cor da Caixa: {caixa[j].corDacaixa}\n-Etiqueta da Caixa: {caixa[i].etiqueta}\n");
                        }
                        Console.WriteLine("-Digite o numero da caixa: ");
                        int caixaSelecionada = int.Parse(Console.ReadLine());
                        revista.caixa = caixa[caixaSelecionada];

                        revistas[i] = revista;
                    }
                }
                else if (opcaoDeMenuRevista == 2)
                {
                    int opcaoDeEdicaoDaRevista;
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Revista:{i + 1} ");
                        Console.WriteLine($"-Nome da revista: {revistas[i].nomeDaRevista}\n-Tipo da revista: {revistas[i].tipoDaColecao}\n-Numero da revista: {revistas[i].numeroDaRevista}\n" +
                            $"-Numero da Caixa da revista: {revistas[i].caixa}");
                    }
                    Console.WriteLine("Digite qual o numero da caixa que deseja editar: ");
                    opcaoDeEdicaoDaRevista = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Digite o novo nome da reivsta: ");
                    revistas[opcaoDeEdicaoDaRevista].nomeDaRevista = Console.ReadLine();
                    Console.WriteLine("Digite a nova etiqueta da caixa: ");
                    revistas[opcaoDeEdicaoDaRevista].tipoDaColecao = Console.ReadLine();
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"CAIXA :{j + 1} ");
                        Console.WriteLine($"-Numero da caixa: {caixa[j].numeroDaCaixa}\n-Cor da Caixa: {caixa[j].corDacaixa}\n-Etiqueta da Caixa: {caixa[j].etiqueta}\n");
                    }
                    Console.WriteLine("-Digite o numero da caixa: ");
                    int caixaSelecionada = int.Parse(Console.ReadLine());
                    revistas[opcaoDeEdicaoDaRevista].caixa = caixa[caixaSelecionada];
                }
                else if (opcaoDeMenuRevista == 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Revista:{i + 1} ");
                        Console.WriteLine($"-Nome da revista: {revistas[i].nomeDaRevista}\n-Tipo da revista: {revistas[i].tipoDaColecao}\n-Numero da revista: {revistas[i].numeroDaRevista}\n" +
                            $"-Numero da Caixa da revista: {revistas[i].caixa} ");
                    }
                }
                else if (opcaoDeMenuRevista == 4)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Opcão de menu invalida!!! ");
                    Console.ResetColor();
                    Console.Write("Digite uma opção de menu valida: ");
                    opcaoDeMenuRevista = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            IniciarMenu();

        }
        public void AcessarMenuDeCadastro()
        {
            Console.Clear();

            Console.WriteLine("===================================== CLUBE DA LEITURA : MENU DE CADASTRO DO AMIGO =====================================\n");
            Console.WriteLine("-Digite 1: Para criar um novo cadastro.\n-Digite 2: Para editar um cadastro\n-Digite 3: Para visualizar os cadastros. \n-Digite 4: para sair do menu de cadastros.\n");
            Console.WriteLine("========================================================================================================================\n");

            int opcaoDeMenuCadastro;
            Console.Write("Digite a opção desejada:");
            opcaoDeMenuCadastro = int.Parse(Console.ReadLine());
            Cadastro cadastro = new Cadastro();
            Cadastro[] cadastros = new Cadastro[3];
            while (opcaoDeMenuCadastro == 1 || opcaoDeMenuCadastro == 2 || opcaoDeMenuCadastro == 3)
            {
                if (opcaoDeMenuCadastro == 1)
                {

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Digite o nome do Amigo: ");
                        cadastro.nome = Console.ReadLine();
                        Console.WriteLine("Digite o nome do responsavel do amigo: ");
                        cadastro.nomeDoResponsavel = Console.ReadLine();
                        Console.WriteLine("Digite o telefone do Amigo: ");
                        cadastro.telefone = Console.ReadLine();
                        Console.WriteLine("Digite o endereço do Amigo: ");
                        cadastro.endereco = Console.ReadLine();

                        cadastros[i] = cadastro;
                    }
                }
                else if (opcaoDeMenuCadastro == 2)
                {
                    int opcaoDeEdicaoDoCadastro;
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Cadastro:{i + 1} ");
                        Console.WriteLine($"-Nome do Amigo: {cadastros[i].nome}\n-Nome do Responsavel: {cadastros[i].nomeDoResponsavel}\n-Numero de telefone do amigo: {cadastros[i].telefone}\n" +
                            $"-Endereço do amigo: {cadastros[i].endereco}");
                    }
                    Console.WriteLine("Digite qual o numero do cadastro que deseja editar: ");
                    opcaoDeEdicaoDoCadastro = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Digite o novo nome: ");
                    cadastros[opcaoDeEdicaoDoCadastro].nome = Console.ReadLine();
                    Console.WriteLine("Digite o novo nome do responsavel: ");
                    cadastros[opcaoDeEdicaoDoCadastro].nomeDoResponsavel = Console.ReadLine();
                    Console.WriteLine("Digite o novo telfone do amigo: ");
                    cadastros[opcaoDeEdicaoDoCadastro].telefone = Console.ReadLine();
                    Console.WriteLine("Digite o novo endereço: ");
                    cadastros[opcaoDeEdicaoDoCadastro].endereco = Console.ReadLine();


                }
                else if (opcaoDeMenuCadastro == 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Cadastro:{i + 1} ");
                        Console.WriteLine($"-Nome do Amigo: {cadastros[i].nome}\n-Nome do Responsavel: {cadastros[i].nomeDoResponsavel}\n-Numero de telefone do amigo: {cadastros[i].telefone}\n" +
                            $"-Endereço do amigo: {cadastros[i].endereco}");
                    }
                }
                else if (opcaoDeMenuCadastro == 4)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Opcão de menu invalida!!! ");
                    Console.ResetColor();
                    Console.Write("Digite uma opção de menu valida: ");
                    opcaoDeMenuCadastro = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            IniciarMenu();

        }
        public void AcessarMenuDeEmprestimo()
        {
            Console.Clear();

            Console.WriteLine("===================================== CLUBE DA LEITURA : MENU DE EMPRESTIMO =====================================\n");
            Console.WriteLine("-Digite 1: Para criar um emprestimo.\n-Digite 2: Para editar um emprestimo\n-Digite 3: Para visualizar as emprestimos existentes. \n-Digite 4: para sair do menu de emprestimos.\n");
            Console.WriteLine("==================================================================================================================\n");

            int opcaoDeMenuEmprestimo;
            Console.Write("Digite a opção desejada:");
            opcaoDeMenuEmprestimo = int.Parse(Console.ReadLine());
            Emprestimo emprestimo = new Emprestimo();
            Emprestimo[] emprestimos = new Emprestimo[3];
            while (opcaoDeMenuEmprestimo == 1 || opcaoDeMenuEmprestimo == 2 || opcaoDeMenuEmprestimo == 3)
            {
                if (opcaoDeMenuEmprestimo == 1)
                {

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine($"Cadastro:{i + 1} ");
                            Console.WriteLine($"-Nome do Amigo: {cadastro[i].nome}\n-Nome do Responsavel: {cadastro[i].nomeDoResponsavel}\n-Numero de telefone do amigo: {cadastro[i].telefone}\n" +
                                $"-Endereço do amigo: {cadastro[i].endereco}");
                        }

                        Console.WriteLine("Digite o numero do amigo que ira fazer o Emprestimo: ");
                        int cadastroEmprestimo = int.Parse(Console.ReadLine());
                        emprestimo.cadastro = cadastro[cadastroEmprestimo];

                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine($"Revista:{i + 1} ");
                            Console.WriteLine($"-Nome da revista: {revista[i].nomeDaRevista}\n-Tipo da revista: {revista[i].tipoDaColecao}\n-Numero da revista: {revista[i].numeroDaRevista}\n" +
                                $"-Numero da Caixa da revista: {revista[i].caixa} ");
                        }
                        int revistaEmprestimo = int.Parse(Console.ReadLine());
                        emprestimo.revista = revista[revistaEmprestimo];
                        revista[revistaEmprestimo].disponibilidadeDaRevista = false;
                        Console.WriteLine("Digite a data do emprestimo: ");
                        emprestimo.dataDoEmprestimo = DateTime.Now;
                        Console.WriteLine("Digite a data de devolução: ");
                        emprestimo.dataDaDevolucao = Convert.ToDateTime(Console.ReadLine());

                        emprestimos[i] = emprestimo;
                    }
                }
                else if (opcaoDeMenuEmprestimo == 2)
                {
                    int opcaoDeEdicaoDoEmprestimo;
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Cadastro:{i + 1} ");
                        Console.WriteLine($"-Nome do amigo: {emprestimos[i].cadastro.nome}\n-Nome da revista emprestada: {emprestimos[i].revista.nomeDaRevista}\n-Data do emprestimo: {emprestimos[i].dataDoEmprestimo}\n" +
                            $"-Data da devolução da revista: {emprestimos[i].dataDaDevolucao}");
                    }
                    Console.WriteLine("Digite qual o numero do emprestimo que deseja editar: ");
                    opcaoDeEdicaoDoEmprestimo = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Digite o numero do novo amigo que ira fazer o novo emprestimo: ");
                    int cadastroEmprestimo = int.Parse(Console.ReadLine());;
                    emprestimos[opcaoDeEdicaoDoEmprestimo].cadastro = cadastro[cadastroEmprestimo];

                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Cadastro:{j + 1} ");
                        Console.WriteLine($"-Nome do Amigo: {cadastro[j].nome}\n-Nome do Responsavel: {cadastro[j].nomeDoResponsavel}\n-Numero de telefone do amigo: {cadastro[j].telefone}\n" +
                            $"-Endereço do amigo: {cadastro[j].endereco}");
                    }
                   
                    
                    
                    Console.WriteLine("Digite o numero da nova revista que sera emprestada: ");
                    int revistaEmprestimo = int.Parse(Console.ReadLine());
                    emprestimos[opcaoDeEdicaoDoEmprestimo].revista = revista[revistaEmprestimo];
                    
                    Console.WriteLine("Digite a nova data do emprestimo: ");
                    emprestimos[opcaoDeEdicaoDoEmprestimo].dataDoEmprestimo = Convert.ToDateTime(Console.ReadLine()); 
                    Console.WriteLine("Digite a nova data de devolução: ");
                    emprestimos[opcaoDeEdicaoDoEmprestimo].dataDaDevolucao = Convert.ToDateTime(Console.ReadLine());


                }
                else if (opcaoDeMenuEmprestimo == 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Cadastro:{i + 1} ");
                        Console.WriteLine($"-Nome do Amigo: {emprestimos[i].cadastro.nome}\n-Nome da revista: {emprestimos[i].revista.nomeDaRevista}\n-Data do emprestimo: {emprestimos[i].dataDoEmprestimo}\n" +
                            $"-Data da devolução da revista: {emprestimos[i].dataDaDevolucao}");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Opcão de menu invalida!!! ");
                    Console.ResetColor();
                    Console.Write("Digite uma opção de menu valida: ");
                    opcaoDeMenuEmprestimo = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            IniciarMenu();

        }




    }
}
