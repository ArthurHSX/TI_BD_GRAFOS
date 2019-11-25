using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_GRAFOS_2019
{
    class Torre : Vertice
    {
        private string codigo;
        private string funcionario;
        private bool construida;

        public Torre(string _codigo)
        {
            this.codigo = _codigo;
            this.funcionario = null;
        }
        public Torre(string _codigo, int _id, string _funcioario, List<Vertice> _lista)
        {
            this.codigo = _codigo;
            base.ID = _id;
            base.ListaADJ = _lista;
            this.funcionario = _funcioario;
        }

        public string Funcionario
        {
            get => this.funcionario;
            set => this.funcionario = value;
        }
    }
}
