﻿using System.Windows.Media;
using System.Windows.Threading;
using MicaLauncher.Data;

namespace MicaLauncher.Plugin
{
    public interface IPlugin
    {
        public ImageSource Icon { get; }

        public IEnumerable<QueryResult> Query(Dispatcher uiDispatcher, string query);
    }
}