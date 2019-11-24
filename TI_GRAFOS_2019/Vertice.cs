using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private int grau;
        private List<Vertice> lista_adj_vertices;
        //private List<Aresta> lista_Arestas;

        public Vertice() {
        }
        public Vertice(int _id)
        {
            this.id = _id;
            this.lista_adj_vertices = new List<Vertice>();
            //this.lista_Arestas = new List<Aresta>();
            this.CountGrau();
        }        
        public Vertice(int _id, List<Vertice> _listaVertices)
        {
            this.id = _id;
            this.lista_adj_vertices = _listaVertices;
            this.CountGrau();
            //this.lista_Arestas = null;//*******
        }

        //public Vertice(int _id, List<Vertice> _listaVertices, List<Aresta> _arestas)
        //{
        //    this.id = _id;
        //    this.lista_adj_vertices = _listaVertices;
        //    this.lista_Arestas = _arestas;
        //    this.CountGrau();
        //}

        public List<Vertice> ListaADJ
        {
            get => this.lista_adj_vertices;
            set
            {
                this.lista_adj_vertices = value;
                this.grau = this.lista_adj_vertices.Count;
            }
        }
        public int ID 
        { 
            get => id; 
            set => this.id = value; 
        }

        public int Grau { get => grau; }
        private protected void CountGrau()
        {
            
            this.grau = this.lista_adj_vertices.Count;         
            
        }
        public bool Comparar(Vertice _vertice)
        {
            return ( (this.id == _vertice.id) ? true : false );
        }
    }
}
