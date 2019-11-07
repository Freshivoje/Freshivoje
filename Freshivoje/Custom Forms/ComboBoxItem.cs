namespace Freshivoje.Custom_Forms
{
    public class ComboBoxItem
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public override string ToString() { return Text; }
    }
}
