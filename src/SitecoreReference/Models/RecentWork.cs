using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SitecoreReference.Models
{
    public class RecentWork
    {
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        public string WorkTypes { get; set; }

        public virtual string ImageUrlSmall { get; set; }

        public virtual string ImageUrlLarge { get; set; }

        public virtual string Description { get; set; }
    }
}