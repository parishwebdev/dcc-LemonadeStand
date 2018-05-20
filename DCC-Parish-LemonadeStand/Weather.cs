using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Weather
    {
        List<string> weatherTypes = new List<string> { "sunny", "cloudy", "rain" };
        int minTemp = 60;
        int maxTemp = 99;
        int currentTemp;

        public Weather()
        {
            //two generate methods temp, type??? //here
        }

        public int MinTemp
        {
            get { return minTemp; } set { minTemp = value; }
        }
        public int MaxTemp
        {
            get { return maxTemp; } set { maxTemp = value; }
        }
        public int CurrentTemp
        {
            get { return currentTemp; }
            set
            {
                if (value <= MinTemp)
                {
                    currentTemp = MinTemp;
                }
                else if (value >= MaxTemp)
                {
                    currentTemp = MaxTemp;
                }
                else
                {
                    currentTemp = value;
                }
            }
        }
        public List<string> WeatherTypes
        {
            get
            {
                return weatherTypes;
            }
            set
            {
                weatherTypes = value;
            }
        }
        public int GetCurrentTemp(int minTemp, int maxTemp, Random rTemp)
        {
            currentTemp = rTemp.Next(minTemp, maxTemp);
            return currentTemp;
        }


        //Forecast
        /*
         Public <weather> weekForecast;
         Public void CreateInitialForecast(){};
         Public void GetCurrentDayForecast(){ };
         Public void GetNextDayForecast(){ };
         Public void GetNextSevenDayForecast(){};
          */

        private List<Weather> forecast;
        public List<Weather> Forecast {
            get {
                return forecast;
            }
        }

        public List<Weather> CreateInitalForecast(List<Weather> weekForecast,int numDaysToForecast)
        {
            for (int i = 0; i <= numDaysToForecast; i++)
            {
                weekForecast.Add(new Weather());//here
            }
            return weekForecast;
        }


    }
}
