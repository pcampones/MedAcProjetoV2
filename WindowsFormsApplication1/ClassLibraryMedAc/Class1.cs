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


                return null;


            }
           
        }

        public void addUtente(Utente utente)
        {
            context.UtenteSet.Add(utente);
            context.SaveChanges();
        }
    }
}
