using System;

namespace Mine.Models
{
    /// <summary>
    /// Base model for records that get saved
    /// </summary>
    public class BaseModel
    {
        // ID
        public string Id { get; set; } = Guid.NewGuid().ToString();

        // Name 
        public string Name { get; set; } = "This is an Item";

        // Description
        public string Description { get; set; } = "Item Description";
    }
}