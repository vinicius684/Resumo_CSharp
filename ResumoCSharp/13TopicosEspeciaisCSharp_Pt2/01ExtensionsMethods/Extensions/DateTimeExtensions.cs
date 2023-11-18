using System.Globalization;

namespace System // interessante já colocar a classe no mesmo namespace do tipo que estou extendendo pra não ter fazendo um tanto de import
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj) { //(this DateTime) metodo de extensao do tipo DateTime; (this obj) fazendo uma referencia para o próprio obj(dt)
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24.0) { 
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture);
            }
            else {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture);
            }
        }


    }
}
