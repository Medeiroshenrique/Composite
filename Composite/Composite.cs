using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : Componente
    {
        private List<Componente> filhos = new List<Componente>();
        public Composite(string nome):base(nome)
        {
            
        }
        public override void Adicionar(Componente componente)
        {
            filhos.Add(componente);
        }

        public override void Apagar(Componente componente)
        {
            filhos.Remove(componente);
        }

        public override void Expor(int profundidade)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new String('-',profundidade) + Nome);
            Console.ResetColor();

            foreach (var componente in filhos) 
            {
                componente.Expor(profundidade + 2);
            }
        }
    }
}
