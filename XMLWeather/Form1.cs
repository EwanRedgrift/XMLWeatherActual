﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast("Stratford,CA");
            ExtractCurrent("Stratford,CA");
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast(string Location)
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=" + $"{Location}" + "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                Day day = new Day();

                //Get time and day
                reader.ReadToFollowing("time");
                day.date = reader.GetAttribute("day");

                //Get temperatures
                reader.ReadToFollowing("temperature");
                day.tempLow = reader.GetAttribute("min");
                day.tempHigh = reader.GetAttribute("max");

                //TODO: if day object not null add to the days list
                days.Add(day);
            }
        }

        public static void ExtractCurrent(string Location)
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=" + $"{Location}" + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = (reader.GetAttribute("value"));
        }


    }
}
