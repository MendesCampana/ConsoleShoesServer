namespace ConsoleShoesServer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sho
    {
        [Key]
        public int ModelId { get; set; }

        [Required]
        [StringLength(100)]
        public string ModelName { get; set; }

        public decimal IncomePrice { get; set; }

        public int Amount { get; set; }

        [StringLength(200)]
        public string ImagePath { get; set; }

        public int ModelSize { get; set; }

        public int Manufacturer { get; set; }

        public int GenderState { get; set; }

        public int AgeState { get; set; }

        public virtual AgeStatu AgeStatu { get; set; }

        public virtual Factory Factory { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual Size Size { get; set; }
    }
}
