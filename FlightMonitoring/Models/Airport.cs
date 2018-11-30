using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FlightMonitoring.Models
{
    /*
       Auteur:AJ
       La classe Airport
    */
    /// <summary>
    ///  Aircraft Model
    /// </summary>
    public class Airport
    {
        #region Variables public

        public int Id { get; set; }//Identifant de l'aéroport
        [Required]
        [StringLength(50,
        ErrorMessage = "The airport name cannot be longer than 50 characters")]
        public string Name { get; set; }//Nom de l'aéroport 
        [Required(ErrorMessage = "The airport Latitude must be entred")]
        public double Latitude { get; set; }//Latitude de l'aéroport
        [Required(ErrorMessage = "The airport Longititude must be entred")]
        public double Longititude { get; set; }//Longititude de l'aéroport

        #endregion

    }
}