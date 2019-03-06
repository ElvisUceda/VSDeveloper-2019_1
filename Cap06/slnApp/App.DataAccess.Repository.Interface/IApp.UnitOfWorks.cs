using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repository.Interface
{
   public  interface IAppUnitOfWorks:IDisposable

    {
        IArtistRepository artistRepository { get; set; }
        ITrackRepository trackRepository { get; set; }
        int Complete(); // Para confirmar una transaccion a travez de los metodos repositorios

    }
}
