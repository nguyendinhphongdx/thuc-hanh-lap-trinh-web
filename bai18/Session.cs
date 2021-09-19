using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai18
{
    public class Session
    {
        Account account;
        DateTime time;

        public Session()
        {
        }

        public Session( Account account, DateTime time)
        {
            this.Account = account;
            this.Time = time;
        }

        public Account Account { get => account; set => account = value; }
        public DateTime Time { get => time; set => time = value; }
    }
}