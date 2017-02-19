namespace Boyyoka.Api
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Wallpapers = new HashSet<Wallpaper>();
        }

        public int UserID { get; set; }

        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        [Required]
        [StringLength(60)]
        public string Password { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        public int? RoleID { get; set; }

        [StringLength(255)]
        public string Avatar { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime JoinDate { get; set; }

        public int? StateID { get; set; }

        public int? ProfileViews { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastLogin { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(255)]
        public string StickyWall { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wallpaper> Wallpapers { get; set; }
    }
}
