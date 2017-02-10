﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class UserNotificationDto
    {
        public string Sender { get; set; }
        public string CustomerName { get; set; }
        public string Body { get; set; }
        public bool IsRead { get; set; }
        public int CustomerId { get; set; }
        public string CustomerLink {
            get {
                return "<a href='/Customer/Detail/" + CustomerId + "' >" + CustomerName + "</a>";
            }
        }
    }
}