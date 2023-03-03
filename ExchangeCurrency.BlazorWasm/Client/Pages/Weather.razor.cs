using ExchangeCurrency.Model;

namespace ExchangeCurrency.BlazorWasm.Client.Pages
{
    public partial class Weather
    {
        char base2Calculate;
        string Errors = string.Empty;
        bool success;
        WeatherConversor weatherConversor = new WeatherConversor();

        string[] results = new string[3];

        private void baseToCalculate(char letter)
        {
            base2Calculate = letter;
            switch (letter)
            {
                case 'C':
                    weatherConversor.GradeF = string.Empty;
                    weatherConversor.GradeK = string.Empty;
                    break;
                case 'F':
                    weatherConversor.GradeC = string.Empty;
                    weatherConversor.GradeK = string.Empty;
                    break;
                case 'K':
                    weatherConversor.GradeC = string.Empty;
                    weatherConversor.GradeF = string.Empty;
                    break;
            }
        }

        private void ValidateInput()
        {
            bool result = false;
            double value = 0;
            switch (base2Calculate)
            {
                case 'C':
                    result = double.TryParse(weatherConversor.GradeC, out value);
                    break;
                case 'F':
                    result = double.TryParse(weatherConversor.GradeF, out value);
                    break;
                case 'K':
                    result = double.TryParse(weatherConversor.GradeK, out value);
                    break;
            }

            success = result;

            Errors = success ? string.Empty : "Please write valid numbers";
        }

        private void CalculateConversion()
        {
            double givenValue = 0;
            switch (base2Calculate)
            {
                case 'C':
                    double.TryParse(weatherConversor.GradeC, out givenValue);
                    results[0] = givenValue.ToString();
                    results[1] = (((givenValue * 9) / 5) + 32).ToString();
                    results[2] = (givenValue + 273.15).ToString();
                    break;
                case 'F':
                    double.TryParse(weatherConversor.GradeF, out givenValue);
                    results[0] = (((givenValue - 32) * 5) / 9).ToString();
                    results[1] = givenValue.ToString();
                    results[2] = ((((givenValue - 32) * 5) / 9) + 273.15).ToString();
                    break;
                case 'K':
                    double.TryParse(weatherConversor.GradeK, out givenValue);
                    results[0] = (givenValue - 273.15).ToString();
                    results[1] = ((((givenValue - 273.15) * 9) / 5) + 32).ToString();
                    results[2] = givenValue.ToString();
                    break;
            }
        }
    }
}
