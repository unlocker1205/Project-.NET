using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.NET.Models
{
    public class ProductModel
    {
        String MALAPTOP;
        String TENLAPTOP;
        String HANG;
        int GIABAN;
        String SERIES;
        String MAU;
        String CPU;
        String VGA;
        String RAM;
        String KICHTHUOCMANHINH;
        String OCUNG;
        String BANPHIM;
        String PIN;
        String KHOILUONG;
        String LINKHINH1;
        String LINKHINH2;
        String LINKHINH3;
        String LINKHINH4;
        String LINKHINH5;

        public ProductModel()
        {
        }

        public ProductModel(string mALAPTOP, string tENLAPTOP, string hANG, int gIABAN, string sERIES, string mAU, string cPU, string vGA, string rAM, string kICHTHUOCMANHINH, string oCUNG, string bANPHIM, string pIN, string kHOILUONG, string lINKHINH1, string lINKHINH2, string lINKHINH3, string lINKHINH4, string lINKHINH5)
        {
            MALAPTOP1 = mALAPTOP;
            TENLAPTOP1 = tENLAPTOP;
            HANG1 = hANG;
            GIABAN1 = gIABAN;
            SERIES1 = sERIES;
            MAU1 = mAU;
            CPU1 = cPU;
            VGA1 = vGA;
            RAM1 = rAM;
            KICHTHUOCMANHINH1 = kICHTHUOCMANHINH;
            OCUNG1 = oCUNG;
            BANPHIM1 = bANPHIM;
            PIN1 = pIN;
            KHOILUONG1 = kHOILUONG;
            LINKHINH11 = lINKHINH1;
            LINKHINH21 = lINKHINH2;
            LINKHINH31 = lINKHINH3;
            LINKHINH41 = lINKHINH4;
            LINKHINH51 = lINKHINH5;
        }

        public string MALAPTOP1 { get => MALAPTOP; set => MALAPTOP = value; }
        public string TENLAPTOP1 { get => TENLAPTOP; set => TENLAPTOP = value; }
        public string HANG1 { get => HANG; set => HANG = value; }
        public int GIABAN1 { get => GIABAN; set => GIABAN = value; }
        public string SERIES1 { get => SERIES; set => SERIES = value; }
        public string MAU1 { get => MAU; set => MAU = value; }
        public string CPU1 { get => CPU; set => CPU = value; }
        public string VGA1 { get => VGA; set => VGA = value; }
        public string RAM1 { get => RAM; set => RAM = value; }
        public string KICHTHUOCMANHINH1 { get => KICHTHUOCMANHINH; set => KICHTHUOCMANHINH = value; }
        public string OCUNG1 { get => OCUNG; set => OCUNG = value; }
        public string BANPHIM1 { get => BANPHIM; set => BANPHIM = value; }
        public string PIN1 { get => PIN; set => PIN = value; }
        public string KHOILUONG1 { get => KHOILUONG; set => KHOILUONG = value; }
        public string LINKHINH11 { get => LINKHINH1; set => LINKHINH1 = value; }
        public string LINKHINH21 { get => LINKHINH2; set => LINKHINH2 = value; }
        public string LINKHINH31 { get => LINKHINH3; set => LINKHINH3 = value; }
        public string LINKHINH41 { get => LINKHINH4; set => LINKHINH4 = value; }
        public string LINKHINH51 { get => LINKHINH5; set => LINKHINH5 = value; }
    }
}