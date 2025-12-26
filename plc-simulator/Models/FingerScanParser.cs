using System;
using plc_simulator;

namespace plc_simulator.Models
{
    public class FingerScanParser
    {
        public FingerScanData Parse(string raw)
        {
            var data = new FingerScanData();
            if (string.IsNullOrWhiteSpace(raw)) return data;

            var parts = raw.Trim().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var p in parts)
            {
                if (p.StartsWith("USER=", StringComparison.OrdinalIgnoreCase))
                    data.UserCode = p.Length > 5 ? p[5..] : string.Empty;
                else if (p.StartsWith("TIME=", StringComparison.OrdinalIgnoreCase))
                {
                    var t = p.Length > 5 ? p[5..] : string.Empty;
                    if (DateTime.TryParse(t, out var dt)) data.ScanTime = dt;
                }
                else if (p.StartsWith("DEVICE=", StringComparison.OrdinalIgnoreCase))
                    data.DeviceCode = p.Length > 7 ? p[7..] : string.Empty;
            }

            return data;
        }
    }
}
