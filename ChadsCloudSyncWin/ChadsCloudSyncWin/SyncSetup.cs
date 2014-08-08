using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChadsCloudSyncWin
{
    public class SyncSetup
    {
        public int Id { get; set; }
        public string LocalPath { get; set; }
        public string CloudPath { get; set; }
        public string CloudKey { get; set; }
        public string CloudSecret { get; set; }
    }
}
