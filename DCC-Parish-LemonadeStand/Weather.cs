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
        private List<Weather> actualWeather= new List<Weather>();
        public Weather(Random rTemp)
        {
            
            GenerateWeather(rTemp);
            
        }
        public Weather(int numDays,Random rand)
        {
            CreateInitalWeather(numDays, rand);
            GenerateForecast(rand);
           
        }

        public double MinTemp
        {
            get { return minTemp; }
            set { minTemp = value; }
        }
        public double MaxTemp
        {
            get { return maxTemp; }
            set { maxTemp = value; }
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
        public string CurrentCondition { get { return currentCondition; } set { currentCondition = value; } }



        public List<Weather> ActualWeather
        {
            get
            {
                return actualWeather;
            }
            set
            {
                actualWeather = value;
            }
        }


        public void SetCurrentTemp(double minTemp, double maxTemp, Random rTemperature)
        {
            CurrentTemp = rTemperature.Next((int)minTemp, (int)maxTemp);
        }
        public void SetCurrentCondition(Random rCondition)
        {
            CurrentCondition = weatherTypes[rCondition.Next(0, WeatherTypes.Count)];
        }
        public void GenerateWeather(Random rand)
        {
            SetCurrentTemp(minTemp, maxTemp, rand);
            SetCurrentCondition(rand);
            
        }


        public void CreateInitalWeather(int numDays, Random rTemp)
        {

            for (int i = 0; i < numDays; i++)
            {
                ActualWeather.Add(new Weather(rTemp));
            }
            
        }

        public void GenerateForecast(Random rand)
        {

                AlterTempForForecast(rand, ActualWeather);
                AlterConditionForForecast(rand, ActualWeather);

        }
        public void AlterTempForForecast(Random rand, List<Weather> w)
        {

            for (int i = 0; i < w.Count; i++)
            {
                int variation = rand.Next(1, 2);
                switch (variation)
                {
                    case 1:
                       w[i].CurrentTemp = Math.Round(w[i].currentTemp * 0.95);
                        break;
                    case 2:
                        w[i].CurrentTemp = Math.Round(w[i].currentTemp * 1.05);
                        break;
                    default:
                        w[i].CurrentTemp *= 1;
                        break;
                }
            }
        }
        public void AlterConditionForForecast(Random rand, List<Weather> w)
        {
            for (int i = 0; i < w.Count; i++)
            {
                int variation = rand.Next(0, 8);
                switch (variation)
                {
                    case 0:
                    case 1:
                    case 3:
                    case 7:
                        w[i].CurrentCondition = WeatherTypes[0];
                        break;
                    case 2:
                    case 4:
                    case 8:
                        w[i].CurrentCondition = WeatherTypes[1];
                        break;
                    case 5:
                    case 6:
                        w[i].CurrentCondition = WeatherTypes[2];
                        break;
                    default:
                        w[i].CurrentCondition = CurrentCondition;
                        break;
                }
            }
            
        }

    }
}