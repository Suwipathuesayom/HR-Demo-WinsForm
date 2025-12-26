using hr_demo.domain.Models;
using hr_demo_data;
using System;
using System.Linq;

namespace plc_simulator.Services
{
    public class AttendanceService
    {
        private readonly ApplicationDbContext _db;

        public AttendanceService(ApplicationDbContext db)
        {
            _db = db;
        }

        public void RecordScan(FingerScanData scan)
        {
            if (scan == null) return;

            var user = _db.Users.FirstOrDefault(u => u.Username == scan.UserCode);
            if (user == null)
            {
                Console.WriteLine($"User not found for code: {scan.UserCode}");
                return;
            }

            var date = scan.ScanTime.Date;
            var attendance = _db.Attendances.FirstOrDefault(a => a.UserId == user.Id && a.Date == date);

            if (attendance == null)
            {
                attendance = new Attendance
                {
                    UserId = user.Id,
                    Date = date,
                    ClockIn = scan.ScanTime,
                    Status = "Present"
                };
                _db.Attendances.Add(attendance);
                _db.SaveChanges();

                Console.WriteLine($"Recorded ClockIn for User: {scan.UserCode} at {scan.ScanTime} from Device: {scan.DeviceCode}");
            }
            else
            {
                if (!attendance.ClockOut.HasValue || scan.ScanTime > attendance.ClockOut)
                {
                    attendance.ClockOut = scan.ScanTime;
                    if (attendance.ClockIn.HasValue && attendance.ClockOut.Value.TimeOfDay > attendance.ClockIn.Value.TimeOfDay)
                    {
                        attendance.Status = "Present";
                    }
                    _db.SaveChanges();
                    Console.WriteLine($"Recorded ClockOut for User: {scan.UserCode} at {scan.ScanTime} from Device: {scan.DeviceCode}");
                }
                else
                {
                    Console.WriteLine($"Ignored scan for User: {scan.UserCode} at {scan.ScanTime} (earlier than existing ClockOut)");
                }
            }
        }
    }
}
