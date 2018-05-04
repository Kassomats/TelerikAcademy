﻿using ITest.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITest.DTO
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<TestDTO> Tests { get; set; }
        public UserTestState CategoryState { get; set; }
    }
}
