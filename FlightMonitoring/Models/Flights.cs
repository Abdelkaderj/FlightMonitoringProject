using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FlightMonitoring.Models
{
    /*
    Auteur:AJ
    La classe Flights
   */
    /// <summary>
    ///  Flights Model
    ///  Model uniquement pour les dropdownlists 
    /// </summary>
    public class Flights
    {

        #region Variables public
        public int Id { get; set; } //Identifiant du vol

        public double Distance { get; set; } //Distance du vol

        [Required]
        [Display(Name = "Aircraft")]
        public int SelectedAircraft { get; set; }// L'avion selectioné

        public double FuelRequired { get; set; }// Le carburant requis

        [Required]
        [Display(Name = "Airport Departure")]
        public int SelectedAirportDeparture { get; set; } // Id de l'aéroport de depart


        [Required]
        [Display(Name = "Airport Departure")]
        public int SelectedAirportArrival { get; set; }// Id de l'aéroport d'arrivé
        public virtual Aircraft AirCraft { get; set; }// Objet avion referencé 

        public virtual Airport AirportDeparture { get; set; }//Objet aéroport de depart referencé

        public virtual Airport AirportArrival { get; set; }//Objet aéroport d'arrivé referencé
        #endregion


    }
}