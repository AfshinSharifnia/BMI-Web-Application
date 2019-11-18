
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BodyMassIndexer.Models
{
    public class Customer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        public double Weight { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double BMI
        {   get 
            { return Math.Round(Weight / (Math.Pow((Height / 100),2)),2);}
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string CategoryBMI

        { 
           get 
            
           { if (BMI < 18.5)
                    return ("Underweight");

              else if (BMI >= 18.5 && BMI < 25)

                    return ("Normal Weight");

              else if (BMI >= 25 && BMI < 30)

                    return ("Overweight");

              else
                    return ("Obesity");
           }
        }
    }
}



