using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities.Concrete
{
    public class Supplier:IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(128)]
        public string CompanyName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(128)]
        public string ContactName { get; set; }

        [MaxLength(128)]
        public string ContactTitle { get; set; }

        public int AddressId { get; set; }

        [JsonIgnore]
        [ForeignKey("AddressId")]
        public Address Address { get; set; }


    }
}
