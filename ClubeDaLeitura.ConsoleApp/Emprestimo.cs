using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Emprestimo
    {
        public Cadastro cadastro;
        public Revista revista;
        public DateTime dataDoEmprestimo;
        public DateTime dataDaDevolucao;
        

       
        public void visualizarEmprestimos()
        {
            Console.WriteLine($"\n-Emprestimo:\n -Nome da Revista: {revista.nomeDaRevista}\n -Nome do Amigo: {cadastro.nome}\n" +
                $" -Data do emprestimo: {dataDoEmprestimo}\n -Data da devolução: {dataDaDevolucao}\n ");
        }
    }
}
