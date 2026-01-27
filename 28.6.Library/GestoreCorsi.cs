using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _28._6.Library
{
    public class GestoreCorsi
    {
        public List<Corso> Corsi { get; set; }

        public void AddCorso(Corso corso)
        {
            Corsi.Add(corso);
        }


    }
}
