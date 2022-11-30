using GameProject.Abstracts;
using GameProject.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapter
{
    internal class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            
           KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient();
            try
            {
                return kPSPublicSoapClient.TCKimlikNoDogrula(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(), gamer.BirthDate);
            }
            catch (Exception)
            {

                Console.WriteLine("Person Not Found");
            }

            return false;
           
        }
    }
}
