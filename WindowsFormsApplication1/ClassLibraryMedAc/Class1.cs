 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMedAc
{
    public class Class1
    {

        private ModelMedAcContainer context = new ModelMedAcContainer();

        public Utente getUtenteBySNS(int sns)
        {
            try
            {
                var result = context.UtenteSet.Where(i => i.SNS == sns).ToList();

                if (result.Count != 0)
                {
                    Utente utente = result.First();

                    return utente;

                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public void addUtente(Utente utente)
        {
            try
            {
                context.UtenteSet.Add(utente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void editUtente(Utente utente)
        {
            try
            {
                Utente result = context.UtenteSet.Where(i => i.SNS == utente.SNS).FirstOrDefault();
                result.Name = utente.Name;
                result.Surname = utente.Surname;
                result.Phone = utente.Phone;
                result.Mail = utente.Mail;
                result.Birthdate = utente.Birthdate;
                result.BI = utente.BI;
                result.SNS = utente.SNS;
                result.Address = utente.Address;
                result.Gender = utente.Gender;
                result.Alergies = utente.Alergies;
                result.Height = utente.Height;
                result.NexOfKinContat = utente.NexOfKinContat;
                result.Weight = utente.Weight;
                result.Age = utente.Age;
                result.Ative = utente.Ative;

                context.SaveChanges();
            }
            catch (Exception)
            {

                return;
            }
        }

        public List<Utente> getListUtentes()
        {
            return context.UtenteSet.ToList();
        }

        public List<Utente> getListUtentesAtive()
        {
            try
            {
                var result = context.UtenteSet.Where(i => i.Ative == "Ative").ToList();


                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
         
        }

        public List<Valores> getValuesbySNS(int sns, DateTime dataMax, DateTime dataMin)
        {
            try
            {
                var listaVa = context.ValoresSet.Where(i => i.Utente.SNS.Equals(sns) && i.DataOfRegist < dataMax && i.DataOfRegist > dataMin).ToList();

                return listaVa;
            }
            catch (Exception ex)
            {

                throw ex;
                    
            }
        }

        public List<Valores> getGraphsSNS(int sns, DateTime dataMax, DateTime dataMin)
        {
            try
            {
                var listaVa = context.ValoresSet.Where(i => i.Utente.SNS.Equals(sns) && dataMin <= i.DataOfRegist && dataMax >= i.DataOfRegist ).ToList();

                return listaVa;
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        public void addVallues(Valores valores)
        {
            try
            {
                context.ValoresSet.Add(valores);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void addValluesAlerts(Alertas valores)
        {
            try
            {
                context.AlertasSet.Add(valores);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        // Alertas Gerados
        public List<Valores> getDataSPO2(string tipo)
        {
            List<Valores> datas = context.ValoresSet.Where(i => i.Type == "HR").ToList();
            return datas;
        }
        public List<Valores> get2Hours(string tipo, int sns)
        {
            DateTime data = DateTime.Now.AddHours(-2);
            DateTime dataAtual = DateTime.Now;
            List<Valores> data2Hours = context.ValoresSet.Where(i => i.DataOfRegist < dataAtual && i.DataOfRegist > data && i.Utente.SNS == sns && tipo == i.Type).ToList();

            return data2Hours;
        }

        public List<Valores> get1Hours(string tipo, int sns)
        {
            DateTime data = DateTime.Now.AddHours(-1);
            DateTime dataAtual = DateTime.Now;
            List<Valores> data1Hours = context.ValoresSet.Where(i => i.DataOfRegist < dataAtual && i.DataOfRegist > data && i.Utente.SNS == sns && tipo == i.Type).ToList();

            return data1Hours;
        }

        public List<Valores> get30min(string tipo, int sns)
        {
            DateTime data = DateTime.Now.AddMinutes(-30);
            DateTime dataAtual = DateTime.Now;
            List<Valores> data30min = context.ValoresSet.Where(i => i.DataOfRegist < dataAtual && i.DataOfRegist > data && i.Utente.SNS == sns && tipo == i.Type).ToList();

            return data30min;
        }

        public List<Valores> get10min(string tipo, int sns)
        {
            DateTime data = DateTime.Now.AddMinutes(-10);
            DateTime dataAtual = DateTime.Now;
            List<Valores> data10min = context.ValoresSet.Where(i => i.DataOfRegist < dataAtual && i.DataOfRegist > data && i.Utente.SNS == sns && tipo == i.Type).ToList();

            return data10min;
        }




        public List<EstatisticasWeb> getReportsHRbySNS(int sns, DateTime startDate, DateTime endDate, string type)
        {
            try
            {


                List<Valores> listaVa = context.ValoresSet.Where(i => i.Utente.SNS.Equals(sns) && i.DataOfRegist >= startDate && 
                i.DataOfRegist <= endDate && i.Type == type).ToList();

                if (listaVa.Count != 0)
                {
                    EstatisticasWeb es = new EstatisticasWeb();

                    List<EstatisticasWeb> estastisticas = new List<EstatisticasWeb>();
                    double mediaHR = 0;
                    int maxHR = 0;
                    int minHR = 0;


                    mediaHR = listaVa.Select(i => int.Parse(i.Value)).Average();
                    maxHR = listaVa.Select(i => int.Parse(i.Value)).Max();
                    minHR = listaVa.Select(i => int.Parse(i.Value)).Min();

                    es.ValorMax = maxHR;
                    es.ValorMed = mediaHR;
                    es.ValorMin = minHR;

                    estastisticas.Add(es);

                    return estastisticas;
                }
                /*  if (type == "HR")
                  {
                       mediaHR = listaVa.Select(i => int.Parse(i.Value)).Average();
                       maxHR = listaVa.Select(i => int.Parse(i.Value)).Max();
                       minHR = listaVa.Select(i => int.Parse(i.Value)).Min();

                      es.ValorMax = maxHR;
                      es.ValorMed = mediaHR;
                      es.ValorMin = minHR;

                      estastisticas.Add(es);

                  }

                   else if (type == "SPO2")
                  {
                      mediaHR = listaVa.Select(i => int.Parse(i.Value)).Average();
                      maxHR = listaVa.Select(i => int.Parse(i.Value)).Max();
                      minHR = listaVa.Select(i => int.Parse(i.Value)).Min();

                      es.ValorMax = maxHR;
                      es.ValorMed = mediaHR;
                      es.ValorMin = minHR;

                      estastisticas.Add(es);
                  } 
                  else if (type == "BP")
                  {
                      mediaHR = listaVa.Select(i => int.Parse(i.Value)).Average();
                      maxHR = listaVa.Select(i => int.Parse(i.Value)).Max();
                      minHR = listaVa.Select(i => int.Parse(i.Value)).Min();

                      es.ValorMax = maxHR;
                      es.ValorMed = mediaHR;
                      es.ValorMin = minHR;

                      estastisticas.Add(es);
                  }
                  */

                //SPO2
                //List<Valores> valoresSPO2 = listaVa.Where(i => i.Type == "SPO2").ToList();


                ////BP
                //List<Valores> valoresBP = listaVa.Where(i => i.Type == "BP").ToList();
                //double mediaBP = valoresBP.Select(i => int.Parse(i.Value)).Average();
                //int maxBP = valoresBP.Select(i => int.Parse(i.Value)).Max();
                //int minBP = valoresBP.Select(i => int.Parse(i.Value)).Min();

                return null;
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }


        public IEnumerable<int> getUtentesAlerts(int sns)
        {
            var result = context.AlertasSet.Where(i => i.Utente.SNS.Equals(sns) && i.Read.Equals("Not Read")).Select(i =>i.Utente.SNS).Distinct();

            return result;
        }

        public List<Alertas> getAlertaSns(int sns, DateTime startBegin, DateTime endBegin)
        {
            try
            {
                List<Alertas> result = context.AlertasSet.Where(i => i.Utente.SNS.Equals(sns)
                && i.Read.Equals("Not Read") && i.Data >= startBegin 
                && i.Data <= endBegin).ToList();

                return result;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Alertas> getAlertaSns( DateTime startBegin, DateTime endBegin)
        {
            try
            {
                List<Alertas> result = context.AlertasSet.Where(i => i.Read.Equals("Not Read") && 
                i.Data >= startBegin
                && i.Data <= endBegin).ToList();

                return result;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Utente> getUtentesAlertsNotRead()
        {
            try
            {
                List<Utente> utentes = new List<Utente>();
                Utente u = new Utente();
                var result = from utente in context.UtenteSet
                             join alerta in context.AlertasSet on
                             utente.Id equals alerta.Utente.Id
                             where alerta.Read.Equals("Not Read")
                             select new { utente };


                foreach (var item in result)
                {
                    u = item.utente;
                    utentes.Add(u);
                }
                return utentes;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void marcarComoLido(Alertas alerta, int id)
        {
            Alertas result = context.AlertasSet.Where(i=>i.Id == id).FirstOrDefault();

            result.Read = alerta.Read;

            context.SaveChanges();
        }


    }
}
