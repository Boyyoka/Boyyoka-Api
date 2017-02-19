namespace Boyyoka.Api
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wallpaper
    {
        public int WallpaperID { get; set; }

        public int? UserID { get; set; }

        [Required]
        [StringLength(10)]
        public string Resolution { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        public int Views { get; set; }

        [StringLength(10)]
        public string Purity { get; set; }

        [Required]
        [StringLength(5)]
        public string Type { get; set; }

        [Required]
        [StringLength(255)]
        public string Path { get; set; }

        [StringLength(255)]
        public string Source { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        [Required]
        [StringLength(255)]
        public string Thumbnail { get; set; }

        public User User { get; set; }
    }
}
