using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.Models.Common
{
    public class BaseResponse
    {
        public Header Header { get; set; } = new Header();
    }

    public class Header
    {
        public int Code { get; set; } = 200;
        public string Message { get; set; }
    }
}
