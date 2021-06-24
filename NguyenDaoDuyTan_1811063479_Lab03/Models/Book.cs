namespace NguyenDaoDuyTan_1811063479_Lab03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [Required(ErrorMessage = "không được trống")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required(ErrorMessage = "không được trống")]
        [StringLength(100, ErrorMessage = "Tiêu đề không được vượt quá 100")]       
        public string Title { get; set; }

        [Required(ErrorMessage = "không được trống")]
        public string Description { get; set; }

        [Required(ErrorMessage = "không được trống")]
        [StringLength(30, ErrorMessage = "Author không được vượt quá 30")]
        public string Author { get; set; }

        [Required(ErrorMessage = "không được trống")]
        public string Images { get; set; }

        [Required(ErrorMessage = "không được trống")]
        [Range(1000, 1000000, ErrorMessage = "Giá sách từ 1000 -> 1000000")]
        public int Price { get; set; }
    }
}
