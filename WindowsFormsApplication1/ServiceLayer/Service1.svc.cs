using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassLibraryMedAc;
namespace ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        readonly Class1 _acederBd = new Class1();

        public UtenteWeb GetUtenteBySNS(int sns)
        {
            try
            {
                UtenteWeb result = new UtenteWeb();
                Utente u = _acederBd.getUtenteBySNS(sns);

                result.Name = u.Name;
                result.Surname = u.Surname;
                result.Phone = u.Phone;
                result.Mail = u.Mail;
                result.Birthdate = u.Birthdate;
                result.Bi = u.BI;
                result.Sns = u.SNS;
                result.Address = u.Address;
                result.Gender = u.Gender;
                result.Alergies = u.Alergies;
                result.Height = u.Height;
                result.NexOfKinContact = u.NexOfKinContat;
                result.Weight = u.Weight;
                result.Age = u.Age;
                result.Ative = u.Ative;


                return result;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void AddUtente(UtenteWeb utente)
        {
            Utente newUtente = new Utente();
            newUtente.Name = utente.Name;
            newUtente.Surname = utente.Surname;
            newUtente.Phone = utente.Phone;
            newUtente.Mail = utente.Mail;
            newUtente.Birthdate = utente.Birthdate;
            newUtente.BI = utente.Bi;
            newUtente.SNS = utente.Sns;
            newUtente.Address = utente.Address;
            newUtente.Alergies = utente.Alergies;
            newUtente.Height = utente.Height;
            newUtente.NexOfKinContat = utente.NexOfKinContact;
            newUtente.Weight = utente.Weight;
            newUtente.Age = utente.Age;
            newUtente.Ative = utente.Ative;

            _acederBd.addUtente(newUtente);
            

        }

        public bool EditUtente(UtenteWeb utente)
        {
            try
            {
                Utente result = _acederBd.getUtenteBySNS(utente.Sns);

                result.Name = utente.Name;
                result.Surname = utente.Surname;
                result.Phone = utente.Phone;
                result.Mail = utente.Mail;
                result.Birthdate = utente.Birthdate;
                result.BI = utente.Bi;
                result.SNS = utente.Sns;
                result.Address = utente.Address;
                result.Gender = utente.Gender;
                result.Alergies = utente.Alergies;
                result.Height = utente.Height;
                result.NexOfKinContat = utente.NexOfKinContact;
                result.Weight = utente.Weight;
                result.Age = utente.Age;
                result.Ative = utente.Ative;
                _acederBd.editUtente(result);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
         


        }

        public List<UtenteWeb> GetListaUtentes()
        {
            try
            {
                List<UtenteWeb> listaWebSer = new List<UtenteWeb>();
                List<Utente> result = _acederBd.getListUtentesAtive();

                if(result != null)
                {
                    foreach (Utente item in result)
                    {
                        UtenteWeb u = new UtenteWeb();
                        u.Name = item.Name;
                        u.Surname = item.Surname;
                        u.Phone = item.Phone;
                        u.Mail = item.Mail;
                        u.Sns = item.SNS;
                        u.Bi = item.BI;
                        u.Birthdate = item.Birthdate;
                        u.Address = item.Address;
                        u.Gender = item.Gender;
                        u.Height = item.Height;
                        u.NexOfKinContact = item.NexOfKinContat;
                        u.Weight = item.Weight;
                        u.Age = item.Age;
                        u.Ative = item.Ative;

                        listaWebSer.Add(u);

                    }
            
                }
                return listaWebSer;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
