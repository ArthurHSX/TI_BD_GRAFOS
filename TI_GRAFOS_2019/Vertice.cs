using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_GRAFOS_2019
{
    class Vertice
    {
        #region Especificações da classe Vertice
        /* Basicamente cada vértice corresponde a uma torre,
         * cada torre deve ter um ID, esse ID deve ser um número binário
         * que é baseado ao ID do banco.
         */
        #endregion
        private int id;
        private List<Aresta> arestas;
        private int grau;

        public Vertice(int _id, List<Aresta> _arestas)
        {
            this.id = _id;
            this.arestas = _arestas;
            this.CountGrau();
        }

        public List<Aresta> Arestas
        {
            get => arestas;
            set
            {
                arestas = value;
                this.CountGrau();
            }
        }

        private protected void CountGrau()
        {
            this.grau = this.arestas.Count;
        }
    }
}
