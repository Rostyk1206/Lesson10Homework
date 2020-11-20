using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10Homework3
{
    class Converter
    {
        public double dollar;
        public double euro;
        public double zlt;

        public Converter(double usd,double eur,double zlt)
        {
            dollar = usd;
            euro = eur;
            this.zlt = zlt;
        }
        public void ConvertGrivna(double grivna)
        {
            double grivna_dollar = grivna / dollar;
            double grivna_euro = grivna / euro;
            double grivna_zlt = grivna / zlt;
            Console.WriteLine($"dollar:{grivna_dollar},\neuro:{grivna_euro},\nzlt:{grivna_zlt}");
        }
        public void DollarGrivna(double dollar)
        {
            double grivna = dollar * 27.5;
            Console.WriteLine($"From {dollar} dollars you have {grivna} grivnas ");
        }
        public void EuroGrivna(double euro)
        {
            double grivna = euro * 29.5;
            Console.WriteLine($"From {euro} euros you have {grivna} grivnas ");
        }
        public void ZlotyjGrivna(double zlt)
        {
            double grivna = zlt * 6.5;
            Console.WriteLine($"From {zlt} zlt you have {grivna} grivnas ");
        }
    }
}
