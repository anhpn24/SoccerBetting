using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SoccerBetting.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        public Guid GuidId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public BaseModel()
        {
            GuidId = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}