using System;
using System.Collections.Generic;

namespace 泛用基督教會會員管理系統2版通用API.SQLiteModels.Church;

public partial class MEMBERPASSWORDS
{
    public string LOGINID { get; set; } = null!;

    public string LOGINPWD { get; set; } = null!;

    public string CREATEDATE { get; set; } = null!;

    public string LASTMODIFYDATE { get; set; } = null!;
}
