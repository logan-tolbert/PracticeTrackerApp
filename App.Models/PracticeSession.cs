﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class PracticeSession
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int DurationMinutes { get; set; }
        public string FocusArea { get; set; } = null!;
        public string? Notes { get; set; }
        public virtual User User { get; set; }
    }
}
