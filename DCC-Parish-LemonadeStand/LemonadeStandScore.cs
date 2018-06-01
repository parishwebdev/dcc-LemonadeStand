namespace DCC_Parish_LemonadeStand
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LemonadeStandScore
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public int? GameLength { get; set; }

        public decimal? Score { get; set; }
    }
}
