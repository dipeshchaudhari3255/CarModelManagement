using System.ComponentModel.DataAnnotations;

namespace CarModelManageMent.Model
{
    public class CarModel
    {
        [Key]
        public int Id { get; set;}
        [Required]
        public string Brand { get; set; } = default!;
        [Required]
        public string Class { get; set;} = default!;
        [Required]
        public string ModelName { get; set; } = default!;
        [Required, StringLength(10, ErrorMessage = "Model Code man length is 10")]
        public string ModelCode { get; set; } = default!;
        [Required]
        public string Description { get; set; } = default!;
        [Required]
        public string Features { get; set; } = default!;

        [Required]
        public int Price { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTime DateofManufacturing { get; set; }

        [Required]
        public bool Active { get; set; }
        [Required]
        public int SortOrder { get; set; }
        public List<string> ModelImages { get; set; } = default!;


    }
}