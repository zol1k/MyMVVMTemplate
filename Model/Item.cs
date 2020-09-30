namespace MyMvvmTemplate.Model
{
    public class Item
    {
        public string ItemName { get; set; }
        public int ItemValue { get; set; }
        public Item(int ItemValue, string ItemName)
        {
            this.ItemValue = ItemValue;
            this.ItemName = ItemName.ToString();
        }
        
    }
}
