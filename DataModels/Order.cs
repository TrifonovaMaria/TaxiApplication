namespace DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public Guid ID_Customer { get; set; }

        [Required]
        [StringLength(100)]
        public string DepartureAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string DestinationAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string CarClass { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentMethod { get; set; }

        [StringLength(16)]
        public string CardNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        // 1 - ��� ��������
        // 2 - �������, ��������� ���������
        // 3 - ���������� ���������� (���� �������� ��������, �� ������ ���������� 1)
        // 4 - ������� (������� ��������)
        // 5 - �����������

        public Guid? ID_Driver { get; set; }

        public Guid ID { get; set; }

        public DateTime Date { get; set; }

        public int Price { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
