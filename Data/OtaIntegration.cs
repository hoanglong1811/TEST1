using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class OtaIntegration
{
    public int IdTichHop { get; set; }

    public string? Otaname { get; set; }

    public string? Apikey { get; set; }

    public string? TrangThai { get; set; }

    public DateTime? ThoiGianDongBo { get; set; }
}
