namespace Technical_Task.Models
{
    public class Step1
    {
        public int Step1Id { get; set; }
        public int Step1Value { get; set; }
        public bool? IsChecked { get; set; } // Add this property
        public int Index { get; set; } // New property for the index

    }
}
