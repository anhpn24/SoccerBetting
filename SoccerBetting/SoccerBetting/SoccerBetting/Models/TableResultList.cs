using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.Models
{
    public class TableResultList : List<TableResult>
    {
        public string TableName { get; set; }
        public List<TableResult> tblResults => this;
    }
}
