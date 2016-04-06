using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        UtenteWeb GetUtenteBySNS(int sns);

        [OperationContract]
        void AddUtente(UtenteWeb utente);

        [OperationContract]
        bool EditUtente(UtenteWeb utente);

        [OperationContract]
        List<UtenteWeb> GetListaUtentes();

        [OperationContract]
        List<ValoresWeb> GetReportsbySNSandDate(int sns, DateTime startDate, DateTime endDate);

        [OperationContract]
        void AddValues(int sns, string type, string value, DateTime data);

        //[OperationContract]
        //List<AlertasWeb> GetValuesAlertsbySns(int sns);

        //[OperationContract]
        //List<ValoresWeb> GetAlertNotRead(int sns);

        [OperationContract]
        List<ValoresWeb> GetRegistofGrahp(int sns);


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.

    [DataContract]
    public class UtenteWeb
    {
        [DataMember]
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        [DataMember]
        private int phone;

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        [DataMember]
        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        [DataMember]
        private DateTime birthdate;
        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        [DataMember]
        private int bi;

        public int Bi
        {
            get { return bi; }
            set { bi = value; }
        }
        [DataMember]
        private int sns;

        public int Sns
        {
            get { return sns; }
            set { sns = value; }
        }
        [DataMember]
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        [DataMember]
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        [DataMember]
        private string alergies;

        public string Alergies
        {
            get { return alergies; }
            set { alergies = value; }
        }

        [DataMember]
       private int height;

       public int Height
        {
            get { return height; }
            set { height = value; }
        }
 
        [DataMember]
        private int nexOfKinContact;
        public int NexOfKinContact
        {
            get { return nexOfKinContact; }
            set { nexOfKinContact = value; }
        }
        [DataMember]
        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        [DataMember]
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        [DataMember]
        private string ative;
        public string Ative
        {
            get { return ative; }
            set { ative = value; }
        }



    } 

    [DataContract]
    public class ValoresWeb
    {
        [DataMember]
        private int sns;
 
        public int SNS
        {
            get { return sns; }
            set { sns = value; }
        }

        [DataMember]
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        [DataMember]
        private string valueR ;

        public string Value
        {
            get { return valueR; }
            set { valueR = value; }
        }
        
        [DataMember]
        private DateTime dataOfReposit;

        public DateTime DataOfReposit
        {
            get { return dataOfReposit; }
            set { dataOfReposit = value; }
        }

        [DataMember]
        private int snsUtente;

        public int SnsUtente
        {
            get { return snsUtente; }
            set { snsUtente = value; }
        }

        [DataMember]
        private string nomeUtente;

        public string NomeUtente
        {
            get { return nomeUtente; }
            set { nomeUtente = value; }
        }

        [DataMember]
        private string sUtente;

        public string SobreUtente
        {
            get { return sUtente; }
            set { sUtente = value; }
        }
        
    }

    [DataContract]

    public class AlertasWeb
    {
        [DataMember]
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        [DataMember]

        private DateTime dataAlerta;

        public DateTime DataAlerta
        {
            get { return dataAlerta; }
            set { dataAlerta = value; }
        }

        [DataMember]

        private string read;

        public string Read
        {
            get { return read; }
            set { read = value; }


        }
        [DataMember]
        private int snsUtente;

        public int SnsUtente
        {
            get { return snsUtente; }
            set { snsUtente = value; }
        }


    }
}
