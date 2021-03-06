namespace ReactUnity.Styling.Parsers
{
    public class StringConverter : IStyleParser, IStyleConverter
    {
        public object Convert(object value)
        {
            return FromString(value?.ToString());
        }

        public object FromString(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return value;
            if (value.StartsWith("\"") && value.EndsWith("\"")) return value.Substring(1, value.Length - 2);
            if (value.StartsWith("'") && value.EndsWith("'")) return value.Substring(1, value.Length - 2);
            if (value.StartsWith("`") && value.EndsWith("`")) return value.Substring(1, value.Length - 2);
            return value;
        }
    }
}
