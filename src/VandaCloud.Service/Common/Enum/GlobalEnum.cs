using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace VandaCloud.Service.Common.Enum
{
    public enum DemoEnum
    {
        [Description("Demo 1")]
        Demo1 =1,
        [Description("Demo 2")]
        Demo2 = 2
    }
}
