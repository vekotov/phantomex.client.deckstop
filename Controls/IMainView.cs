using System;
using System.ComponentModel;
using Avalonia.Controls;

namespace Phantomex.Client.Desktop.Controls
{
    public interface IMainView
    {
        event CancelEventHandler MainViewClosing;
        event EventHandler Inactivity;

        void Close();
        void StartInactivityControl(TimeSpan timeOut);
        void StopInactivityControl();
    }
}
