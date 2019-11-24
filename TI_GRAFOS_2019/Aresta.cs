using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_GRAFOS_2019
{
    class Aresta
    {
        private int v1;
        private int v2;
        private string textoAresta;

        public Aresta(Aresta _aresta)
        {
            this.v1 = _aresta.v1;
            this.v2 = _aresta.v2;
            this.textoAresta = _aresta.textoAresta;
        }
        public Aresta(int _v1, int _v2, string _aresta)
        {
            this.v1 = _v1;
            this.v2 = _v2;
            this.textoAresta = _aresta;
        }

        public int V1
        {
            get => this.v1;
        }
       public int V2
        {
            get => this.v2;
        }
        public string ArestaTexto
        {
            get => this.textoAresta;
        }
    }
}