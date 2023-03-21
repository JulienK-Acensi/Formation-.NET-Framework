using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Tours_OpenData.Parkings_Indigo.Domain
{
    public class Parking
    {
        [Key]
        public int key { get; set; }
        public string libelle_parking { get; set; }
        public string adresse { get; set; }
        public string commune { get; set; }
        public string code_postal { get; set; }
        public double? hauteur_acces_premier_niveau { get; set; }
        public double? hauteur_acces_niveaux { get; set; }
        public string? contact_tel { get; set; }
        public string? contact_email { get; set; }
        public string? infos_horaires { get; set; }
        public string? url_abonnement { get; set; }
        public int? capacite { get; set; }
        public int? places_libres { get; set; }
        public double? taux_disponibilite { get; set; }
        public bool? status { get; set; }
    }
}