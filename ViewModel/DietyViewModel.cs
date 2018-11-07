using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.DTOs;

namespace ViewModel
{
    public class DietyViewModel : INotifyPropertyChanged
    {
        private DeityDto _deityDto;

        public event PropertyChangedEventHandler PropertyChanged;

        public int DietyID
        {
            get { return _deityDto.DeityID; }
        }

        public string DeityName
        {
            get { return _deityDto.DeityName; }
        }

        public string Description
        {
            get { return _deityDto.Description; }
        }

    }
}
