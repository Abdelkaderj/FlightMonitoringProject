using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FlightMonitoring.Models
{
    public class FlightViewModel
    {

        #region Variables public
        public int Id { get; set; }  //Identifiant du vol

        public double Distance { get; set; } //Distance du vol

        public double FuelConsumptionPerKm { get; set; }  

        [Required]
        [Display(Name = "Aircraft")]
        public int SelectedAircraft { get; set; } // Id de l'avion selectioné

        [Required]
        [StringLength(50,
        ErrorMessage = "The aircraft name cannot be longer than 50 characters")]
        public string AircraftName { get; set; }

        public double FuelRequired { get; set; } // Le carburant requis


        [Required]
        [Display(Name = "Airport Arrival")]
        public int SelectedAirportArrival { get; set; } // L'aéroport selectioné


        public String AirportArrivalName { get; set; }  // L'aéroport selectioné


        [Required]
        [Display(Name = "Airport Departure")]
        public int SelectedAirportDeparture { get; set; }// Id de l'aéroport de depart

        public String AirportDepartureName { get; set; } //Nom de l'aéroport 
        #endregion

    }
}