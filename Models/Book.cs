using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Models
{
    public class Book
	{
		[Required(ErrorMessage = "ID is required")]
		public int Id { get; set; }
		[Required(ErrorMessage = "Name is required")]
		[StringLength(255)]
		public string Name { get; set; }
		[Required(ErrorMessage = "Author's name is required")]
		public string AuthorName { get; set; }
		[Required(ErrorMessage = "Genre name is required")]
		public Genre Genre { get; set; }
		[Required(ErrorMessage = "GenreId is required.")]
		public byte GenreId { get; set; }
		[Required(ErrorMessage = "Date of addition is required.")]
		public DateTime DateAdded { get; set; }
		[Required(ErrorMessage = "Release date is required.")]
		public DateTime ReleaseDate { get; set; }
		[Required(ErrorMessage = "Number in stock is required.")]
		[Range(1, 20, ErrorMessage = "NumberInStock must be between 1 and 20.")]
		public int NumberInStock { get; set; }
		[Required(ErrorMessage = "Number of how many books are available is required.")]
		public int NumberAvailable { get; set; }
	}
      
}
