﻿using ITest.Data.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITest.Data.Models
{
    public class UserTests : DataModel
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public Guid TestId { get; set; }
        public Test Test { get; set; }

        //for the many to many table
        public ICollection<UserTestAnswers> Answers { get; set; }

        public decimal Score { get; set; }

        public string SerializedAnswers { get; set; }

        //public string Category { get; set; }

        public double ExecutionTime { get; set; }

        public bool Submitted { get; set; }

    }
}
