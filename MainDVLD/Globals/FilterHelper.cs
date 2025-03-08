using MainDVLD.People.DTOs;
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
            if (columnName == "" || valueOfColumn == null)
                return source;


            // Ensure the column name is not null or empty
            if (string.IsNullOrEmpty(columnName))
                //throw new ArgumentException("Column name cannot be null or empty.");
                return source;
               
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



        public static void SortDataGridView(DataGridView dataGridView, int columnIndex)
        {
            // Ensure there is data in the DataGridView before sorting
            if (dataGridView.DataSource is null)
                return;

            // Get the column name from the clicked header
            string columnName = dataGridView.Columns[columnIndex].DataPropertyName;

            // Retrieve current sort direction from the DataGridView's Tag property
            string currentSortDirection = dataGridView.Tag as string ?? "ASC";

            // Toggle sort direction
            string newSortDirection = currentSortDirection == "ASC" ? "DESC" : "ASC";
            dataGridView.Tag = newSortDirection;

            // Treat the DataSource as an IEnumerable for sorting
            var data = (dataGridView.DataSource as IEnumerable<object>).ToList();

            // Sort the list dynamically using LINQ
            var sortedData = newSortDirection == "ASC"
                ? data.OrderBy(item => GetPropertyValue(item, columnName)).ToList()
                : data.OrderByDescending(item => GetPropertyValue(item, columnName)).ToList();

            // Rebind the sorted data to the DataGridView
            dataGridView.DataSource = sortedData;
        }

        public static object GetPropertyValue(object obj, string propertyName)
        {
            var property = obj.GetType().GetProperty(propertyName);
            return property?.GetValue(obj, null);
        }


    }

}
