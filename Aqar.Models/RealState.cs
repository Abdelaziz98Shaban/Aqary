using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aqar.Models
{
    public class RealState
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Is Required"), Display(Name = "Name"), StringLength(50), RegularExpression(pattern: "[a-zA-Z]{3,}",
                          ErrorMessage = "Name must be char only and more than 2 characters")]
        public string Name { get; set; }




        [Required(ErrorMessage = "Description Is Required"), Display(Name = "Description"), StringLength(300), RegularExpression(pattern: "[a-zA-Z]{3,}",
                          ErrorMessage = "Description must be char only and more than 5 characters")]
        public string Description { get; set; }





        [Display(Name = "Images"), Required(ErrorMessage = "Images Is Required"), RegularExpression(@"\w+\.(jpg|png)", ErrorMessage = "Image must contain jpg or png ")]
        public ICollection<RealStateImage> Images { get; set; }


        [Display(Name = "Video"), Required(ErrorMessage = "Video Is Required"), StringLength(50)]

        public string VideoLink { get; set; }

        



        // Ef mapp decimal to decimal , so we explicitly convert it to money , cuz money 8 bytes 
        //can handle the dollar sign and commas, whereas decimal cannot.
        //MONEY data type has rounding error if the fractional units bigger than 5 decimal places.
        //Also if you are going to use MONEY data in a calculation involving multiplication or division,
        //it is cautious to cast or round to the DECIMAL datatype.
        [Required(ErrorMessage = "Price Is Required"), Display(Name = "Price"), Column(TypeName = "money"), Range(100000, 3000000000000000000)]
        public decimal Price { get; set; }






        [Display(Name = "Area"), Range(40, 300000000)]
        public double Area { get; set; }




        [Required(ErrorMessage = "State Is Required"), Display(Name = "State"), StringLength(50), RegularExpression(pattern: "[a-zA-Z]{3,}",
                         ErrorMessage = "State must be char only and more than 2 characters")]
        public string State { get; set; }



        [Required(ErrorMessage = "City Is Required"), Display(Name = "City"), StringLength(50), RegularExpression(pattern: "[a-zA-Z]{3,}",
                       ErrorMessage = "City must be char only and more than 2 characters")]
        public string City { get; set; }


        [Required(ErrorMessage = "Street Is Required"), Display(Name = "Street"), StringLength(50), RegularExpression(pattern: "[a-zA-Z]{3,}",
                       ErrorMessage = "Street must be char only and more than 2 characters")]
        public string Street { get; set; }


        [Required(ErrorMessage = "BuildingNumber Is Required"), Display(Name = "BuildingNumber"), Range(1, 3000000000000000000)]
        public int BuildingNumber { get; set; }



        [Required(ErrorMessage = "AppartmentNumber Is Required"), Display(Name = "AppartmentNumber"), Range(1, 3000000000000000000)]
        public int AppartmentNumber { get; set; }

        [Required(ErrorMessage = "Rooms Is Required"), Display(Name = "Rooms"), Range(1, 100)]
        public int Rooms { get; set; }



        [Required(ErrorMessage = "Baths Is Required"), Display(Name = "Baths"), Range(1, 30)]
        public int Baths { get; set; }





        [Required(ErrorMessage = "Status Is Required"), Display(Name = "Status"), StringLength(50), RegularExpression(pattern: "[a-zA-Z]{3,}",
                          ErrorMessage = "Status must be char only and more than 2 characters")]
        // rent or sale
        public string Status { get; set; }

        [Display(Name = "SwimmingPool"), Required(ErrorMessage = "SwimmingPool Is Required")]
        public bool SwimmingPool { get; set; }

        [Display(Name = "LaundryRoom"), Required(ErrorMessage = "LaundryRoom Is Required")]

        public bool LaundryRoom { get; set; }

        [Display(Name = "EmergencyExit"), Required(ErrorMessage = "EmergencyExit Is Required")]

        public bool EmergencyExit { get; set; }

        [Display(Name = "FirePlace"), Required(ErrorMessage = "FirePlace Is Required")]

        public bool FirePlace { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }



        [ForeignKey("Category")]

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string FullAdress
        {
            get { return State + ", " + City + ", " + Street + ", " + BuildingNumber + ", " + AppartmentNumber; }
        }



    }
}
