namespace MyList
{
    internal class Box
    {
        public Box(object value)
        {
            Value = value;
            Next = null;
            
        }
        public object Value { get; set; }
        public Box Next { get; set; }






    }

}
