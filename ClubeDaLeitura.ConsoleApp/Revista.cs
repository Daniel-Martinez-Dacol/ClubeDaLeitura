using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Revista
    {
        public string nomeDaRevista, tipoDaColecao;
        public int numeroDaRevista;
        public DateTime anoDaRevista;
        public bool disponibilidadeDaRevista = true;
        public Caixa caixa;
    }
}
