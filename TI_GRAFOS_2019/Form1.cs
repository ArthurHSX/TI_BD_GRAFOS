using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_GRAFOS_2019
{
    public partial class Form1 : Form
    {
        private Infraestrutura infraestrutura;
        private List<Vertice> vertices;
        private int[] vetorBinario;
        private int contFuncionario, contEstagiaio;

        public Form1()
        {
            LeituraArquivo(ref vertices, ref vetorBinario);
            infraestrutura = new Infraestrutura(vertices, vetorBinario);
            this.contEstagiaio = 0; this.contFuncionario = 0;
            InitializeComponent();            
        }
        private void LeituraArquivo(ref List<Vertice> _listaVertices, ref int[] _vetorBinario)
        {

        }

        private void AtribuiFuncionario()
        {
            for(int i = 0; i < this.infraestrutura.ListaTorres.Count; i++)
            {
                if(i == 0 || VerificaEstradaTorre(this.infraestrutura.ListaTorres.ElementAt(i - 1),
                    this.infraestrutura.ListaTorres.ElementAt(i)))
                {
                    this.infraestrutura.ListaTorres.ElementAt(i).Funcionario = "ESTAGIÁRIO";
                    this.contEstagiaio++;
                }
                else
                {
                    this.infraestrutura.ListaTorres.ElementAt(i).Funcionario = "FUNCIONÁRIO";
                    this.contFuncionario++;
                }
            }
        }
        /// <summary>
        /// Método que verifica se existe um caminho ou uma ligação, onde a Torre "a" possui como torre adjacente a torre B
        /// entre a Torre.
        /// Pesquisa na lista de adjacencia da "Torre" se possui relação/ligação entre duas torres.
        /// </summary>
        /// <param name="_a">Parametro "pai"</param>
        /// <param name="_b">Paremetro "filho"</param>
        /// <returns></returns>
        private bool VerificaEstradaTorre(Torre _a, Torre _b)
        {
            foreach(Torre aux in _a.ListaADJ)
            {
                if(aux.Comparar(_b.ID))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
