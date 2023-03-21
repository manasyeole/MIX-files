using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trcakingapi.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description  { get; set; }

        public Priority Prirority { get; set; }


    }
    public enum Priority
    {
        Low,Medium,High
    }

    public enum IssueType
    {
        Feature, Bug, Documentation
    }
}
