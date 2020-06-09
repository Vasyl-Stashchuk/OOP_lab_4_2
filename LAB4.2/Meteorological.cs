using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4._2
{
    public class Meteorological
    {
        private string month;
        private double data;
        private double data1;
        private double airtempreture;
        private double airtempreture1;

        public Meteorological()
        {
            month = "None";
            data = 0;
            airtempreture = 0;
        }

        public Meteorological(string month, double data, double data1, double airtemperature, double airtempreture1)
        {
            this.month = month;
            this.data = data;
            this.data1 = data1;
            this.airtempreture = airtemperature;
            this.airtempreture1 = airtempreture1;

        }
        public Meteorological( int airtemperature, int airtempreture1)
        {
           
            this.airtempreture = airtemperature;
            this.airtempreture1 = airtempreture1;

        }
        public string Month
        {
            get { return month; }
            set { month = value; }

        }
        public double Data
        {
            get { return data; }
            set { data = value; }
        }
        public double Data1
        {
            get { return data1; }
            set { data1 = value; }
        }
        public double AirTemperature
        {
            get { return airtempreture; }
            set { airtempreture = value; }
        }
        public double AirTemperature1
        {
            get { return airtempreture1; }
            set { airtempreture1=value; }
        }
        public void printResult()
        {
            double mid = (airtempreture + airtempreture1) / 2;
            Console.WriteLine("\n| Month | Average air temperature |");
            Console.Write("|" + month +  "|" +         mid          + "|");
       
        }

        

    }
}
