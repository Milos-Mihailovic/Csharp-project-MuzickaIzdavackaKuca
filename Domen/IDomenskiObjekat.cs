using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface IDomenskiObjekat
    {
        List<IDomenskiObjekat> ListaObjekata(SqlDataReader citac);
        object NazivTabele();
        object PodesiParametreZaIzmenu();
        object VratiKljuc();
        object VratiUslov();
        object VratiUslovZaBrisanje();
        string ImeKljuca();
        object VratiVrednostiZaInsert();
    }
}
