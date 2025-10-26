using System;
using System.Collections.Generic;

namespace 泛用基督教會會員管理系統2版通用API.SQLiteModels.Church;

public partial class SERIAL_TABLE
{
    public string TABLENAME { get; set; } = null!;

    public int USEDSERIAL { get; set; }
}
