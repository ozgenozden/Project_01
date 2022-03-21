using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MaxLength(512)]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [MaxLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string QuantityPerUnit { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int Unitprice { get; set; }
   
        [Required(AllowEmptyStrings = false)]
        public int UnitsInStock { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        public int UnitsOnOrder { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int reorderLevel { get; set; }

        [Required(AllowEmptyStrings = false)]
        public bool Discontinued { get; set; }

        public int SupplierId { get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore]
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

        [JsonIgnore]
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }



    }
}
