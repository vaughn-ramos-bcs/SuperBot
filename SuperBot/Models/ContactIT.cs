using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperBot.Models
{
    public class ContactIT
    {
        [Url]
        public string Url { get; set; }
        [StringLength(100,ErrorMessage = "You have reached the maximum character.")]
        public string Title { get; set; }
        public string AssignedTo { get; set; }
        public string IssueStatus { get; set; }
        public List<string> Priority { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        //To be added later on
        //public string Attachments { get; set; }
    }
}

//Fields in Sharepoint
//Title*
//Assigned To: -const Manila.Helpdesk @bcstechnology.com.au
// Issue Status: -const Active
// Priority: (1)High(2) N(3) L
//Description*
//Category: (SC) (HC) (F Purch) (F Repla)
//Attachments