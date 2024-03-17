using Pattern_3.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Stratagy
{
    public interface IStrategy
    {
        string RunServer(string server, string user, string password);
        string ShutDownServer(string server, string user, string password);
        bool IsServerRunning(string server);
    }

    public abstract class Strategy : IStrategy
    {
        protected bool isServerRun {  get; set; } = false;
        public abstract string RunServer(string server, string user, string password);
        public abstract string ShutDownServer(string server, string user, string password);
        public abstract bool IsServerRunning(string server);
    }

    public class LinuxServerStraragy : Strategy
    {
        public override string RunServer(string server, string user, string password)
        {
            isServerRun = true;
            return $"Running server {server} on Linux";
        }
        public override string ShutDownServer(string server, string user, string password)
        {
            isServerRun = false;
            return $"Shutting down server {server} on Linux";
        }
        public override bool IsServerRunning(string server)
        {
            return isServerRun;
        }
    }

    public class WindowsServerStraragy : Strategy
    {
        public override string RunServer(string server, string user, string password)
        {
            isServerRun = true;
            return $"Running server {server} on Windows";
        }
        public override string ShutDownServer(string server, string user, string password)
        {
            isServerRun = false;
            return $"Shutting down server {server} on Windows";
        }
        public override bool IsServerRunning(string server)
        {
            return isServerRun;
        }
    }

    public class MacOSServerStraragy : Strategy
    {
        public override string RunServer(string server, string user, string password)
        {
            isServerRun = true;
            return $"Running server {server} on MacOS";
        }
        public override string ShutDownServer(string server, string user, string password)
        {
            isServerRun = false;
            return $"Shutting down server {server} on MacOS";
        }
        public override bool IsServerRunning(string server)
        {
            return isServerRun;
        }
    }


}
