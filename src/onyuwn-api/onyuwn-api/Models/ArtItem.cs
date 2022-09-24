using System;
using System.Collections.Generic;
using System.Text;

namespace onyuwn_api.Models
{
    public class ArtItem
    {
        public string Name { get; set; }
        public string NameLC { get; set; }
        public Guid Id { get; set; }
        public string ArtBlobUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
    }
}
