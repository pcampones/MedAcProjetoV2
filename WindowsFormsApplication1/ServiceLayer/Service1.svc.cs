﻿ using System;
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

        public void AddValues(int sns, string type, string value, DateTime data)
        {
            Valores valores = new Valores();
            Utente utente = _acederBd.getUtenteBySNS(sns);


            if (utente != null)
            {
                valores.Utente = utente;
                valores.Type = type;
                valores.Value = value;
                valores.DataOfRegist = data;
                VerificaAlerta(valores.Utente, valores);


            }

            _acederBd.addVallues(valores);
        }

        public List<ValoresWeb> GetValuesbySNS(int sns, DateTime dataMax, DateTime dataMin)
        {
            List<Valores> lista = _acederBd.getValuesbySNS(sns, dataMax, dataMin);
            List<ValoresWeb> listaWeb = new List<ValoresWeb>();

            foreach (Valores item in lista)
            {
                ValoresWeb valWeb = new ValoresWeb();
                valWeb.Value = item.Value;
                valWeb.DataOfReposit = item.DataOfRegist;
                valWeb.Type = item.Type;
                listaWeb.Add(valWeb);
            }
            return listaWeb;
        }


        public List<EstatisticasWeb> GetReportsHRbySNS(int sns, DateTime startDate, DateTime endDate, string type)
        {
            List<EstatisticasWeb> lista = _acederBd.getReportsHRbySNS(sns, startDate, endDate, type);
            List<EstatisticasWeb> listaWeb = new List<EstatisticasWeb>();

            if (lista != null)
            {

                foreach (EstatisticasWeb item in lista)
                {
                    EstatisticasWeb esWeb = new EstatisticasWeb();

                    esWeb.ValorMax = item.ValorMax;
                    esWeb.ValorMin = item.ValorMin;
                    esWeb.ValorMed = item.ValorMed;
                    esWeb.StartDate = startDate;
                    esWeb.EndDate = endDate;
                    esWeb.Tipo = type;


                    listaWeb.Add(esWeb);
                }

            }
            return listaWeb;
        }

        public void VerificaAlerta(Utente utente, Valores valores)
        {
            Alertas alertas = new Alertas();
            AlertasWeb alertasWeb = new AlertasWeb();

            if (valores != null)
            {

                switch (valores.Type)
                {
                    case "HR":

                       // if (Convert.ToInt32(valores.Value) < 80)
                        {
                            if (VerficaValores(valores.Type, valores.Value) == true)
                            {
                                if (GetLast2Hours(valores.Type, utente.SNS) == true)
                                {
                                    if (GetLast1Hour(valores.Type, utente.SNS) == true)
                                    {
                                        GerarAlertaCriticoContinuo(utente, valores.Type);
                                    }
                                    GerarAlertaCriticoInterminente(utente, valores.Type);

                                }
                                /*else if (GetLast1Hour(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaCriticoContinuo(utente, valores.Type);
                                }*/
                                else if (GetLast30Min(valores.Type, utente.SNS) == true)
                                {
                                    if (GetLast10Min(valores.Type, utente.SNS) == true)
                                    {
                                        GerarAlertaAvisoContinuo(utente, valores.Type);
                                    }
                                    GerarAlertaAvisoInterminente(utente, valores.Type);

                                }
                                /*else if (GetLast10Min(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaAvisoContinuo(utente, valores.Type);
                                }*/
                                else if (Convert.ToInt32(valores.Value) < 80)
                                {
                                    GerarAlertaAnytime(utente,valores.Type);
                                }


                                
                            }
                        }

                        break;



                }

            }
        }


        // Metodos auxiliares Web Service para Gerar Alertas
        public bool GetLast2Hours(string type, int sns)
        {
            List<Valores> lista2H = _acederBd.get2Hours(type, sns);

            int soma1 = 0;

            foreach (Valores item in lista2H)
            {
                if (VerficaValores(item.Type, item.Value))
                {
                    soma1 += item.DataOfRegist.Minute;

                    if (soma1 >= 60)
                    {
                        return true;

                    }

                }

            }

            return false;
        }

        public Boolean GetLast1Hour(string type, int sns)
        {
            List<Valores> lista1 = _acederBd.get1Hours(type, sns);
            List<Valores> listaForaGama = _acederBd.get1Hours(type, sns);
            List<Valores> listaComValores = new List<Valores>();

            foreach (Valores item in listaForaGama)
            {
                if (VerficaValores(item.Type, item.Value) == true)
                {
                    listaComValores.Add(item);
                }

            }

            if (listaComValores.Count == lista1.Count)
            {
                return true;
            }
            return false;
        }



        public Boolean GetLast30Min(string type, int sns)
        {
            List<Valores> lista30 = _acederBd.get30min(type, sns);
            int soma10 = 0;

            foreach (Valores item in lista30)
            {
                if (VerficaValores(item.Type, item.Value))
                {
                    soma10 += item.DataOfRegist.Minute;

                    if (soma10 >= 10)
                    {
                        return true;

                    }

                }

            }
            return false;
        }



        public Boolean GetLast10Min(string type, int sns)
        {
            List<Valores> lista10 = _acederBd.get10min(type, sns);
            List<Valores> listaForaGama = _acederBd.get10min(type, sns);
            List<Valores> listaComValores = new List<Valores>();

            foreach (Valores item in listaForaGama)
            {
                if (VerficaValores(item.Type, item.Value) == true)
                {
                    listaComValores.Add(item);
                }

            }

            if (listaComValores.Count == lista10.Count)
            {
                return true;
            }
            return false;
        }


        public Boolean VerficaValores(string type, string value)
        {

            switch (type)
            {
                case "HR":
                    if (Convert.ToInt32(value) < 90)
                    {
                        return true;
                    }
                    break;
                case "SPO2":
                    if (Convert.ToInt32(value) < 60 || Convert.ToInt32(value) > 120)
                    {
                        return true;
                    }
                    break;

                case "BP":
                    string[] valueBP = value.Split('-');

                    if (int.Parse(valueBP[1]) < 90 || int.Parse(valueBP[1]) > 180)
                    {
                        return true;
                    }
                    break;

            }
            return false;

        }

        public void GerarAlertaAvisoContinuo(Utente utente, string type)
        {
            Alertas ale = new Alertas();
            ale.Data = DateTime.Now;
            ale.Parametro = type;
            ale.Read = "Not Read";
            ale.Tipo = "Aviso Continuo";
            ale.Utente = utente;
            _acederBd.addValluesAlerts(ale);

        }

        public void GerarAlertaAvisoInterminente(Utente utente, string type)
        {
            Alertas ale = new Alertas();
            ale.Data = DateTime.Now;
            ale.Parametro = type;
            ale.Read = "Not Read";
            ale.Tipo = "Aviso Interminente";
            ale.Utente = utente;
            _acederBd.addValluesAlerts(ale);

        }

        public void GerarAlertaCriticoContinuo(Utente utente, string type)
        {
            Alertas ale = new Alertas();
            ale.Data = DateTime.Now;
            ale.Parametro = type;
            ale.Read = "Not Read";
            ale.Tipo = "Critico Continuo";
            ale.Utente = utente;
            _acederBd.addValluesAlerts(ale);

        }

        public void GerarAlertaCriticoInterminente(Utente utente, string type)
        {
            Alertas ale = new Alertas();
            ale.Data = DateTime.Now;
            ale.Parametro = type;
            ale.Read = "Not Read";
            ale.Tipo = "Critico Interminente";
            ale.Utente = utente;
            _acederBd.addValluesAlerts(ale);


        }


        public void GerarAlertaAnytime(Utente utente, string type)
        {
            Alertas ale = new Alertas();
            ale.Data = DateTime.Now;
            ale.Parametro = type;
            ale.Read = "Not Read";
            ale.Tipo = "AnyTime";
            ale.Utente = utente;
            _acederBd.addValluesAlerts(ale);
        }










        //Fim de Metodos Auxiliares


        public List<AlertasWeb> GetAlertsNotRead(int sns, DateTime startBegin, DateTime startEnd)
        {
            try
            {
                List<Alertas> lista = _acederBd.getAlertaSns(sns, startBegin, startEnd);
                List<AlertasWeb> listaWeb = new List<AlertasWeb>();

                foreach (Alertas item in lista)
                {
                    AlertasWeb alerW = new AlertasWeb();

                    alerW.DataAlerta = item.Data;
                    alerW.Read = item.Read;
                    alerW.SnsUtente = item.Utente.SNS;
                    alerW.Tipo = item.Tipo;
                    alerW.NomeUtente = item.Utente.Name;
                    alerW.SobreUtente = item.Utente.Surname;
                    alerW.Parametro = item.Parametro;
                    listaWeb.Add(alerW);
                }

                return listaWeb;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<AlertasWeb> GetAlertsNotReadDate(DateTime startBegin, DateTime startEnd)
        {
            try
            {
                List<Alertas> lista = _acederBd.getAlertaSns(startBegin, startEnd);
                List<AlertasWeb> listaWeb = new List<AlertasWeb>();

                foreach (Alertas item in lista)
                {
                    AlertasWeb alerW = new AlertasWeb();

                    alerW.SNS = item.Id;
                    alerW.DataAlerta = item.Data;
                    alerW.Read = item.Read;
                    alerW.SnsUtente = item.Utente.SNS;
                    alerW.Tipo = item.Tipo;
                    alerW.NomeUtente = item.Utente.Name;
                    alerW.SobreUtente = item.Utente.Surname;
                    alerW.Parametro = item.Parametro;
                    listaWeb.Add(alerW);
                }

                return listaWeb;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void marcarComoLido(AlertasWeb alertaWeb, int id)
        {
            Alertas alerta = new Alertas();
            alerta.Read = alertaWeb.Read;
            _acederBd.marcarComoLido(alerta, id);
        }

        public List<UtenteWeb> GetUtentesNotRead()
        {
            try
            {
                List<Utente> lista = _acederBd.getUtentesAlertsNotRead();
                List<UtenteWeb> listaWeb = new List<UtenteWeb>();

                foreach (Utente item in lista)
                {
                    UtenteWeb alerW = new UtenteWeb();
                    alerW.Name = item.Name;
                    alerW.Surname = item.Surname;
                    listaWeb.Add(alerW);
                }

                return listaWeb;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<ValoresWeb> GetRegistofGrahp(int sns, DateTime dataMax, DateTime dataMin)
        {
            try
            {
                List<ValoresWeb> valores = new List<ValoresWeb>();
                List<Valores> listavalores = _acederBd.getGraphsSNS(sns, dataMax, dataMin);
                if (listavalores != null)
                {
                    foreach (Valores item in listavalores)
                    {
                        ValoresWeb va = new ValoresWeb();
                        va.Value = item.Value;
                        va.Type = item.Type;
                        va.DataOfReposit = item.DataOfRegist;

                        valores.Add(va);
                    }

                }

                return valores;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    //public void AddValues(int sns, int bloodPressureMin, int bloodPressureMax, int heartRate, int oxygenSatu, DateTime data)
    //{
    //    Valores valores = new Valores();

    //    Alertas alertas = new Alertas();
    //    Utente utente = _acederBd.getUtenteBySNS(sns);

    //    if (utente != null)
    //    {
    //        valores.Utente = utente;
    //        valores.BloodPressureMin = bloodPressureMin;
    //        valores.BloodPressureMax = bloodPressureMax;
    //        valores.OxygenSaturation = oxygenSatu;
    //        valores.HeartRate = heartRate;
    //        valores.DataOfRegist = data;


    //        if (valores.BloodPressureMin >= 90 && valores.BloodPressureMax <= 180 || valores.HeartRate >= 90 || valores.OxygenSaturation >= 60 && valores.OxygenSaturation <= 120)
    //        {
    //            alertas.Tipo = "Gama Normal";

    //            alertas.Data = valores.DataOfRegist;
    //            alertas.Read = "Read";

    //        }
    //        else
    //        {
    //            if (valores.BloodPressureMin < 60 && valores.HeartRate < 80 &&
    //            valores.OxygenSaturation < 30 || valores.OxygenSaturation > 180)
    //            {
    //                alertas.Tipo = "Critico Anytime";


    //            }
    //            else if (valores.BloodPressureMin <= 90 && valores.BloodPressureMax >= 180 || valores.HeartRate <= 90 ||
    //                valores.OxygenSaturation <= 60 && valores.OxygenSaturation >= 120)
    //            {
    //                //
    //                //problema
    //                // ao criar uma nova lista, ele vai me estar
    //                //adicionar sempre a data, e nunca vai buscar 
    //                //as outras datas referentes aos valores
    //                //que estao fora dos parametros normais
    //                //Sera que e preciso fazer um metodo 
    //                //atraves do linq para retornar as outras datas referentes aquele utente

    //                List<DateTime> datas = new List<DateTime>();

    //                //
    //                datas.Add(valores.DataOfRegist);

    //                datas.Sort((ps1, ps2) => DateTime.Compare(ps1.Date, ps2.Date));

    //                DateTime dataInicio = datas.FirstOrDefault();
    //                DateTime dataFim = datas.LastOrDefault();
    //                int somaTempo = 0;
    //                /*foreach (DateTime item in datas)
    //                {
    //                    somaTempo += item.Minute;
    //                }*/
    //                var dif = (dataFim - dataInicio).Minutes;
    //                somaTempo += dif;

    //                if (dif >= 0 && dif <10)
    //                {
    //                    alertas.Tipo = " ";
    //                }
    //                else if(dif >= 10 && dif <30)
    //                {
    //                    alertas.Tipo = "Aviso Continuo";
    //                }
    //                else if( dif >= 30)
    //                {
    //                    alertas.Tipo = "Critico Continuo";
    //                }
    //                else if (dif == 30 && somaTempo >= 10)
    //                {
    //                    alertas.Tipo = "Aviso Interminente";
    //                }
    //                else if (dif == 60 && somaTempo>= 30)
    //                {
    //                    alertas.Tipo = "Critico Interminente";
    //                }




    //            alertas.Data = valores.DataOfRegist;
    //            alertas.Read = "Not Read";



    //        }
    //        _acederBd.addValluesAlerts(alertas);
    //        valores.Alertas = alertas;
    //    }
    //    _acederBd.addVallues(valores);
    //}

    //public List<ValoresWeb> GetValuesbySNS(int sns)
    //{

    //    List<Valores> lista = _acederBd.getValuesbySNS(sns);
    //    List<ValoresWeb> listaWeb = new List<ValoresWeb>();

    //    foreach (Valores item in lista)
    //    {
    //        ValoresWeb valWeb = new ValoresWeb();
    //        valWeb.BloodPressureMax = item.BloodPressureMax;
    //        valWeb.BloodPressureMin = item.BloodPressureMin;
    //        valWeb.HeartRate = item.HeartRate;
    //        valWeb.OxigenSat = item.OxygenSaturation;
    //        valWeb.DataOfReposit = item.DataOfRegist;

    //        listaWeb.Add(valWeb);
    //    }
    //    return listaWeb;
    //}


    //public List<AlertasWeb> GetValuesAlertsbySns(int sns)
    //{

    //    try
    //    {
    //        List<Valores> valores = _acederBd.getValuesbySNS(sns);
    //        List<AlertasWeb> valor = new List<AlertasWeb>();

    //        foreach (Valores item in valores)
    //        {
    //            AlertasWeb valorWeb = new AlertasWeb();

    //            valorWeb.Tipo = item.Alertas.Tipo;
    //            valorWeb.DataAlerta = item.Alertas.Data;
    //            valorWeb.Read = item.Alertas.Read;

    //            valor.Add(valorWeb);
    //        }
    //        return valor;
    //    }
    //    catch (Exception ex)
    //    {

    //        throw ex;
    //    }

    //cenas 



    //public List<ValoresWeb> GetAlertNotRead(int sns)
    //{

    //    try
    //    {


    //            List<Valores> valores = _acederBd.getAlertaSns(sns);
    //            List<ValoresWeb> valor = new List<ValoresWeb>();



    //        foreach (Valores item in valores)
    //        {
    //            ValoresWeb valorWeb = new ValoresWeb();

    //            valorWeb.TipoAlerta = item.Alertas.Tipo;
    //            valorWeb.DataAlerta = item.Alertas.Data;
    //            valorWeb.ReadAlerta = item.Alertas.Read;
    //            valorWeb.NomeUtente = item.Utente.Name;
    //            valorWeb.SobreUtente = item.Utente.Surname;
    //            valorWeb.SnsUtente = item.Utente.SNS;
    //            valor.Add(valorWeb);
    //        }
    //        return valor;
    //    }
    //    catch (Exception ex)
    //    {

    //        throw ex;
    //    }

    //}


    //public List<ValoresWeb> GetRegistofGrahp(int sns)
    //{
    //    try
    //    {
    //        List<ValoresWeb> valores = new List<ValoresWeb>();
    //        List<Valores> listavalores = new List<Valores>();
    //        foreach (Valores item in listavalores)
    //        {

    //        }

    //        return null;
    //    }
    //    catch (Exception ex)
    //    {

    //        throw ex;
    //    }
    //}



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


    //}

}