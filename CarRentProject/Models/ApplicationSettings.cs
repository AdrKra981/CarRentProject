using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentProject.Models
{
    public class ApplicationSettings
    {
        public string JWT_Secret { get; set; }
        public string BaseURL { get; set; }     
    }
}
