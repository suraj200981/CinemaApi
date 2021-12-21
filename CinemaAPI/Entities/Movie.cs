﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name must be added")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Language of movie must be added")]
        public string Language { get; set; }

        [Required(ErrorMessage = "Movie rating must be added")]
        public double Rating { get; set; }
        /*
         * It is bad practice to store image in database, which is why
         * we are going to store the images in wwwroot folder and only store the paths in the
         * database. It is good practice to do it this way. 
         */
        [NotMapped] //this data anontation means that this property will not be apart of the movie table
        public IFormFile Image { get; set; } //IFromFile is not a data type which can be recognised by the database
        public string ImageUrl { get; set; } // will be recognised by DB because it is of type string


    }
}
