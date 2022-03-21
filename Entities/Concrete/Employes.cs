using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Employes : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MaxLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }

        [MaxLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string FistName { get; set; }

        [MaxLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }
        [MaxLength(32)]
        [Required(AllowEmptyStrings = false)]
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Notes { get; set; }    
        public string ReportsTo { get; set; }
        public int[] TerritoryIds { get; set; }



    }
}
