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
        double minTemp = 60;
        double maxTemp = 99;
        double currentTemp;
        string currentCondition;

        public Weather(Random rTemp)
        {
            GenerateWeather(rTemp);
        }

        public double MinTemp
        {
            get { return minTemp; } set { minTemp = value; }
        }
        public double MaxTemp
        {
            get { return maxTemp; } set { maxTemp = value; }
        }
        public double CurrentTemp
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
        public string CurrentCondition { get { return currentCondition; } set{ currentCondition = value; } }

        private List<Weather> forecast;
        public List<Weather> Forecast
        {
            get
            {
                return forecast;
            }
            set
            {
                forecast = value;
            }
        }
        private List<Weather> actualWeather;
        public List<Weather> ActualWeather
        {
            get
            {
                return actualWeather;
            }
        }


        public void SetCurrentTemp(double minTemp, double maxTemp, Random rTemp)
        {
            currentTemp = rTemp.Next((int)minTemp, (int)maxTemp);
        }
        public void SetCurrentCondition(Random rCondition)
        {
            currentCondition = weatherTypes[rCondition.Next(0, WeatherTypes.Count)];
        }
        public void GenerateWeather(Random rand)
        {
            SetCurrentTemp(minTemp,maxTemp, rand);
            SetCurrentCondition(rand);
        }

        //Forecast
        /*
         Public void GetCurrentDayForecast(){ };
          */

        public void CreateInitalWeather(int numDays,Random rTemp)
        {
            List<Weather> weatherList = new List<Weather>();
            for (int i = 0; i < numDays; i++)
            {
                weatherList.Add(new Weather(rTemp));
            }
           actualWeather = weatherList;
        }

        public void GenerateForecast(Random rand)
        {
            forecast = actualWeather;
            for (int i = 0; i < ActualWeather.Count; i++)
            {

                AlterTempForForecast(rand, forecast[i]);
                AlterConditionForForecast(rand, forecast[i]);
            }
            
        }
        public void AlterTempForForecast(Random rand, Weather w)
        {
            int variation = rand.Next(0, 3);
            switch (variation)
            {
                case 1:
                   w.CurrentTemp = Math.Round(w.currentTemp * 0.90);
                   break;
                case 2:
                    w.CurrentTemp = Math.Round(w.currentTemp * 1.10); 
                    break;
                case 0:
                default:
                    w.CurrentTemp *= 1;
                   break;
            }
        }
        public void AlterConditionForForecast(Random rand, Weather w)
        {
            int variation = rand.Next(0, 8);
            switch (variation)
            {
                case 1:
                case 3:
                case 7:
                    w.CurrentCondition = WeatherTypes[0];
                    break;
                case 2:
                case 4:
                case 8:
                    w.CurrentCondition = WeatherTypes[1];
                    break;
                case 5:
                case 6:
                    w.CurrentCondition = WeatherTypes[2];
                    break;
                case 0:
                default:
                    w.CurrentCondition = CurrentCondition;
                    break;
            }
        }
        public void DisplayForecastByNumDays(int numDaysToDisplay)
        {
            for (int j = 0; j < numDaysToDisplay; j++)
            {
                UserInterface.OutputText(j + 1 + ") " + Forecast[j].CurrentCondition + " " + Forecast[j].CurrentTemp);
            }
        }

    }
}
