﻿using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class Advisor : IEntity
    {
        public int AdvisorId { get; set; }
        public int StudentId { get; set; }
        public int InstructorId { get; set; }
        public bool DeleteFlag { get; set; }
    }
}