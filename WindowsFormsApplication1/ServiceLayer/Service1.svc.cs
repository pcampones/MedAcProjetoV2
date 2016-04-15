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
    //asssjjjjjjj
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
                    case "BP":
                        {
                            string[] bp = valores.Value.Split('-');
                            if (VerficaValores(valores.Type, valores.Value) == true)
                            {
                                if (GetLast2Hours(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaCriticoInterminente(utente, valores.Type);

                                }
                                else if (GetLast1Hour(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaCriticoContinuo(utente, valores.Type);
                                }
                                else if (GetLast30Min(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaAvisoInterminente(utente, valores.Type);
                                }
                                else if (GetLast10Min(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaAvisoContinuo(utente, valores.Type);
                                }
                                else if (Convert.ToInt32(bp[1]) < 60)
                                {
                                    GerarAlertaAnytime(utente, valores.Type);
                                }

                            }
                        }

                        break;
                    case "HR":
                        {
                            if (VerficaValores(valores.Type, valores.Value) == true)
                            {
                                if (GetLast2Hours(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaCriticoInterminente(utente, valores.Type);

                                }
                                else if (GetLast1Hour(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaCriticoContinuo(utente, valores.Type);
                                }
                                else if (GetLast30Min(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaAvisoInterminente(utente, valores.Type);
                                }
                                else if (GetLast10Min(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaAvisoContinuo(utente, valores.Type);
                                }
                                else if (Convert.ToInt32(valores.Value) < 80)
                                {
                                    GerarAlertaAnytime(utente, valores.Type);
                                }

                            }
                        }

                        break;
                    case "SPO2":
                        {
                            if (VerficaValores(valores.Type, valores.Value) == true)
                            {
                                if (GetLast2Hours(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaCriticoInterminente(utente, valores.Type);

                                }
                                else if (GetLast1Hour(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaCriticoContinuo(utente, valores.Type);
                                }
                                else if (GetLast30Min(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaAvisoInterminente(utente, valores.Type);
                                }
                                else if (GetLast10Min(valores.Type, utente.SNS) == true)
                                {
                                    GerarAlertaAvisoContinuo(utente, valores.Type);
                                }
                                else if (Convert.ToInt32(valores.Value) < 30 || Convert.ToInt32(valores.Value) > 180)
                                {
                                    GerarAlertaAnytime(utente, valores.Type);
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
            List<DateTime> somatorioMin = new List<DateTime>();
            List<int> inte = new List<int>();
            List<int> diferencas = new List<int>();
            int dife = 0, soma2Horas = 0;
            for (int i = 0; i < lista2H.Count; i++)
            {
                if (VerficaValores(lista2H[i].Type, lista2H[i].Value))
                {
                    DateTime min = lista2H[i].DataOfRegist;
                    somatorioMin.Add(min);

                }
            }

            List<DateTime> datasOrdenadas = sortDescending(somatorioMin);

            foreach (DateTime item in datasOrdenadas)
            {
                int min = item.Minute;
                inte.Add(min);

            }

            for (int i = 0; i < inte.Count(); i++)
            {
                int minAtual = inte[i];

                if (i + 1 < inte.Count())
                {

                    int proximMin = inte[i + 1];

                    dife = Math.Abs(minAtual - proximMin);

                    diferencas.Add(dife);
                }


            }

            if (diferencas.Count() != 0)
            {
                foreach (var item in diferencas)
                {
                    soma2Horas += item;

                }


            }
            if (soma2Horas >= 60)
            {
                return true;
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
            List<Valores> lista30m = _acederBd.get30min(type, sns);
            List<DateTime> somatorioMin = new List<DateTime>();
            List<int> inte = new List<int>();
            List<int> diferencas = new List<int>();
            int dife = 0, soma10min = 0;

            for (int i = 0; i < lista30m.Count; i++)
            {
                if (VerficaValores(lista30m[i].Type, lista30m[i].Value))
                {
                    DateTime min = lista30m[i].DataOfRegist;
                    somatorioMin.Add(min);

                }
            }

            List<DateTime> datasOrdenadas = sortDescending(somatorioMin);

            foreach (DateTime item in datasOrdenadas)
            {
                int min = item.Minute;
                inte.Add(min);

            }

            for (int i = 0; i < inte.Count(); i++)
            {
                int minAtual = inte[i];

                if (i + 1 < inte.Count())
                {

                    int proximMin = inte[i + 1];

                    dife = Math.Abs(minAtual - proximMin);

                    diferencas.Add(dife);
                }


            }

            if (diferencas.Count() != 0)
            {
                foreach (var item in diferencas)
                {
                    soma10min += item;
                }
            }
            if (soma10min >= 10)
            {
                return true;
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

                    if (int.Parse(valueBP[1]) < 90 || int.Parse(valueBP[0]) > 180)
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

        List<DateTime> sortDescending(List<DateTime> datas)
        {
            datas.Sort((b, a) => a.CompareTo(b));
            return datas;
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

        public List<AlertasWeb> GetAlertsNotReadDate(DateTime startBegin, DateTime startEnd, int sns)
        {
            try
            {
                List<Alertas> lista = _acederBd.getAlertaSns(sns, startBegin, startEnd);
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
                List<Utente> lista = _acederBd.getUtentAlert();
                List<UtenteWeb> listaWeb = new List<UtenteWeb>();

                foreach (Utente item in lista)
                {
                    Utente utente = _acederBd.getUtenteBySNS(item.SNS);

                    UtenteWeb uWeb = new UtenteWeb();

                    uWeb.Sns = utente.SNS;
                    uWeb.Name = utente.Name;
                    uWeb.Surname = utente.Surname;

                    listaWeb.Add(uWeb);
                }

                return listaWeb;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ValoresWeb> GetValuesAlerts(int sns, string type, string tipo, DateTime data)
        {
            try
            { //// ahhaha
                List<Valores> lista = null;
                List<ValoresWeb> listaWeb = new List<ValoresWeb>();

                if (tipo == "Aviso Continuo")
                {
                    lista = _acederBd.get10minGraphs(type, sns, data);
                }
                else if (tipo == "Aviso Interminente")
                {
                    lista = _acederBd.get30minGraphs(type, sns, data);
                }
                else if (tipo == "Critico Interminente")
                {
                    lista = _acederBd.get2hoursGraphs(type, sns, data);
                }
                else if (tipo == "Critio Continuo")
                {
                    lista = _acederBd.get1hoursGraphs(type, sns, data);
                }
                else if (tipo == "Any Time")
                {
                    lista = _acederBd.get30minGraphs(type, sns, data);
                }

                foreach (Valores item in lista)
                {
                    ValoresWeb v = new ValoresWeb();

                    v.DataOfReposit = item.DataOfRegist;
                    v.Value = item.Value;
                    listaWeb.Add(v);
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

}