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
    //asss
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
            newUtente.Gender = utente.Gender;
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

                if (result != null)
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

        public void AddValues(int sns, int bloodPressureMin, int bloodPressureMax, int heartRate, int oxygenSatu, DateTime data, int tempoTotal)
        {
            Valores valores = new Valores();

            Alertas alertas = new Alertas();
            Utente utente = _acederBd.getUtenteBySNS(sns);

            if (utente != null)
            {
                valores.Utente = utente;
                valores.BloodPressureMin = bloodPressureMin;
                valores.BloodPressureMax = bloodPressureMax;
                valores.OxygenSaturation = oxygenSatu;
                valores.HeartRate = heartRate;
                valores.DataOfRegist = data;


                if (valores.BloodPressureMin >= 90 && valores.BloodPressureMax <= 180 || valores.HeartRate >= 90 || valores.OxygenSaturation >= 60 && valores.OxygenSaturation <= 120)
                {
                    alertas.Tipo = null;
                    alertas.Read = null;

                }
                else
                {
                    if (valores.BloodPressureMin < 60 || valores.HeartRate < 80 ||
                    valores.OxygenSaturation < 30 && valores.OxygenSaturation > 180)
                    {
                        alertas.Tipo = "Critico Anytime";


                    }
                    else if (valores.BloodPressureMin <= 90 && valores.BloodPressureMax >= 180 || valores.HeartRate <= 90 ||
                        valores.OxygenSaturation <= 60 && valores.OxygenSaturation >= 120)
                    {
                        /* if (valores.DataOfRegist.AddMinutes(-10))
                         {

                         }else if*/
                    }
                    
                    
                    /*else if (valores.BloodPressureMin <= 90 && valores.BloodPressureMax >= 180 && tempoTotal >= 60 ||
               valores.HeartRate <= 90 && tempoTotal >= 60 ||
               valores.OxygenSaturation >= 120 && valores.OxygenSaturation <= 60 && tempoTotal >= 60)
                    {
                        alertas.Tipo = "Critico Continuo";


                        // }

                      
                    }*/

                    alertas.Data = valores.DataOfRegist;
                    alertas.Read = "Not Read";
                    _acederBd.addValluesAlerts(alertas);
                    valores.Alertas = alertas;


                }
            }
            _acederBd.addVallues(valores);
        }

        public List<ValoresWeb> GetValuesbySNS(int sns)
        {

            List<Valores> lista = _acederBd.getValuesbySNS(sns);
            List<ValoresWeb> listaWeb = new List<ValoresWeb>();

            foreach (Valores item in lista)
            {
                ValoresWeb valWeb = new ValoresWeb();
                valWeb.BloodPressureMax = item.BloodPressureMax;
                valWeb.BloodPressureMin = item.BloodPressureMin;
                valWeb.HeartRate = item.HeartRate;
                valWeb.OxigenSat = item.OxygenSaturation;
                valWeb.DataOfReposit = item.DataOfRegist;

                listaWeb.Add(valWeb);
            }
            return listaWeb;
        }


        public List<AlertasWeb> GetValuesAlertsbySns(int sns)
        {

            try
            {
                List<Valores> valores = _acederBd.getValuesbySNS(sns);
                List<AlertasWeb> valor = new List<AlertasWeb>();

                foreach (Valores item in valores)
                {
                    AlertasWeb valorWeb = new AlertasWeb();

                    valorWeb.Tipo = item.Alertas.Tipo;
                    valorWeb.DataAlerta = item.Alertas.Data;
                    valorWeb.Read = item.Alertas.Read;
                    
                    valor.Add(valorWeb);
                }
                return valor;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public List<ValoresWeb> GetAlertNotRead(int sns)
        {

            try
            {

              
                    List<Valores> valores = _acederBd.getAlertaSns(sns);
                    List<ValoresWeb> valor = new List<ValoresWeb>();
                
            

                foreach (Valores item in valores)
                {
                    ValoresWeb valorWeb = new ValoresWeb();

                    valorWeb.TipoAlerta = item.Alertas.Tipo;
                    valorWeb.DataAlerta = item.Alertas.Data;
                    valorWeb.ReadAlerta = item.Alertas.Read;
                    valorWeb.NomeUtente = item.Utente.Name;
                    valorWeb.SobreUtente = item.Utente.Surname;
                    valorWeb.SnsUtente = item.Utente.SNS;
                    valor.Add(valorWeb);
                }
                return valor;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ValoresWeb> GetRegistofGrahp(int sns)
        {
            try
            {
                List<ValoresWeb> valores = new List<ValoresWeb>();
                List<Valores> listavalores = _acederBd.getValuesbySNS(sns);

                foreach (Valores item in listavalores)
                {
                    ValoresWeb valor = new ValoresWeb();
                    valor.BloodPressureMax = item.BloodPressureMax;
                    valor.BloodPressureMin = item.BloodPressureMin;
                    valor.HeartRate = item.HeartRate;
                    valor.OxigenSat = item.OxygenSaturation;
                    
                    valores.Add(valor);
                }

                return valores;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        //public AlertasWeb alert(int sns,int bloodPressureMin, int bloodPressureMax, int heartRate, int oxigenSat)
        //{
        //    AlertasWeb alertas = new AlertasWeb();
        // //   Valores item = new Valores();
        //    List<Valores> valores = _acederBd.getValuesbySNS(sns);

        //    foreach (var item in valores)

        //        if (item.BloodPressureMin <= bloodPressureMin || item.HeartRate <= heartRate || item.OxygenSaturation <= oxigenSat && item.OxygenSaturation >= oxigenSat)
        //        {
        //            alertas.DataAlerta = item.DataOfRegist;
        //            alertas.Tipo = Convert.ToInt32("C.A");

        //        }



        //    return alertas;
        //}


    }
}
