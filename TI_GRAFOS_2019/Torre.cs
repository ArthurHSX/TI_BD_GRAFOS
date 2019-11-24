using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_GRAFOS_2019
{
    class Torre : Vertice
    {
        private int codigo;
        private string funcionario;

        public Torre(int _codigo, int _id, string _funcioario, List<Vertice> _lista)
        {
            this.codigo = _codigo;
            base.ID = _id;
            base.ListaADJ = _lista;
            this.funcionario = _funcioario;
        }
    }
}
