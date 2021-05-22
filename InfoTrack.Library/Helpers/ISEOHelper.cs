using System;
using System.Collections.Generic;
using System.Text;

namespace InfoTrack.Library.Helpers
{
    public interface ISEOHelper
    {
        List<int> GetRankings(string url, string keywords);
    }
}
