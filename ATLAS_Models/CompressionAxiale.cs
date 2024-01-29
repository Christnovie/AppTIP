using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATLAS_Models
{
    public class CompressionAxiale
    {
        private const double CoefPartYm = 1.3;
		private const double ConstBeta = 0.2;
        double flamby; 
        double flambz;
        WoodClass curentlywood;
        double stransb;
        double stransh;
        string serviceClass;
        string cumulateChargClass;
        double Ned_Valcal;
        KmodClass kmodClass;
        string kmodname;

        //Variable edit and getter value 
        public double Stransb { get { return stransb; } set { stransb = value; } }
        public double Stransh { get { return stransh; } set { stransh = value; } }
        public double NedValcal { get { return Ned_Valcal; } set { Ned_Valcal = value; } }
        public string ServiceClass { get { return serviceClass; } set { serviceClass = value; } }
        public string CumulateChargClass { get { return cumulateChargClass; } set { cumulateChargClass = value; } }
  		public double Flamby{get {return flamby;}set {flamby = value}}       
  		public double Flambz{get {return flambz;}set {flambz = value}}       
		public WoodClass CurrentWood
        {
            get { return curentlywood; }
            set { curentlywood = value; }
        }
        public string KmodName
        {
            get { return kmodname; }set { kmodname = value; } 
        }
        public double Kmod
        {
            get
            {
                switch (KmodName)
                {
                    default : return KmodClass.P; 
                    case "LT": return KmodClass.LT;
                    case "CT": return KmodClass.CT;
                    case "MT": return KmodClass.MT;
                    case "I": return KmodClass.I;
                }
            }
        }
        public KmodClass KmodClass { get { return kmodClass; }set { kmodClass = value; } }

        //Construct for instance Calculator class (CompressionAxiale)
        public CompressionAxiale()
        {
          
        }
        //Aire de la section (A)
        public  double CalAire
        {
            get { return stransb * stransh; }
        }
        //Valeur de calcul de la contrainte axiale (σc,0,d)

        public double ContrainteAxialCal
        {
            get {return Ned_Valcal*CalAire; }
        }
        //Valeur de calcul de la résistance en compression axiale (fc,0,d) 
        public double ResitanceAxeCompress
        {
            get {return Kmod*(CurrentWood.fc0k/CoefPartYm); }
        }
        //Moment d’inertie de flexion par rapport à l’axe y (Iy)
        public double CalInercyMomentY
        {
            get { return (Stransb * Math.Pow(stransh, 3))/12; }
        }
        //Moment d’inertie de flexion par rapport à l’axe z (Iz)
        public double CalInercyMomentZ
        {
            get { return (Stransb * Math.Pow(stransb, 3)) / 12; }
        }
        //Elancement mécanique par rapport à l’axe y (γy) 

        //Coefficient de flambement et resultat

    }  
}
