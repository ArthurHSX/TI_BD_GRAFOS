using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_GRAFOS_2019
{
    class Infraestrutura : Grafo
    {
        private List<Torre> torres;
        public Infraestrutura(List<Vertice> _listaVertices)
        {
            base.Lista_ADJ_Vertice = _listaVertices;
        }
    }
}
