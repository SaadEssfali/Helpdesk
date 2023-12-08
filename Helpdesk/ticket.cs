using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk
{
    public static class ticket
    {
        public static int TicketID;
        public static string Descriptio;
        public static int CategorieID;
        public static int EmployeID;
        public static DateTime? DateOuverture;
        public static DateTime? DateCloture;// Nullable to allow for 'NULL' values
        public static string Statut;

        
    }
}
