using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Consulta
    {
        String Select;
        String From;
        String Where;
        String GroupBy;
        String Having;
        String OrderBy;


        public Consulta() { }

        public Consulta(String Select, String From)
        {
            this.Select = Select;
            this.From = From;
        }

        public Consulta SetSelect(String Select)
        {
            this.Select = Select;
            return this;
        }

        public Consulta SetFrom(String From)
        {
            this.From = From;
            return this;
        }

        public Consulta SetWhere(String Where)
        {
            this.Where = Where;
            return this;
        }

        public Consulta SetGroupBy(String GroupBy)
        {
            this.GroupBy = GroupBy;
            return this;
        }

        public Consulta SetHaving(String Having)
        {
            this.Having = Having;
            return this;
        }

        public Consulta SetOrderBy(String OrderBy)
        {
            this.OrderBy = OrderBy;
            return this;
        }
    }
}
