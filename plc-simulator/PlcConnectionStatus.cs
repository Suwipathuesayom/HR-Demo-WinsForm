using System;

namespace plc_simulator
{
    public class PlcConnectionStatus
    {
        private readonly object _sync = new object();

        public string DeviceCode { get; init; } = string.Empty;

        public bool IsConnected { get; private set; }

        public DateTime? ConnectedSince { get; private set; }

        public DateTime? LastSeen { get; private set; }

        public int FailedAttempts { get; private set; }

        public string? LastError { get; private set; }

        public event EventHandler<PlcConnectionStatusChangedEventArgs>? StatusChanged;

        public PlcConnectionStatus() { }

        public PlcConnectionStatus(string deviceCode)
        {
            DeviceCode = deviceCode ?? string.Empty;
        }

        public void SetConnected(DateTime at)
        {
            lock (_sync)
            {
                IsConnected = true;
                ConnectedSince ??= at;
                LastSeen = at;
                FailedAttempts = 0;
                LastError = null;
            }

            OnStatusChanged(new PlcConnectionStatusChangedEventArgs(this));
        }

        public void RecordHeartbeat(DateTime at)
        {
            lock (_sync)
            {
                LastSeen = at;
            }

            OnStatusChanged(new PlcConnectionStatusChangedEventArgs(this));
        }

        public void SetDisconnected(string? error = null)
        {
            lock (_sync)
            {
                IsConnected = false;
                ConnectedSince = null;
                LastError = error;
                FailedAttempts++;
            }

            OnStatusChanged(new PlcConnectionStatusChangedEventArgs(this));
        }

        protected virtual void OnStatusChanged(PlcConnectionStatusChangedEventArgs e)
        {
            try
            {
                StatusChanged?.Invoke(this, e);
            }
            catch
            {
            }
        }

        public override string ToString()
        {
            return $"Device={DeviceCode}, Connected={IsConnected}, LastSeen={LastSeen}, FailedAttempts={FailedAttempts}, Error={LastError}";
        }
    }

    public class PlcConnectionStatusChangedEventArgs : EventArgs
    {
        public PlcConnectionStatus Status { get; }

        public PlcConnectionStatusChangedEventArgs(PlcConnectionStatus status)
        {
            Status = status;
        }
    }
}
