﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class Phong
{
    public int IdPhong { get; set; }

    public int IdLoaiPhong { get; set; }

    public int? SoPhong { get; set; }

    public int? SucChua { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<ChiTietDatPhong> ChiTietDatPhongs { get; set; } = new List<ChiTietDatPhong>();

    public virtual LoaiPhong IdLoaiPhongNavigation { get; set; } = null!;

    public virtual ICollection<ThietBi> ThietBis { get; set; } = new List<ThietBi>();
}
