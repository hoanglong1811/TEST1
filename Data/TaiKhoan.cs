﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class TaiKhoan
{
    public int IdTaiKhoan { get; set; }

    public string? TenDangNhap { get; set; }

    public string? MatKhau { get; set; }

    public string? Email { get; set; }

    public int IdVaiTro { get; set; }

    public virtual VaiTro IdVaiTroNavigation { get; set; } = null!;

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
