using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
//using Equin.ApplicationFramework;

namespace MongoDB_Base
{
    [Serializable]
    public class SBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor _sortProperty;

        /// <summary>
        /// Возвращает значение, указывающее, поддерживает ли список сортировку
        /// </summary>
        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        /// <summary>
        ///Возвращает значение, указывающее, отсортирован ли список
        /// </summary>
        protected override bool IsSortedCore
        {
            get { return _isSorted; }
        }

        /// <summary>
        /// Получает направление сортировки списка
        /// </summary>
        protected override ListSortDirection SortDirectionCore
        {
            get { return _sortDirection; }
        }

        /// <summary>
        /// если сортировка не реализована в производном классе, возвращает значение null
        /// </summary>
        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _sortProperty; }
        }

        /// <summary>
        /// Удаляет любую сортировку, если сортировка реализована
        /// </summary>
        protected override void RemoveSortCore()
        {
            _sortDirection = ListSortDirection.Ascending;
            _sortProperty = null;
        }

        /// <summary>
        /// Сортирует элементы при переопределении в производном классе
        /// </summary>
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            _sortProperty = prop;
            _sortDirection = direction;

            if (_sortProperty == null) return;
            List<T> list = Items as List<T>;
            if (list == null) return;

            list.Sort(delegate(T lhs, T rhs)
            {

                object lhsValue = lhs == null ? null : _sortProperty.GetValue(lhs);
                object rhsValue = rhs == null ? null : _sortProperty.GetValue(rhs);
                int result = 0;
                if (lhsValue == null && rhsValue == null)
                {
                    result = 0;
                }
                else if (lhsValue == null)
                {
                    result = -1;
                }
                else if (rhsValue == null)
                {
                    result = 1;
                }
                else
                {
                    if (lhsValue is IComparable)
                    {
                        result = ((IComparable)lhsValue).CompareTo(rhsValue);
                    }
                    else if (!lhsValue.Equals(rhsValue))
                    {
                        result = lhsValue.ToString().CompareTo(rhsValue.ToString());
                    }
                }
                if (_sortDirection == ListSortDirection.Descending)
                    result = -result;
                return result;
            });

            _isSorted = true;
            //запуск события, список которого был изменен
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        public static implicit operator List<T>(SBindingList<T> sortableBindingList)
        {
            return sortableBindingList.Items.ToList();
        }
    }
}