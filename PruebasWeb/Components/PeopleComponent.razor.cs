using Microsoft.AspNetCore.Components;
using PruebasWeb.Entities;
using System;

namespace PruebasWeb.Components
{
    public partial class PeopleComponent
    {
        [Parameter]
        public bool IncluirDatosAdicionales
        {
            get => MostrarDatos;
            set
            {
                Console.WriteLine($"value: {value}");
                if (MostrarDatos == value) return;
                MostrarDatos = value;
                OnDatosAdicionalesChangues.InvokeAsync(MostrarDatos);
            }
        }

        [Parameter]
        public People PersonaInfo { get; set; }

        [Parameter]
        public EventCallback<bool> OnDatosAdicionalesChangues { get; set; }
        private bool MostrarDatos { get; set; } = false;

    }
}
