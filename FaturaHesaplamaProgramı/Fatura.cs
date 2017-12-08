using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaHesaplamaProgramı
{
    class Fatura
    {
        private double gunduzTuketim;
        private double puantTuketim;
        private double geceTuketim;
        private double faturaTutar;
        private double birimFiyatGunduz;
        private double birimFiyatPuant;
        private double birimFiyatGece;

        public double GunduzTuketim
        {
            get
            {
                return gunduzTuketim;
            }
            set
            {
                gunduzTuketim = value;
            }
        }

        public double PuantTuketim
        {
            get
            {
                return puantTuketim;
            }
            set
            {
                puantTuketim = value;
            }
        }

        public double GeceTuketim
        {
            get
            {
                return geceTuketim;
            }
            set
            {
                geceTuketim = value;
            }
        }

        public double FaturaTutar
        {
            get
            {
                return faturaTutar;
            }
            set
            {
                faturaTutar = value;
            }
        }

        public void Hesapla()
        {
            birimFiyatGunduz = 0.31469456;
            birimFiyatPuant = 0.37823100;
            birimFiyatGece = 0.11424900;
            double tutar = 0, hizmetBedeli = 0.00740112, sayacOkumaBedeli = 0.544, dagitimBedeli = 0.02822584;
            double enerjiFonu = 0.008, trtPayi = 0.016, tuketimVergisi = 0.04, iletimVergisi = 0.00870720;

            tutar += gunduzTuketim * birimFiyatGunduz;
            tutar += geceTuketim * birimFiyatGece;
            tutar += puantTuketim * birimFiyatPuant;
            double toplamTuketim = gunduzTuketim + puantTuketim + geceTuketim;

            tutar += toplamTuketim * hizmetBedeli;
            tutar += sayacOkumaBedeli;
            tutar += toplamTuketim * dagitimBedeli;
            tutar += toplamTuketim * iletimVergisi;

            tutar += tutar * enerjiFonu + tutar * trtPayi + tutar * tuketimVergisi;

            faturaTutar = tutar + tutar * 0.18;
        }
    }
}
