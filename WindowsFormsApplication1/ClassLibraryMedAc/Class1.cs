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
            catch (Exception)
            {
                return null;
            }
         
        }

        public List<Valores> getValuesbySNS(int sns)
        {
            try
            {
                var listaVa = context.ValoresSet.Where(i => i.Utente.SNS.Equals(sns)).ToList();

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

        public List<Valores> getAlertaSns(int sns)
        {
            try
            {
                List<Valores> result = context.ValoresSet.Where(i => i.Utente.SNS.Equals(sns) 
                && i.Alertas.Read.Equals("Not Read")).ToList();
                return result;

            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Valores> getUtenteSnsNotRead()
        {
            try
            {
                List<Valores> result = context.ValoresSet.Where(i=>i.Alertas.Read.Equals("Not Read")).ToList();
                return result;

            }
            catch (Exception)
            {

                return null;
            }
        }

/*        public List<DateTime> addDatas(DateTime data)
        {
            List<DateTime> datas = context.ValoresSet.
                Where(i=>i.DataOfRegist.);
            return datas;
        }*/
    }
}
