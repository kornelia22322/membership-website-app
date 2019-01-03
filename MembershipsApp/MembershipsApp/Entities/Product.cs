using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MembershipsApp.Entities
{
    [Table("Product")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }

        [MaxLength(2048)]
        [Required]
        public string Description { get; set; }

        [MaxLength(1024)]
        [Required]
        public string ImageUrl { get; set; }

        public int ProuctLinkTextId { get; set; }

        public int ProductLinkTypeId { get; set; }
    }
}