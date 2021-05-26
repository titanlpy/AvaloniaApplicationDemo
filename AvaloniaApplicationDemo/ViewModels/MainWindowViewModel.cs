using AvaloniaApplicationDemo.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;

namespace AvaloniaApplicationDemo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string _splitViewIsOpen = "False";
        public string SplitViewIsOpen { get => _splitViewIsOpen; set => this.RaiseAndSetIfChanged(ref _splitViewIsOpen, value); }

        public string _splitViewIsVisible = "True";
        public string SplitViewIsVisible { get => _splitViewIsVisible; set => this.RaiseAndSetIfChanged(ref _splitViewIsOpen, value); }

        public object _splitViewPanel;
        public object SplitViewPanel { get => _splitViewPanel; set => this.RaiseAndSetIfChanged(ref _splitViewPanel, value); }

        public ReactiveCommand<string, Unit> OnClickCommand { get; }
        public MainWindowViewModel()
        {
            OnClickCommand = ReactiveCommand.Create<string>(DoClickCommand);
        }
        public void DoClickCommand(string parameter)
        {
            switch (parameter)
            {
                case "WorkInfo":
                    {
                        WorkInfo();
                    }
                    break;
                case "CanInocBacts":
                    {
                        CanInocBacts();
                    }
                    break;
                case "InocRecords":
                    {
                        InocRecords();
                    }
                    break;
                case "InventoryInfo":
                    {
                        InventoryInfo();
                    }
                    break;
                default:
                    break;

            }
        }

        private void WorkInfo()
        {
            SplitViewIsOpen = "False";
            SplitViewPanel = new WorkInfoControlPage();
            SplitViewIsOpen = "True";
        }

        private void CanInocBacts()
        {
            SplitViewIsOpen = "False";
            SplitViewPanel = new WorkInfoControlPage();
            SplitViewIsOpen = "True";
        }

        private void InocRecords()
        {
            SplitViewIsOpen = "False";
            SplitViewPanel = new WorkInfoControlPage();
            SplitViewIsOpen = "True";
        }

        private void InventoryInfo()
        {
            SplitViewIsOpen = "False";
            SplitViewPanel = new WorkInfoControlPage();
            SplitViewIsOpen = "True";
        }

    }
}
