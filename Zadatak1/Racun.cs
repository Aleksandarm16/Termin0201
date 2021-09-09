using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public enum Kolicina
    {
        kg,
        l,
        komad
    }
    public class Racun
    {
        public string NazivProdavnice { get; set; }
        public double UkupnaCenaBezPDV { get; set; }
        public double UkupnaCenaSaPDV { get; set; }
        public StavkaRacuna StavkaRacuna { get; set; }
        
        public bool Akcija { get; set; }
        public double Pdv { get; set; }
        public Racun(string NazivProdavnice, StavkaRacuna StavkaRacuna,bool Akcija,double Pdv)
        {

            this.NazivProdavnice = NazivProdavnice;
            this.Pdv = Pdv;
            
            this.StavkaRacuna = StavkaRacuna;
            RacunanjeCene();
        }
        public void RacunanjeCene()
        {
            if (Pdv != 0)
            {
                if (Akcija == true)
                {
                    UkupnaCenaSaPDV =  (Pdv/100 + 1) * StavkaRacuna.Kolicina * StavkaRacuna.CenaPoKomadu * 0.9;
                    UkupnaCenaBezPDV = StavkaRacuna.Kolicina * StavkaRacuna.CenaPoKomadu * 0.9;
                }
                else
                {
                    UkupnaCenaSaPDV = StavkaRacuna.Kolicina * StavkaRacuna.CenaPoKomadu*(Pdv/100 + 1);
                    UkupnaCenaBezPDV = StavkaRacuna.Kolicina * StavkaRacuna.CenaPoKomadu;
                }
            }
            else if(Pdv==0)
            {
                if (Akcija == true)
                {
                    UkupnaCenaSaPDV = StavkaRacuna.Kolicina * StavkaRacuna.CenaPoKomadu * 0.9;
                    UkupnaCenaBezPDV = UkupnaCenaSaPDV;
                }
                else
                {
                    UkupnaCenaSaPDV = StavkaRacuna.Kolicina * StavkaRacuna.CenaPoKomadu;
                    UkupnaCenaBezPDV = UkupnaCenaSaPDV;
                }
            }
        }
        
        public override string ToString()
        {
            return "Naziv prodavnice je: "+NazivProdavnice+"\n" + StavkaRacuna.ToString() + "\nCena bez PDV-a: "+UkupnaCenaBezPDV +
                "\nCena sa PDV-om: " + UkupnaCenaSaPDV + "\nArtikal " + (Akcija == true ? " je na akciji" : " nije na akciji") + 
                "\nPdv artikla je: "+Pdv;
        }

    }
    public class StavkaRacuna
    {
        public string NazivArtikla { get; set; }
        public double Kolicina { get; set; }
        public double CenaPoKomadu { get; set; }
        public Kolicina KolicinaMera { get; set; }

        public StavkaRacuna(string NazivArtikla, double Kolicina, double CenaPoKomadu,Kolicina KolicinaMera)
        {
            this.NazivArtikla = NazivArtikla;
            this.Kolicina = Kolicina;
            this.CenaPoKomadu = CenaPoKomadu;
            this.KolicinaMera = KolicinaMera;
        }
        public override string ToString()
        {
            return "Stavke racuna su: "+NazivArtikla + " Kolicina: "+Kolicina+ (KolicinaMera==Zadatak1.Kolicina.kg?" kg":
                KolicinaMera==Zadatak1.Kolicina.komad?" komada":" l")+" Cena po komadu: "+CenaPoKomadu;
        }
    }
}
