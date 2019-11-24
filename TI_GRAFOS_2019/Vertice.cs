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

        internal List<Vertice> ListaADJ
        {
            get => this.lista_adj_vertices;
            set
            {
                this.lista_adj_vertices = value;
                this.grau = this.lista_adj_vertices.Count;
            }
        }
        protected int ID 
        { 
            get => id; set => this.id = value; 
        }

        protected int Grau { get => grau; }
        private protected void CountGrau()
        {
            try
            {
                if (this.lista_adj_vertices.Count != this.lista_Arestas.Count)
                {
                    this.grau = int.MaxValue;
                    throw new Exception("Valores diferentes");
                }
                this.grau = this.lista_adj_vertices.Count;
            }
            catch(Exception e) when (e.Message == "Valores diferentes")
            {
                string texto = "A quantidade de elementos na 'Lista de adjacência' é diferente" +
                               " da quantidade de elementos na 'Lista de Arestas'."+
                               "\n\n Verifique o método de leitura do arquivo";
                string titulo = "Erro na quantidade de elementos";

                MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public bool Comparar(Vertice _vertice)
        {
            return ( (this.id == _vertice.id) ? true : false );
        }
    }
}
