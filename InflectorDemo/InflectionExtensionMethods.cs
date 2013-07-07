namespace InflectorDemo
{
    public static class InflectionExtensionMethods
    {
        public static string ToSingular(this string text)
        {
            return Inflector.Inflector.Singularize(text);
        }

        public static string ToPlural(this string text)
        {
            return Inflector.Inflector.Pluralize(text);
        }

        public static string ToCamelCase(this string text)
        {
            return Inflector.Inflector.Camelize(text);
        }
    }
}
