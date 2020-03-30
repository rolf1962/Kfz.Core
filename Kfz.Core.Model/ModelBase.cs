namespace Kfz.Core.Model
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.CompilerServices;

    public class ModelBase : INotifyPropertyChanged
    {
        private string _createdBy;
        private DateTime _created;
        private string _modifiedBy;
        private DateTime? _modified;

        [Column("createdBy")] 
        public string CreatedBy { get => _createdBy; set { if (_createdBy != value) { _createdBy = value; NotifyPropertyChanged(); } } }

        [Column("created")]
        public DateTime Created { get => _created; set { if (_created != value) { _created = value; NotifyPropertyChanged(); } } }

        [Column("modifiedBy")]
        public string ModifiedBy { get => _modifiedBy; set { if (_modifiedBy != value) { _modifiedBy = value; NotifyPropertyChanged(); } } }

        [Column("modified")]
        public DateTime? Modified { get => _modified; set { if (_modified != value) { _modified = value; NotifyPropertyChanged(); } } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
