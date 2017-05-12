using RitEduClient.Models.Entities;
using System;

namespace RitEduClient.Models
{
    public class AggregatedPeopleList
    {
        //Pagination Helper; since people are spread out across sites, it makes pagination difficult.
        //Therefore, we use this alternate data stucture for that.
        public Tuple<Person, Site>[] People { get; set; }
    }
}
