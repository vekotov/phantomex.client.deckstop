using Avalonia;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using System;
using ReactiveUI;

namespace Phantomex.Client.Desktop.Dialogs.Views
{
    public class DialogServiceView : ReactiveWindow<ReactiveObject>
    {
        public DialogServiceView()
        {
            InitializeComponent();

            this.AttachDevTools();

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}