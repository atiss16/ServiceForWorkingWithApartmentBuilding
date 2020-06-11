﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Announcements
{
    public sealed class Announcement
    {
        public Guid AnnouncementId { get; private set; }

        public string Title { get; private set; }

        public string Content { get; private set; }

        public ICollection<AnnouncementTenant> AnnouncementTenant { get; private set; }
    }
}
