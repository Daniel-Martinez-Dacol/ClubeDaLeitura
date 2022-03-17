using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Cadastro
    {
        public string nome, nomeDoResponsavel, telefone, endereco;

        public void visualizarCadastro()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------\n");
            Console.WriteLine($"\n-CADASTRO: \n-Nome: {this.nome}\nNome do Responsavel: {this.nomeDoResponsavel}\n" +
                $"-Telefone: {this.telefone}\n-Endereço: {this.endereco}\n");
            
        }
    }
}
