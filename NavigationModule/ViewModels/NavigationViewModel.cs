using HandyControl.Tools.Command;
using Prism.Events;
using Prism.Mvvm;
using PrismModular.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationModule.ViewModels
{
    public class NavigationViewModel : BindableBase
    {
        private IEventAggregator _eventAggregator;

        public RelayCommand<string> SelectCmd => new(Select);

        public NavigationViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }
        private void Select(string header)
        {
            _eventAggregator.GetEvent<ContentEvents>().Publish(header);
        }

        
    }
}
