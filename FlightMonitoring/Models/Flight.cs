using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FlightMonitoring.Models
{

    /*
     Auteur:AJ
     La classe Aircraft
    */
    /// <summary>
    ///  Flight Model
    ///  Model uniquement pour les dropdownlists 
    /// </summary>
    public class Flight
    {
        #region Variables public

        public int Id { get; set; }//Identifiant du vol

        public double Distance { get; set; }//Distance du vol

        [Required]
        [Display(Name = "Aircraft")]
        public int SelectedAircraft { get; set; }// Id de l'avion selectioné

        public double FuelRequired { get; set; }// Carburant requis

        [Required]
        public SelectList AirCraft { get; set; }// L'avion selectioné

        [Required]
        [Display(Name = "Airport Arrival")]
        public int SelectedAirportArrival { get; set; }//Id de l'aéroport selectioné

        public SelectList AirportArrival { get; set; }//L'aéroport selectioné

        [Required]
        [Display(Name = "Airport Departure")]
        public int SelectedAirportDeparture { get; set; }//Id de l'aéroport selectioné

        public SelectList AirportDeparture { get; set; }// L'aéroport selectioné
        #endregion



    }
}