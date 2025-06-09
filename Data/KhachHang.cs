using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class KhachHang
{
    public int IdKhachHang { get; set; }

    public string? HoTen { get; set; }

    public int? DienThoai { get; set; }

    public string? Cccd { get; set; }

    public virtual ICollection<ChiTietDatPhong> ChiTietDatPhongs { get; set; } = new List<ChiTietDatPhong>();

    public virtual ICollection<DatPhong> DatPhongs { get; set; } = new List<DatPhong>();
}
