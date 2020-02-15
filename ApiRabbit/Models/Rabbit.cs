using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRabbit.Models
{
    public class Rabbit
    {
        public enum FurColors
        {
            White=1,
            Brown=2,
            Black=3,
            Grey=4
        }
        public enum EyeColors
        {
            Blue=1,
            Black=2,
            Red=3
        }
        public enum Gender
        {
            Male=1,
            Female=2
        }
        [Required]
        [MaxLength(10)]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        [MaxLength(3)]
        [MinLength(1)]
        public int Age { get; set; }
        [Required]
        [EnumDataType(typeof(FurColors))]
        public FurColors FurColor { get; set; }
        [Required]
        [EnumDataType(typeof(EyeColors))]
        public EyeColors EyeColor { get; set; }
        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Genders { get; set; }
    }
}
