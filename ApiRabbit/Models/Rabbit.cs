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
            White,
            Brown,
            Black,
            Grey
        }
        public enum EyeColors
        {
            Blue,
            Black,
            Red
        }
        public enum Gender
        {
            Male,
            Female
        }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        public FurColors FurColor { get; set; }
        [Required]
        public EyeColors EyeColor { get; set; }
        [Required]
        public Gender Genders { get; set; }
    }
}
