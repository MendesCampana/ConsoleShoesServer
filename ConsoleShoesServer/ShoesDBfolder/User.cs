namespace ConsoleShoesServer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Login { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }
    }
}
