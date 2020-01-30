namespace Mine.Models
{
    /// <summary>
    /// Item for the Game
    /// </summary>
    public class ItemModel : BaseModel
    {
        // Add Unique attributes for Item
        
        // The Value of the item
        public int Value { get; set; } = 0;

        public bool Update(ItemModel data)
        {
            // Do not update the ID, if you do, the record will be orphaned
            // Id = data.Id;

            // Update the Base
            Name = data.Name;
            Description = data.Description;

            // Update the extended
            Value = data.Value;

            return true;
        }
    }
}