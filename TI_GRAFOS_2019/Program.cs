﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TI_GRAFOS_2019 {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());    
            TesteImplementacaoGrafo();
        }

        public static void LeituraArquivo() {

            //Arrumar o local do arquivo para a pasta debug! Não consegui mudar!
            string[] lines = File.ReadAllLines(@"C:\Users\Norton Souza\Source\Repos\TI_BD_GRAFOS\TI_GRAFOS_2019\bin\Debug\ArquivoGrafos.txt");
            List<String> dados = new List<string>();
            string[] separador;
            List<Aresta> ListaAresta = new List<Aresta>();
            foreach (string linha in lines) {
                separador = linha.Split(' ');
                Aresta aresta = new Aresta(int.Parse(separador[0]), int.Parse(separador[1]), linha);
                ListaAresta.Add(aresta);
            }

        }
        static void TesteImplementacaoGrafo() {
            #region ******Definição do grafo******
            /*      [V1]-----------------------[V5]]---------------[V6]
             *       |                        /
             *       |                      [V3]
             *       |                        \
             *      [V2]-----------------------[V4]      
             *      
             *      LISTA DE ADJACENCIA
             *      ADJ[V1] = [V2, V5]
             *      ADJ[V2] = [V1, V4]
             *      ADJ[V3] = [V4, V5]
             *      ADJ[V4] = [V2, V3]
             *      ADJ[V5] = [V1, V6]
             *      ADJ[V6] = [V5]
             */
            #endregion
            Grafo grafo;
            List<Vertice> listaVertices = new List<Vertice>();
            Vertice[] verticesA = new Vertice[6];
            verticesA[0] = new Vertice(1);
            verticesA[1] = new Vertice(2);
            verticesA[2] = new Vertice(3);
            verticesA[3] = new Vertice(4);
            verticesA[4] = new Vertice(5);
            verticesA[5] = new Vertice(6);

            listaVertices = (verticesA.ToList<Vertice>());
            listaVertices.ElementAt(0).ListaADJ.Add(new Vertice(2));
            listaVertices.ElementAt(0).ListaADJ.Add(new Vertice(5));
            listaVertices.ElementAt(1).ListaADJ.Add(new Vertice(1));
            listaVertices.ElementAt(1).ListaADJ.Add(new Vertice(4));
            listaVertices.ElementAt(2).ListaADJ.Add(new Vertice(4));
            listaVertices.ElementAt(2).ListaADJ.Add(new Vertice(5));
            listaVertices.ElementAt(3).ListaADJ.Add(new Vertice(2));
            listaVertices.ElementAt(3).ListaADJ.Add(new Vertice(3));
            listaVertices.ElementAt(4).ListaADJ.Add(new Vertice(1));
            listaVertices.ElementAt(4).ListaADJ.Add(new Vertice(6));
            listaVertices.ElementAt(5).ListaADJ.Add(new Vertice(5));

            //grafo = new Grafo(listaVertices);
        }
    }
}
