using System;

namespace Composite {
    public class Program {
        static void Main(string[] args)
        {
            Composite raiz = new Composite("Raiz");
            raiz.Adicionar(new Folha("Folha X"));
            raiz.Adicionar(new Folha("Folha Y"));

            Composite composite = new Composite("Composite 1");
            composite.Adicionar(new Folha("Folha 1.X"));
            composite.Adicionar(new Folha("Folha 1.Y"));

            raiz.Adicionar(composite);
            raiz.Adicionar(new Folha("Folha separada"));

            Folha folha = new Folha("Outra folha separada");
            raiz.Adicionar(folha);
            raiz.Apagar(folha);

            raiz.Expor(1);

            Console.ReadKey();
        }
    }
}