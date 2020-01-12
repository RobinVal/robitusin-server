﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ConversationMember
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ConversationId { get; set; }
        public string Nickname { get; set; }
    }
}