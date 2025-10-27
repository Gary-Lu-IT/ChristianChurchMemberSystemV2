using System;
using System.Collections.Generic;

namespace 泛用基督教會會員管理系統2版通用API.SQLiteModels.Church;

public partial class MEMBERS
{
    public string LOGINID { get; set; } = null!;

    public string USERNAME { get; set; } = null!;

    public double? GENDER { get; set; }

    public string? BIRTHDATE { get; set; }

    public string? PHONE { get; set; }

    public string? EMAIL { get; set; }

    public string? ADDRESS { get; set; }

    public int BAPTISED { get; set; }

    public string CREATOR { get; set; } = null!;

    public string CREATEDATE { get; set; } = null!;

    public string MODIFIER { get; set; } = null!;

    public string MODIFIEDDATE { get; set; } = null!;
}
