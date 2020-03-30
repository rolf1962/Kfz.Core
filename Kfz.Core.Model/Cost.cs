namespace Kfz.Core.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("cost")]
    public class Cost : ModelBase
    {
        private DateTime _date;
        private long? _kmOld;
        private long? _kmNew;
        private double _amount;
        private double? _quantity;
        private string _remarks;
        private Vehicle _vehicle;
        private CostType _costtype;
        private int _costId;

        [Column("costId")]
        public int CostId { get => _costId; set { if (_costId != value) { _costId = value; NotifyPropertyChanged(); } } }

        [Column("date")]
        public DateTime Date { get => _date; set { if (_date != value) { _date = value; NotifyPropertyChanged(); } } }

        [Column("kmOld")]
        public long? KmOld { get => _kmOld; set { if (_kmOld != value) { _kmOld = value; NotifyPropertyChanged(); } } }

        [Column("kmNew")]
        public long? KmNew { get => _kmNew; set { if (_kmNew != value) { _kmNew = value; NotifyPropertyChanged(); } } }

        [Column("amount")]
        public double Amount { get => _amount; set { if (_amount != value) { _amount = value; NotifyPropertyChanged(); } } }

        [Column("quantity")]
        public double? Quantity { get => _quantity; set { if (_quantity != value) { _quantity = value; NotifyPropertyChanged(); } } }

        [Column("remarks")]
        [StringLength(4000)]
        public string Remarks { get => _remarks; set { if (_remarks != value) { _remarks = value; NotifyPropertyChanged(); } } }

        public virtual Vehicle Vehicle { get => _vehicle; set { if (_vehicle != value) { _vehicle = value; NotifyPropertyChanged(); } } }

        public virtual CostType CostType { get => _costtype; set { if (_costtype != value) { _costtype = value; NotifyPropertyChanged(); } } }
    }
}
