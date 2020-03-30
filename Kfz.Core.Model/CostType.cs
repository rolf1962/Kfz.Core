namespace Kfz.Core.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("costType")]
    public class CostType : ModelBase
    {
        private string _costTypeId;

        [Column("costTypeId")]
        [StringLength(50)]
        public string costTypeId { get => _costTypeId; set { if (_costTypeId != value) { _costTypeId = value; NotifyPropertyChanged(); } } }
    }
}
