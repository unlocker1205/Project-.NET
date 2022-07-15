using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.NET.Models
{
    public class ItemStore
    {
        private String maLapTop;
        private String tenLaptop;
        private int slNhap;
        private int slXuat;
        private int tonKho;
        public ItemStore()
        {
        }

        public ItemStore(String maLapTop,String tenLaptop, int slNhap, int slXuat, int tonKho)
        {
            this.maLapTop = maLapTop;
            this.tenLaptop = tenLaptop;
            this.slNhap = slNhap;
            this.slXuat = slXuat;
            this.tonKho = tonKho;
        }
        public string MALAPTOP { get => maLapTop; set => maLapTop = value; }
        public string TENLAPTOP { get => tenLaptop; set => tenLaptop = value; }
        public int SLNHAP { get => slNhap; set => slNhap = value; }
        public int SLXUAT { get => slXuat; set => slXuat = value; }
        public int TONKHO { get => tonKho; set => tonKho = value; }
    }
}