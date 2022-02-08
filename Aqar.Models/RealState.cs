﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aqar.Models
{
    public class RealState
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Is Required"), Display(Name = "Name"), StringLength(50), RegularExpression(pattern: @"[a-zA-Z0-9\s]{3,}",
                          ErrorMessage = "Name must be char only and more than 2 characters")]
        public string Name { get; set; }




        [Required(ErrorMessage = "Description Is Required"), Display(Name = "Description"), StringLength(300), RegularExpression(pattern: @"[a-zA-Z0-9\s]{5,}",
                          ErrorMessage = "Description must be char only and more than 5 characters")]
        public string Description { get; set; }





        [Display(Name = "Images"), Required(ErrorMessage = "Images Is Required"), RegularExpression(@"\w+\.(jpg|jpge|png)", ErrorMessage = "Image must contain jpg or jpge or png ")]
        public List<RealStateImage> Images { get; set; }


        [Display(Name = "Video Link"), StringLength(200)]

        public string VideoLink { get; set; }

        // Ef mapp decimal to decimal , so we explicitly convert it to money , cuz money 8 bytes 
        //can handle the dollar sign and commas, whereas decimal cannot.
        //MONEY data type has rounding error if the fractional units bigger than 5 decimal places.
        //Also if you are going to use MONEY data in a calculation involving multiplication or division,
        //it is cautious to cast or round to the DECIMAL datatype.
        [Required(ErrorMessage = "Price Is Required"), Display(Name = "Price"), Column(TypeName = "money"), Range(100000, 3000000000000000000)]
        public decimal Price { get; set; }


        [Display(Name = "Area"), Required, Range(40, 300000000)]
        public double Area { get; set; }


        [Required, StringLength(50), RegularExpression(pattern: @"[a-zA-Z0-9\s]{3,}",
                         ErrorMessage = "State must be char only and more than 2 characters")]
        public string State { get; set; }



        [Required, StringLength(50), RegularExpression(pattern: @"[a-zA-Z0-9\s]{3,}",
                       ErrorMessage = "City must be char only and more than 2 characters")]
        public string City { get; set; }


        [StringLength(50), RegularExpression(pattern: @"[a-zA-Z0-9\s]{3,}",
                       ErrorMessage = "Street must be char only and more than 2 characters")]
        public string Street { get; set; }


        [Required, Display(Name = "Building Number"), Range(1, 1000)]
        public int BuildingNumber { get; set; }


        [Required, Display(Name = "Appartment Number"), Range(1, 100)]
        public int AppartmentNumber { get; set; }

        [Required, Range(1, 100)]
        public int Rooms { get; set; }



        [Required, Range(1, 30)]
        public int Baths { get; set; }


        [Required, StringLength(50), RegularExpression(pattern: @"[a-zA-Z0-9\s]{3,}",
                          ErrorMessage = "Status must be char only and more than 2 characters")]
        // rent or sale
        public string Status { get; set; }

        [Display(Name = "Swimming Pool"), Required(ErrorMessage = "Swimming Pool Is Required")]
        public bool SwimmingPool { get; set; }

        [Display(Name = "Laundry Room"), Required(ErrorMessage = "Laundry Room Is Required")]

        public bool LaundryRoom { get; set; }

        [Display(Name = "Emergency Exit"), Required(ErrorMessage = "Emergency Exit Is Required")]

        public bool EmergencyExit { get; set; }

        [Display(Name = "Fire Place"), Required(ErrorMessage = "Fire Place Is Required")]

        public bool FirePlace { get; set; }


        //[ForeignKey("User")]
        //public int UserId { get; set; }
        //public User User { get; set; }

        [ForeignKey("Category")]

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string FullAdress
        {
            get { return State + ", " + City + ", " + Street + ", " + BuildingNumber + ", " + AppartmentNumber; }
        }
    }
}
