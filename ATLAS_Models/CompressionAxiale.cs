using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATLAS_Models
{
    public class CompressionAxiale
    {
        private double CoefPartYm = 1.3;
		private double constBetaRextitude = 0.2;
        double flamby=50; 
        double flambz=50;
        WoodClass curentlywood;
        double stransb=0;
        double stransh=0;
        string serviceClass;
        string cumulateChargClass;
        double Ned_Valcal=0;
        KmodClass kmodClass;

        //Variable edit and getter value
        public double CoefYM { get {return CoefPartYm; } set { CoefPartYm = value; } }
        public double Stransb { get { return stransb; } set { stransb = value; } }
        public double Stransh { get { return stransh; } set { stransh = value; } }
        public double NedValcal { get { return Ned_Valcal; } set { Ned_Valcal = value; } }
        public string ServiceClass { get { return serviceClass; } set { serviceClass = value; } }
        public string CumulateChargClass { get { return cumulateChargClass; } set { cumulateChargClass = value; } }
  		public double Flamby{get {return flamby;}set { flamby = value; }}       
  		public double Flambz{get {return flambz;}set { flambz = value; }}
        public double ConstBetaRextitude { get {return constBetaRextitude;}set { constBetaRextitude = value; }}
		public WoodClass CurrentWood
        {
            get { return curentlywood; }
            set { curentlywood = value; }
        }

        public double Kmod
        {
            get
            {
                switch (ServiceClass)
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
        //Calcution of all 
        //Construct for instance Calculator class (CompressionAxiale)
        public CompressionAxiale()
        {
          
        }
        //Aire de la section (A)
        public  double CalAire
        {
            get { return VerifCalc(stransb * stransh)/100; }
        }
        //Valeur de calcul de la contrainte axiale (σc,0,d)
        public double ContrainteAxialCal
        {
            get {return VerifCalc(Ned_Valcal/CalAire)*10; }
        }
        //Valeur de calcul de la résistance en compression axiale (fc,0,d) 
        public double ResitanceAxeCompress
        {
            get {return VerifCalc(Kmod * (CurrentWood.fc0k/CoefPartYm)); }
        }
        //Moment d’inertie de flexion par rapport à l’axe y (Iy)
        public double CalInercyMomentY
        {
            get { return VerifCalc(Stransb * Math.Pow(stransh, 3))/120000; }
        }
        //Moment d’inertie de flexion par rapport à l’axe z (Iz)
        public double CalInercyMomentZ
        {
            get { return VerifCalc(Stransh * Math.Pow(stransb, 3)) / 120000; }
        }
        //Elancement mécanique par rapport à l’axe y (γy)
        public double CalMecanicElancementY
        {
            get { return VerifCalc(Flamby * Math.Sqrt(CalAire / CalInercyMomentY)); }
        }
        //Elancement mécanique par rapport à l’axe z (γz) 
        public double CalMecanicElancementZ
        {
            get { return VerifCalc(Flambz * Math.Sqrt( CalAire/ CalInercyMomentZ)); }
        }
        //Elancement relatif par rapport à l’axe y (λrel,y) 
        public double CalRelatifElancementY
        {
            get { return VerifCalc((CalMecanicElancementY / Math.PI) * Math.Sqrt(CurrentWood.fc0k / (CurrentWood.E005 * 10))/10); }

        }
        //Elancement relatif par rapport à l’axe z (λrel,z) 
        public double CalRelatifElancementZ
        {
            get { return VerifCalc((CalMecanicElancementZ / Math.PI) * Math.Sqrt(CurrentWood.fc0k / (CurrentWood.E005 * 10)) / 10); }

        }
        //Coefficient (ky) 
        public double CoefficentKy 
        {
            get { return VerifCalc(0.5 * (1 + ConstBetaRextitude * (CalRelatifElancementY - 0.3) + Math.Pow(CalRelatifElancementY, 2))); }
        }
        //Coefficient (kz) 
        public double CoefficentKz 
        {
            get { return VerifCalc(0.5 * (1 + ConstBetaRextitude * (CalRelatifElancementZ - 0.3) + Math.Pow(CalRelatifElancementZ, 2))); }
        }
        //Coefficient de flambement par rapport à l’axe y(kc, y)
        public double CoefficentFlambY
        {
            get { return VerifCalc(1 / (CoefficentKy + Math.Sqrt(Math.Pow(CoefficentKy, 2) - Math.Pow(CalRelatifElancementY, 2)))); }
        }
        //Coefficient de flambement par rapport à l’axe z (kc,z) 
        public double CoefficentFlambZ
        {
            get { return VerifCalc(1 / (CoefficentKz + Math.Sqrt(Math.Pow(CoefficentKz, 2) - Math.Pow(CalRelatifElancementZ, 2)))); }
        }
        //Coefficient de flambement (kc)
        public double CoefficentFlamb
        {
            get
            {   
                if (CalRelatifElancementY < 0.3 && CalRelatifElancementZ < 0.3)
                {
                    return 1.00;
                }
                else
                {
                    return VerifCalc( Math.Min(CoefficentFlambY, CoefficentFlambZ));
                   
                }
            }
        }
        //Vérification de la résistance à la compression axiale
        public double VerifResAxialCompress
        {
            get { return VerifCalc(ContrainteAxialCal / (CoefficentFlamb * ResitanceAxeCompress)); }
        }

        //Resultat point rupture et recommandation
        //Retrouver la force max au point de rupture 
        public double CalcMaxRuputureForce
        {
            get { return VerifCalc((CalAire * CoefficentFlamb * ResitanceAxeCompress) / 10); }
        }
        //Retrouver la force max recommandé 
        public double CalcRecomandedForce
        {
            get { return VerifCalc((CalAire * CoefficentFlamb * ResitanceAxeCompress * 0.85) / 10); }
        }
        //Retrouver Aire minimal depuis une force point de rupture
        public double CalcMinAire
        {
            get { return VerifCalc(10 * Ned_Valcal / (CoefficentFlamb * ResitanceAxeCompress)); }
        }
        //Retrouver Aire minimal recomandée depuis une force 
        public double CalcMinRecomandedAire
        {
            get { return VerifCalc(10 * Ned_Valcal / (CoefficentFlamb * ResitanceAxeCompress * 0.85)); }
        }

        //Dimmentions carrées
        //Retouver les dimension du poto au point de rupture pour une surface carré
        public double CalcSiseH_B
        {
            get { return VerifCalc(Math.Sqrt(CalcMinAire) * 10); }
        }
        //Retouver les dimension recommandée du poto pour une surface carré
        public double CalcSiseRecomandedH_B
        {
            get { return VerifCalc(Math.Sqrt(CalcMinRecomandedAire) * 10); }
        }

        //Dimmention Rectangle
        //Retouver les dimension recommandée du poto pour une surface Rectangulaire
        public double CalcSiseRecomandedH_Rectangle
        {
            get { return VerifCalc(Math.Sqrt(CalcMinRecomandedAire * 3 / 2) * 10); }
        }
        public double CalcSiseRecomandedB_Rectangle
        {
            get { return VerifCalc(CalcSiseRecomandedH_Rectangle * 2 / 3)  ; }
        }

        //Retrouver la force recommandé au point de rupture 
        public double CalcSiseRupH_Rectangle
        {
            get { return VerifCalc(Math.Sqrt(CalcMinAire * 3 / 2) * 10); }
        }
        public double CalcSiseRupB_Rectangle
        {
            get { return VerifCalc(CalcSiseRupH_Rectangle * 2 / 3); }
        }
        public double VerifCalc(double result)
        {
            if (result > 0)
            {

                return Math.Round(result,5);
            }
            else
            {
                return 0;
            }
        }
    }
}
