﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SatışProject.Entities
{
    // Marka varlıklarını temsil eden sınıf, BaseEntity'den kalıtım alır.
    public class Brand 
    {
        public int BrandID { get; set; }
        // Marka adı, zorunlu, VarChar(100) tipinde.
        [Required]
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        // Markanın aktif olup olmadığını gösterir, varsayılan true.
        public bool IsActive { get; set; }

        // Logo dosya yolu (ör: "/uploads/brands/logo1.png")
        [Column(TypeName = "VarChar")]
        [StringLength(255)]
        public string? LogoPath { get; set; }

        // Bu markaya ait ürünlerin koleksiyonu.
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
