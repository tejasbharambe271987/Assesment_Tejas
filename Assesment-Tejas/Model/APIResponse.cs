using System;
using System.Collections.Generic;

namespace AssesmentTejas.Model
{
    public class APIResponse
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<Person> results { get; set; }
    }

}
