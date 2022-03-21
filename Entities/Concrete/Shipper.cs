using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Shipper:IEntity
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    [MaxLength(128)]
    [Required(AllowEmptyStrings = false)]
    public string CompanyName { get; set; }

    [MaxLength(16)]
    [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Geçersiz Telefon Numarası Girdiniz.")]
    public string Phone{ get; set; }

}
}
