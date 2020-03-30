namespace Kfz.Core.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("vehicle")]
    public class Vehicle : ModelBase
    {
        private VehicleType _vehicletype;
        private string _manufacturer;
        private string _licenceNumber;
        private string _model;
        private DateTime? _purchaseDate;
        private int _vehicleId;

        [Column("vehicleId")]
        public int vehicleId { get => _vehicleId; set { if (_vehicleId != value) { _vehicleId = value; NotifyPropertyChanged(); } } }

        [Column("manufacturer")]
        [StringLength(50)]
        public string Manufacturer { get => _manufacturer; set { if (_manufacturer != value) { _manufacturer = value; NotifyPropertyChanged(); } } }

        [Column("licenceNumber")]
        [StringLength(50)]
        public string LicenceNumber { get => _licenceNumber; set { if (_licenceNumber != value) { _licenceNumber = value; NotifyPropertyChanged(); } } }

        [Column("model")]
        [StringLength(50)]
        public string Model { get => _model; set { if (_model != value) { _model = value; NotifyPropertyChanged(); } } }

        [Column("purchaseDate")]
        public DateTime? PurchaseDate { get => _purchaseDate; set { if (_purchaseDate != value) { _purchaseDate = value; NotifyPropertyChanged(); } } }

        public virtual VehicleType VehicleType { get => _vehicletype; set { if (_vehicletype != value) { _vehicletype = value; NotifyPropertyChanged(); } } }
    }
}
