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
        public Infraestrutura(List<Vertice> _listaVertices, string[] _codigoTorre)
        {
            base.Lista_ADJ_Vertice = _listaVertices;
            this.torres = new List<Torre>();
            PreencheListaTorres(_codigoTorre);
        }
        public List<Torre> ListaTorres
        {
            get => this.torres;
        }
        
        private void PreencheListaTorres(string[] _codigo)
        {
            Torre torre;
            int cont = 0;
            foreach(Vertice aux in base.Lista_ADJ_Vertice)
            {
                torre = new Torre(_codigo[cont], aux.ID, null, aux.ListaADJ);
                this.torres.Add(torre);
                cont++;
            }
        }
    }
}
