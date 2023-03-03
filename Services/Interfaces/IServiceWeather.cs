using ExchangeCurrency.Model;

namespace Services.Interfaces
{
    public interface IServiceWeather
    {
        WeatherConversor MakeConversion(string tipo, double dato);
    }
}