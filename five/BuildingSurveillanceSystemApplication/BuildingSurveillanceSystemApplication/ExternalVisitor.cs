﻿using System;
namespace BuildingSurveillanceSystemApplication
{
	public class ExternalVisitor
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public DateTime EntryDateTime { get; set; }
        public DateTime ExitDateTime { get; set; }
        public bool InBuilding { get; set; }
        public int EmployeeContactId { get; set; }
    }
}

