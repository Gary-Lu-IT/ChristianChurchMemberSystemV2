using System;
using System.Collections.Generic;

namespace 泛用基督教會會員管理系統2版通用API.SQLiteModels.Church;

public partial class MEMBERS_ROLES
{
    public string MEMBERID { get; set; } = null!;

    public string ROLE { get; set; } = null!;

    public string CREATOR { get; set; } = null!;

    public string CREATEDATE { get; set; } = null!;

    public string MODIFIER { get; set; } = null!;

    public string MODIFYDATE { get; set; } = null!;
}
