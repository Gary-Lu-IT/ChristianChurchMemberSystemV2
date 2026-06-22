using System;
using System.Collections.Generic;

namespace 泛用基督教會會員管理系統2版通用API.SQLiteModels.Church;

public partial class LOGINFAILRECORD
{
    public string? FAILID { get; set; }

    public string LOGINID { get; set; } = null!;

    public string FAILTIME { get; set; } = null!;
}
