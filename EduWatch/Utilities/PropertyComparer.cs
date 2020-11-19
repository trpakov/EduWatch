using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace EduWatch.Utilities
{
    // Class that compares properties, used by SortableBindingList
    public class PropertyComparer<T> : IComparer<T>
    {
        private readonly IComparer comparer;
        private PropertyDescriptor propertyDescriptor;
        private int reverse;

        // Create PropertyComparer for given property and sort direction
        public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
        {
            propertyDescriptor = property;
            // Create a constructed Comparer type from the generic Comparer type using the given property
            Type comparerForPropertyType = typeof(Comparer<>).MakeGenericType(property.PropertyType);
            // Use reflection to get a default sort order comparer for the given property type 
            comparer = (IComparer)comparerForPropertyType.InvokeMember("Default", BindingFlags.Static | BindingFlags.GetProperty | BindingFlags.Public, null, null, null);
            SetListSortDirection(direction);
        }

        // IComparer<T> implementation that call the default comparer of the udnerlying property
        public int Compare(T x, T y)
        {
            return reverse * comparer.Compare(propertyDescriptor.GetValue(x), propertyDescriptor.GetValue(y));
        }

        private void SetPropertyDescriptor(PropertyDescriptor descriptor)
        {
            propertyDescriptor = descriptor;
        }

        private void SetListSortDirection(ListSortDirection direction)
        {
            reverse = direction == ListSortDirection.Ascending ? 1 : -1;
        }

        public void SetPropertyAndDirection(PropertyDescriptor descriptor, ListSortDirection direction)
        {
            SetPropertyDescriptor(descriptor);
            SetListSortDirection(direction);
        }
    }
}