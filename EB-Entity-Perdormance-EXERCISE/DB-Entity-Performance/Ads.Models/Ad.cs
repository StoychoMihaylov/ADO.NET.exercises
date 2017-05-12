namespace Ads.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class Ad
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        public string ImageDataURL { get; set; }

        [Required]
        [StringLength(128)]
        public string OwnerId { get; set; }

        public int? CategoryId { get; set; }

        public int? TownId { get; set; }

        public DateTime Date { get; set; }

        public int StatusId { get; set; }

        public virtual AdStatus AdStatus { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Category Category { get; set; }

        public virtual Town Town { get; set; }
    }
}
