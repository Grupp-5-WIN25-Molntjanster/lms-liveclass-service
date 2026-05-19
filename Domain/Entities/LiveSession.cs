using System;
using System.Collections.Generic;

namespace Lms.LiveClassService.Domain.Entities
{
    public class LiveSession
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string HostName { get; set; } = string.Empty;
        public string VideoUrl { get; set; } = string.Empty;
        public List<Viewer> Viewers { get; set; } = new();
    }
}