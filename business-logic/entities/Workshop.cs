using System;
using System.ComponentModel.DataAnnotations;
namespace workshop_api.business_logic.entities
{
    public class Workshop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}