using PruebasWeb.Entities;
using System;

namespace PruebasWeb.Pages
{
    public partial class Parameters
    {
        protected People PersonaInfo = new();
        private bool DatosAdcionales { get; set; }

        protected override void OnInitialized()
        {
        }
        private void OnDatosAdicionalesChangue(bool incluirDatosAdicionales)
        {
            Console.WriteLine($"Datos incluirDatosAdicionales: {incluirDatosAdicionales}");
            DatosAdcionales = incluirDatosAdicionales;
        }
        private void Guardar()
        {
            Console.WriteLine($"Datos adicionales: {DatosAdcionales}");
            Console.WriteLine($"Número de identificación: {PersonaInfo.NumeroIdentificacion}");
            Console.WriteLine($"Número de Nombres: {PersonaInfo.Nombres}");
            Console.WriteLine($"Número de Apellidos: {PersonaInfo.Apellidos}");
            Console.WriteLine($"Número de NumeroCelular: {PersonaInfo.NumeroCelular}");
            Console.WriteLine($"Número de Email: {PersonaInfo.Email}");
        }
    }
}
