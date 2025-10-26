using System;
using System.Collections.Generic;

namespace 泛用基督教會會員管理系統2版通用API.SQLiteModels.Exceptions;

public partial class EXCEPTIONDATA
{
    public int SERIAL { get; set; }

    public string EVENTTIME { get; set; } = null!;

    public string CALLERFUNCTION { get; set; } = null!;

    public string? PARAM { get; set; }

    public string EXMESSAGE { get; set; } = null!;

    public string EXSTACKTRACE { get; set; } = null!;
}
