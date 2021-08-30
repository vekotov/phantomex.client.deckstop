using System;
using System.ComponentModel;

namespace Phantomex.Client.Desktop.Common
{
    public static class Env
    {
        public static bool IsInDesignerMode()
        {
            // return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
            return Convert.ToBoolean(Environment.GetEnvironmentVariable("IS_DESIGNER"));
        }
    }
}