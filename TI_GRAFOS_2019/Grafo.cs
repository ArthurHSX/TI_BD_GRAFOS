using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_GRAFOS_2019
{
    class Grafo
    {
        private List<Vertice> lista_ADJ_Vertice;
        private List<Aresta> lista_Arestas;

        public Grafo(List<Aresta> _lista_Arestas)
        {
            this.lista_ADJ_Vertice = new List<Vertice>();
            this.lista_Arestas = _lista_Arestas;
        }
        public List<Vertice> Lista_ADJ_Vertice
        {
            get => lista_ADJ_Vertice;
            //set => lista_ADJ_Vertice = value;
        }
        
    }
}
