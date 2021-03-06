﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyTimesheet.Models
{
    public class TimesheetEntry
    {
        /*
           DeveloperId    | Client   | ProjectId | Date       
           -------------- | -------- | -------   | ---------- | 
           DEV1233434     | Client X | PR21      | 2019-01-22 |
           DEV0133534     | Client X | PR05      | 2019-01-22 | 
         */

        
        public int Id { get; set; }
        
        public Developer Developer { get; set; }
        
        public Project Project { get; set; }
        public string Client { get; set; }
        public DateTime Date { get; set; }
        
    }
}
