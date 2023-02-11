using Project202322.Shared.Domain;
using System;

namespace Project202322.Shared.Domain
{
    public class Category
    {
        public DateTime DateCreated;
        public DateTime DateUpdated;
        public string CreatedBy;
        public string UpdatedBy;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Tags { get; set; }
        public string Type { get; set; }
    }
}