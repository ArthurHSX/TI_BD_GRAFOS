﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_GRAFOS_2019
{
    class Aresta
    {
        private int v1;
        private int v2;
        private string aresta;

        public Aresta(int _v1, int _v2, string _aresta)
        {
            this.v1 = _v1;
            this.v2 = _v2;
            this.aresta = _aresta;
        }

        public int V1
        {
            get => this.v1;
        }
    }
}