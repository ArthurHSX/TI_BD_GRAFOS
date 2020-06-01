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

        public Grafo(){
        }
        public Grafo(List<Aresta> _lista_Arestas)
        {
            this.lista_ADJ_Vertice = new List<Vertice>();
            this.lista_Arestas = _lista_Arestas;
            this.MontaListaAdjacencia();
        }
        public List<Vertice> Lista_ADJ_Vertice
        {
            get => lista_ADJ_Vertice;
            set => lista_ADJ_Vertice = value;
        }
        internal List<Aresta> Lista_Arestas { get => lista_Arestas; set => lista_Arestas = value; }
        public void MontaListaAdjacencia()
        {
            Vertice vertice;

            foreach(Aresta aux in this.lista_Arestas)
            {
                vertice = new Vertice(aux.V1);

                if(VerificaVerticeDuplicado(vertice) == true)
                {
                    this.lista_ADJ_Vertice.ElementAt(aux.V1 - 1).ListaADJ.Add(new Vertice(aux.V2, null));
                }
                else
                {
                    this.lista_ADJ_Vertice.Add(vertice);
                    this.lista_ADJ_Vertice.ElementAt(aux.V1 - 1).ListaADJ.Add(new Vertice(aux.V2, null));
                    this.lista_ADJ_Vertice.Add(vertice = new Vertice(aux.V2));
                }
            }
            
        }        

        ///// <summary>
        ///// INCOMPLETO*******************.
        ///// Falta terminar de implementar!!!!
        ///// </summary>
        //public void MontaListaAdjacenciaCompleto()
        //{
        //    Vertice vertice1;
        //    Vertice vertice2;
        //    //Aresta aresta;
        //    int cont = 0;

        //    foreach (Aresta aux in lista_Arestas)
        //    {
        //        //aresta = new Aresta(this.lista_Arestas.ElementAt(0));
        //        vertice1 = new Vertice(aux.V1);
        //        vertice2 = new Vertice(aux.V2);

        //        if (VerificaVerticeDuplicado(vertice1) == true)
        //        {
        //            //this.lista_ADJ_Vertice.ElementAt(cont).ListaADJ.Add(new Vertice(aresta.V2));
        //            this.lista_ADJ_Vertice.ElementAt(cont).ListaADJ.Add(new Vertice(aux.V2));
        //            // Estou reaproveitando a variável "vertice" para o segundo vertice "v2"                    
        //            if(VerificaVerticeDuplicado(vertice2) == false)
        //            {
        //                this.lista_ADJ_Vertice.Add(vertice2);
        //            }
        //            else
        //            {
        //                /*  Chamo o metodo procura passando como parâmetro o "vertice2", o método me retorna o indice que,
        //                 *  o programa vai no elemento da lista onde tá esse índice e adiciono uma ligação com o vertice1 
        //                 */
        //                this.lista_ADJ_Vertice.ElementAt(ProcuraVertice(vertice2)).ListaADJ.Add(vertice1);
        //            }
        //        }
        //        else
        //        {
        //            this.lista_ADJ_Vertice.Add(vertice1);
        //            //this.lista_ADJ_Vertice.ElementAt(cont).ListaADJ.Add(new Vertice(aresta.V2));
        //            this.lista_ADJ_Vertice.ElementAt(cont).ListaADJ.Add(new Vertice(aux.V2));
        //        }
        //        cont++;
        //    }

        //}

        //private int ProcuraVertice(Vertice aux)
        //{
        //    int indice = int.MinValue;
        //    for(int i = 0; i < this.lista_ADJ_Vertice.Count; i++)
        //    {
        //        if(aux.Comparar(lista_ADJ_Vertice.ElementAt(i)) == true)
        //        {
        //            indice = i;
        //            break;
        //        }
        //    }

        //    return indice;
        //}

        //public Vertice ProcuraVertice(Vertice _vertice, List<Vertice> _lista)
        //{
        //    Vertice aux = new Vertice();
        //    for (int i = 0; i < _lista.Count; i++)
        //    {
        //        if (_vertice.Comparar(_lista.ElementAt(i))) {
        //            aux = _lista.ElementAt(i);
        //            break;
        //        }
        //    }
        //    return aux;
        //}

        private bool VerificaVerticeDuplicado(Vertice _vertice)
        {
            foreach(Vertice aux in this.lista_ADJ_Vertice)
            {
                if(aux.Comparar(_vertice) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}