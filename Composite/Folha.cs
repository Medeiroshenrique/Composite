using System;

namespace Composite
{
    public class Folha : Componente
    {
        public Folha(string nome):base(nome){}
        public override void Adicionar(Componente componente)
        {
            Console.WriteLine("Não conseguimos adicionar a folha, desculpe (⊙_⊙;)");
        }

        public override void Apagar(Componente componente)
        {
            Console.WriteLine("Não conseguimos apagar a folha, desculpe (⊙_⊙;)");
        }

        public override void Expor(int profundidade)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(new String('-', profundidade) + Nome);
            Console.ResetColor();
        }
    }
}
