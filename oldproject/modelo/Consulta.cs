using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Consulta
    {
        String select;
        String from;
        String where;
        String groupBy;
        String having;
        String orderBy;
        //Se añade capacidad de join, por el momento se acepta solo inner join
        Dictionary<String, String> Joins;

        public Consulta() {
            select = from = where = groupBy = having = orderBy = "";
            Joins = new Dictionary<string, string>();
        }

        public Consulta(String Select, String From)
        {
            this.select = Select;
            this.from = From;
        }

        public Consulta Select(String select)
        {
            this.select = select;
            return this;
        }

        public Consulta From(String From)
        {
            this.from = From;
            return this;
        }

        public Consulta Where(String Where)
        {
            this.where = Where;
            return this;
        }

        public Consulta GroupBy(String GroupBy)
        {
            this.groupBy = GroupBy;
            return this;
        }

        public Consulta Having(String Having)
        {
            this.having = Having;
            return this;
        }

        public Consulta OrderBy(String OrderBy)
        {
            this.orderBy = OrderBy;
            return this;
        }

        public Consulta Join(String Table, String Criteria) {
            Joins.Add(Table, Criteria);
            return this;
        }

        public String Get() {
            //Buscar patron para esto
            String result;
            if (select != "" && from != ""){
                result = String.Format("SELECT {0} From {1} ", select, from);
            }else{
                return "";
            }
            if (Joins.Count > 0 ) {
                foreach (String key in Joins.Keys) {
                    result += String.Format("INNER JOIN {0} ON ({1}) ",key, Joins[key]) ;
                }                
            }
            if (where != "")
                result += " WHERE " + where ;
            if (groupBy != "")
                result += " GROUP BY " + groupBy;
            if (orderBy != "")
                result += " ORDER BY " + orderBy;
            if (having != "")
                result += " HAVING " + having; 
            return result;
        }
    }
}
