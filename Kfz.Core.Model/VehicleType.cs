using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kfz.Core.Model
{
    [Table("vehicleType")]
    public class VehicleType : ModelBase
    {
        private string _vehicleTypeId;

        [Column("vehicleTypeId")]
        [StringLength(50)]
        public string vehicleTypeId { get => _vehicleTypeId; set { if (_vehicleTypeId != value) { _vehicleTypeId = value; NotifyPropertyChanged(); } } }
    }
}