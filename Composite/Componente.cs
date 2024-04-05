using System;

namespace Composite
{
    public abstract class Componente
    {
        protected string Nome;
        public Componente(string nome) {
            Nome = nome;
        }

        public abstract void Adicionar(Componente componente);
        public abstract void Apagar(Componente componente);
        public abstract void Expor(int profundidade);
    }
}
