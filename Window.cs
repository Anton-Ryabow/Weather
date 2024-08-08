namespace Weather
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> result = Weather.GetWeather();
            labelTime.Text = result["time"].ToString().Substring(11);
            labelFeelslike.Text = "Ощущается как" + result["feelslike"] + " °C";
            labelDesc.Text = result["description"];
            labelTemp.Text = result["temp"] + " °C";
            labelWindValue.Text = Weather.WindToMPS(result["wind_kph"].ToString());
            labelHumidityValue.Text = result["humidity"] + "%";
            labelPrecipValue.Text = result["precip_mm"] + " мм";
            pictureBox.ImageLocation = "https:" + result["icon"];
        }
    }
}