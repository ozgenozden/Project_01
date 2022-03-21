using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime RequiredDate { get; set; }
        [Required]
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public float Freight { get; set; }
        public string ShipName { get; set; }

        public int ShipAddress { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }



        [JsonIgnore]
        [ForeignKey("ShipAddress")]
        public Address Address { get; set; }

        [JsonIgnore]
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [JsonIgnore]
        [ForeignKey("EmployeeId")]
        public Employes Employes { get; set; }


    }
}
