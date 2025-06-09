using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class VaiTro
{
    public int IdVaiTro { get; set; }

    public string? TenVaiTro { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<PhanQuyen> PhanQuyens { get; set; } = new List<PhanQuyen>();

    public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
}
