using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Address:IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(512)]
        public string Street { get; set; }

        [MaxLength(128)]
        public string City { get; set; }
        [MaxLength(128)]
        public string Region { get; set; }
        [MaxLength(128)]
        public string Country{ get; set; }

        [MaxLength(16)]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Geçersiz Telefon Numarası Girdiniz.")]
        public string PhoneNumber { get; set; }
        public int PostalCode { get; set; }

    }
}
