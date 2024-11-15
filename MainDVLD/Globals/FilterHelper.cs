using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDVLD.Globals
{
    public static class FilterHelper
    {
        public static List<T>  Filter<T>(List<T> source, string columnName, object valueOfColumn)
        {
            if (columnName == "" || valueOfColumn==null)
                return source;
            


            // Ensure the column name is not null or empty
            if (string.IsNullOrEmpty(columnName))
                throw new ArgumentException("Column name cannot be null or empty.");

            // Get the property info of the specified column name
            var property = typeof(T).GetProperty(columnName);
            if (property == null)
                throw new ArgumentException($"Property '{columnName}' does not exist on type '{typeof(T).Name}'.");

            // Filter the source list
            var filtered = source.Where(item =>
            {
                var propertyValue = property.GetValue(item);

                // Handle null values gracefully
                if (propertyValue == null || valueOfColumn == null)
                    return propertyValue == valueOfColumn;

                // Perform case-insensitive comparison for strings
                if (propertyValue is string propertyString && valueOfColumn is string valueString)
                    return propertyString.Equals(valueString, StringComparison.OrdinalIgnoreCase);

                // Perform exact comparison for other types
                return propertyValue.Equals(valueOfColumn);
            }).ToList();

            
            return filtered;
        }



    }

}
