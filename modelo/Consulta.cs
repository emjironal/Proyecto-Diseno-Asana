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

        public void SetSelect(String Select)
        {

        }

        public void SetFrom(String From)
        {

        }

        public void SetWhere(String Where)
        {

        }

        public void SetGroupBy(String GroupBy)
        {

        }

        public void SetHaving(String Having)
        {

        }

        public void SetOrderBy(String OrderBy)
        {

        }

        public String Get()
        {
            //Buscar patron para este tipo de operacion
            //Decorator maybe?
            return null;
        }
    }
}
