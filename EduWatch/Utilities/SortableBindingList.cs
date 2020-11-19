using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EduWatch.Utilities
{
    // Custom class based on BindingList<T> that enables sorting in DataGridView by clicking on column header
    public class SortableBindingList<T> : BindingList<T>
    {
        // Dictionary with PropertyComparers for the properties of T
        private readonly Dictionary<Type, PropertyComparer<T>> comparers;
        private bool isSorted;
        private ListSortDirection listSortDirection;
        private PropertyDescriptor propertyDescriptor;

        public SortableBindingList() : base(new List<T>())
        {
            comparers = new Dictionary<Type, PropertyComparer<T>>();
        }

        public SortableBindingList(IEnumerable<T> enumeration) : base(new List<T>(enumeration))
        {
            comparers = new Dictionary<Type, PropertyComparer<T>>();
        }

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => isSorted;
        protected override PropertyDescriptor SortPropertyCore => propertyDescriptor;
        protected override ListSortDirection SortDirectionCore => listSortDirection;
        protected override bool SupportsSearchingCore => true;

        // Sort the items using the given direction and Property Descriptor
        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            List<T> itemsList = (List<T>)Items;

            Type propertyType = property.PropertyType;
            PropertyComparer<T> comparer;
            // Check if the comparer for the given property already exists in the dictionary, if not create it and add it
            if (!comparers.TryGetValue(propertyType, out comparer))
            {
                comparer = new PropertyComparer<T>(property, direction);
                comparers.Add(propertyType, comparer);
            }
            comparer.SetPropertyAndDirection(property, direction);
            // Sort the items using the current property comparer
            itemsList.Sort(comparer);

            propertyDescriptor = property;
            listSortDirection = direction;
            isSorted = true;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        // Remove any sort applied with ApplySortCore
        protected override void RemoveSortCore()
        {
            isSorted = false;
            propertyDescriptor = base.SortPropertyCore;
            listSortDirection = base.SortDirectionCore;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        // Search for the index of the item that has the specified property descriptor with the specified value
        protected override int FindCore(PropertyDescriptor property, object key)
        {
            int count = Count;
            for (int i = 0; i < count; ++i)
            {
                T element = this[i];
                if (property.GetValue(element).Equals(key)) return i;
            }

            return -1;
        }
    }
}