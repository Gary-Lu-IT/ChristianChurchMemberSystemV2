using System;
using System.Collections.Generic;

namespace 泛用基督教會會員管理系統2版通用API.SQLiteModels.Church;

public partial class DIYPROPERTIES
{
    public string GROUPS { get; set; } = null!;

    public string PROPID { get; set; } = null!;

    public string PROPNAME { get; set; } = null!;

    public int ADMINPRIVILEGE { get; set; }
}
