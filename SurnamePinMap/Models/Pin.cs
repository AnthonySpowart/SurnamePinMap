using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Text;
using SurnamePinMap.Helpers;

namespace SurnamePinMap.Models
{

    // http://www.asp.net/web-api/overview/formats-and-model-binding/json-and-xml-serialization

    [JsonConverter(typeof(PinToGeoJsonConverter))]
    public class Pin : IAudit
    {
        public int Id { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        [Required]
        [JsonIgnore]
        public string Email { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [JsonIgnore]
        public DateTime Created { get; set; }
        
        [JsonIgnore]
        public DateTime? Modified { get; set; }
    }
}