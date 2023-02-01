using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsAppLeroy
{
    public partial class WeatherForm : Form

    {
        private const string FETCH_WEATHER_URL = "https://api.openweathermap.org/data/2.5/weather?q=";
        private const string FETCH_5DAY_URL = "https://api.openweathermap.org/data/2.5/forecast?q=";
        private const string API_KEY = "121ad5ff257fdad2a17721a0e1df92e4";
        public string city = "";
        
        public WeatherForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
           city = EnterCityBox.Text;
            FetchWeatherData(city);
            Fetch5DayWeather(city);
            
        }

        public async void FetchWeatherData(string city)
        {
            var url = FETCH_WEATHER_URL + city + "&units=imperial&appid=" + API_KEY;
           

            try
            {
                //fetch API data using Http
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(url))
                using (HttpContent content = response.Content)
                {
                    //assign the coordinates to a string value
                    string result = await content.ReadAsStringAsync();
                    //deserialize the object so we can store the values
                    Rootobject Root = JsonConvert.DeserializeObject<Rootobject>(result);
                    WeatherIcon.ImageLocation = "https://openweathermap.org/img/wn/" + Root.weather[0].icon + "@2x.png";
                    Degrees.Text = Root.main.temp.ToString() + "°";
                    Condition.Text = Root.weather[0].description;
                    MinTemp.Text = Root.main.temp_min.ToString() + "°";
                    MaxTemp.Text = Root.main.temp_max.ToString() + "°" ;
                    HumidityVal.Text = Root.main.humidity.ToString();
                    WindVal.Text = Root.wind.speed.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void Fetch5DayWeather(string city)
        {
            var fiveDayUrl = FETCH_5DAY_URL + city + "&units=imperial&appid=" + API_KEY;

            try
            {
                //fetch API data using Http
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(fiveDayUrl))
                using (HttpContent content = response.Content)
                {
                    //assign the coordinates to a string value
                    string result = await content.ReadAsStringAsync();
                    //deserialize the object so we can store the values
                    Root5Day Root = JsonConvert.DeserializeObject<Root5Day>(result);

                    FiveDayForecast FUC;
                    for(int i = 0; i < 40; i++)
                    {
                        FUC = new FiveDayForecast();
                        FUC.PicWeatherIcon.ImageLocation = "https://openweathermap.org/img/wn/" + Root.list[i].weather[0].icon + "@2x.png";
                        //Convert the format of Year Day Month in to Day of the week
                        String day = ConvertDateToDay(Root.list[i].dt_txt.ToString().Substring(0,10));
                        String time = Root.list[i].dt_txt.ToString().Substring(11);
                        FUC.DayLbl.Text = day;
                        FUC.DateTime.Text = ChangeTimeFormat(time);
                        FUC.ConditionLbl.Text = Root.list[i].weather[0].description;
                        FUC.Degree5DayLbl.Text = Root.list[i].main.temp + "°";
                        FLP.Controls.Add(FUC);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        String ConvertDateToDay(string date)
        { 
            //Converts the date format into day of the week
            DateTime dateTime = Convert.ToDateTime(date);
            return dateTime.DayOfWeek.ToString();
        }

        String ChangeTimeFormat(String time24)
        {
            //Converts the 24 hour format in to a 12 hour format with AM and PM
            DateTime dt = DateTime.ParseExact(time24, "HH:mm:ss", null);
            string time12 = dt.ToString("0h:mm:ss tt");
            return time12;
        }
    }
}
