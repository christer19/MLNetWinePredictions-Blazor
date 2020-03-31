using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MLNetWinePredictions_Blazor.Models
{
    public class WineModel
    {
        [Required]
        public string Type { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public float FixedAcidity { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public float VolatileAcidity { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public float CitricAcid { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public float ResidualSugar { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public float Chlorides { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public float FreeSulfurDioxide { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public float TotalSulfurDioxide { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public float Density { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public float Ph { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public float Sulphates { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public float Alcohol { get; set; }

        public float Quality { get; set; }
    }
}
