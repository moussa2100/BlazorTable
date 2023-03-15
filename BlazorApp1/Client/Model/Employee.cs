using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlazorApp1.Client.Model
{
    public class Employee
    {
        
        [JsonProperty("emp_id")]
        [Display(Name ="Employee ID")]
        public string emp_id { get; set; }

        [JsonProperty("emp_name")]
        public string? emp_name { get; set; }
        [JsonProperty("emp_project") ]
        public string? emp_project { get; set; }
        [JsonProperty("emp_salary")]
        public double emp_salary { get; set; }
    }
}
