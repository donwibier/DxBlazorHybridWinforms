using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXBlazorWinForms
{
    public class AppBridge
    {
        public Blazor.Layout.MainLayout BlazorLayout { get; set; }

        public FrmMain MainForm { get; set; }
    }
}
