using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.NET.Models
{
    public class ManufacturerModel
    {
        private String tenHang;
        private String quocGia;
        private String poster;
        private String logoVuong;
        private String logoNgang;
        private String slogan;

        public ManufacturerModel(string tenHang, string quocGia, string poster, string logoVuong, string logoNgang, string slogan)
        {
            this.tenHang = tenHang;
            this.quocGia = quocGia;
            this.poster = poster;
            this.logoVuong = logoVuong;
            this.logoNgang = logoNgang;
            this.slogan = slogan;
        }

        public string TenHang { get => tenHang; set => tenHang = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
        public string Poster { get => poster; set => poster = value; }
        public string LogoVuong { get => logoVuong; set => logoVuong = value; }
        public string LogoNgang { get => logoNgang; set => logoNgang = value; }
        public string Slogan { get => slogan; set => slogan = value; }
    }
}