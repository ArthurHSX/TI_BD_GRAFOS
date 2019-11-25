using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TI_GRAFOS_2019
{
    public partial class Form1 : Form
    {
        private Infraestrutura infraestrutura;
        private List<Vertice> vertices;
        private string[] vetorBinario;
        private int contFuncionario, contEstagiario;

        public Form1()
        {
            InitializeComponent();
            LeituraArquivo(ref vertices, ref vetorBinario);
            this.textBox1.Text = "Pressione o botão INICAR";
            this.textBox1.TextAlign = HorizontalAlignment.Center;
            this.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox1.TextAlign = HorizontalAlignment.Left;
            this.Refresh();
            infraestrutura = new Infraestrutura(vertices, vetorBinario);
            this.contEstagiario = 0; this.contFuncionario = 0;
            AtribuiFuncionario();

            // INSERIR A VARIÁVEL DO CUSTO MINIMO ******************************************
            this.textBox1.Text = ":] " + contEstagiario.ToString() + " " + contFuncionario.ToString();
            this.Refresh();
        }
        private void LeituraArquivo(ref List<Vertice> _listaVertices, ref string[] _vetorBinario)
        {
            try
            {
                Grafo grafo;

                string[] lines = File.ReadAllLines(@"ArquivoGrafos.txt");
                List<String> dados = new List<string>();
                string[] separador;
                List<Aresta> ListaAresta = new List<Aresta>();

                //Lendo a primeira linha do arquivo em tempo de execução.
                int numVertices = 0, numAresta = 0, cont = 0;
                separador = lines[0].Split(' ');
                numVertices = int.Parse(separador[0]); numAresta = int.Parse(separador[1]);
                //Criado o vetor de binários, correspondente ao número de vertices. Este bin será o código de cada torre.
                _vetorBinario = new string[numVertices];

                for (int i = 1; i < lines.Length; i++)
                {
                    if (i >= (numAresta + 1))
                    {
                        _vetorBinario[cont] = lines[i];
                        cont++;
                    }
                    else
                    {
                        separador = lines[i].Split(' ');
                        Aresta aresta = new Aresta(int.Parse(separador[0]), int.Parse(separador[1]), lines[i]);
                        ListaAresta.Add(aresta);
                    }
                }
                grafo = new Grafo(ListaAresta);
                _listaVertices = grafo.Lista_ADJ_Vertice;
                if(numAresta != ListaAresta.Count)
                {
                    throw new Exception("Valores diferentes");
                }
            }
            catch (Exception e) when (e.Message == "Valores diferentes")
            {
                string texto = "A quantidade de elementos na 'Lista de adjacência' é diferente" +
                               " da quantidade de elementos na 'Lista de Arestas'." +
                               "\n\n Verifique o método de leitura do arquivo" + 
                               "\n\n " + e.ToString();
                string titulo = "Erro na quantidade de elementos";

                MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtribuiFuncionario()
        {
            for(int i = 0; i < this.infraestrutura.ListaTorres.Count; i++)
            {
                if(i == 0 || !VerificaEstradaTorre(this.infraestrutura.ListaTorres.ElementAt(i - 1),
                    this.infraestrutura.ListaTorres.ElementAt(i)))
                {
                    this.infraestrutura.ListaTorres.ElementAt(i).Funcionario = "FUNCIONÁRIO";
                    //this.contEstagiario++;
                    this.contFuncionario++;
                }
                else
                {
                    this.infraestrutura.ListaTorres.ElementAt(i).Funcionario = "ESTAGIÁRIO";
                    //this.contFuncionario++;
                    this.contEstagiario++;
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
            foreach(Vertice aux in _a.ListaADJ)
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
