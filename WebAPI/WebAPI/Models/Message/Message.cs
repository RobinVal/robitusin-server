using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Message
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ConversationMemberId { get; set; }
        public int ConversationId { get; set; }
        public bool MessageStatus { get; set; }
    }
}