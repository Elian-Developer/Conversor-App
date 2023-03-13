using Conversor_Currecy_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Currecy_App.Services
{
    public class ConversorService
    {
        public static double ConvertirMoneda(ConversorViewModel cm)
        {
            double Resultado = 0;

            if (cm.MonedaOrigen.Equals("DOP") && cm.MonedaDestino.Equals("USD"))
            {
                Resultado = cm.Cantidad * 0.01802;
            }
            else if (cm.MonedaOrigen.Equals("DOP") && cm.MonedaDestino.Equals("EUR"))
            {
                Resultado = cm.Cantidad * 0.01698;
            }
            else if (cm.MonedaOrigen.Equals("DOP") && cm.MonedaDestino.Equals("DOP"))
            {
                Resultado = cm.Cantidad;

            }
            else if (cm.MonedaOrigen.Equals("USD") && cm.MonedaDestino.Equals("EUR"))
            {
                Resultado = cm.Cantidad * 0.9416;

            }
            else if (cm.MonedaOrigen.Equals("USD") && cm.MonedaDestino.Equals("DOP"))
            {
                Resultado = cm.Cantidad * 55.46;
            }
            else if (cm.MonedaOrigen.Equals("USD") && cm.MonedaDestino.Equals("USD"))
            {
                Resultado = cm.Cantidad;
            }
            else if (cm.MonedaOrigen.Equals("EUR") && cm.MonedaDestino.Equals("DOP"))
            {
                Resultado = cm.Cantidad * 58.85;
            }
            else if (cm.MonedaOrigen.Equals("EUR") && cm.MonedaDestino.Equals("USD"))
            {
                Resultado = cm.Cantidad * 1.0610;
            }
            else if (cm.MonedaOrigen.Equals("EUR") && cm.MonedaDestino.Equals("EUR"))
            {
                Resultado = cm.Cantidad * 55.46;
            }

            return Resultado;

        }
    }
}
