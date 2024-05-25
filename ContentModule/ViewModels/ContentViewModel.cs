using Prism.Events;
using Prism.Mvvm;
using PrismModular.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentModule.ViewModels
{
    public class ContentViewModel : BindableBase
    {
        private string header;

        public string Header
        {
            get { return header; }
            set { SetProperty(ref header, value);
            }
        }

        private IEventAggregator _eventAggregator;

        public ContentViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<ContentEvents>().Subscribe(GetContentHeader);
        }

        private void GetContentHeader(string obj)
        {
            Header = obj;
        }
    }
}
