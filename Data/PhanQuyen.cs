using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class PhanQuyen
{
    public int IdPhanQuyen { get; set; }

    public string? TenQuyen { get; set; }

    public int IdVaiTro { get; set; }

    public bool? QuyenHan { get; set; }

    public virtual VaiTro IdVaiTroNavigation { get; set; } = null!;
}
