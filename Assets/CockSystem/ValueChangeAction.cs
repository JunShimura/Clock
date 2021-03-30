using System.Collections;
using System.Collections.Generic;
using System;

namespace ClockSystem
{
    public class ValueChangeAction<T> where T : IComparable<T>
    {
        private T _val;
        public T val
        {
            get {
                return _val;
            }
            set {
                if (!_val.Equals(value)) {
                    if (OnChange != null) {
                        OnChange(value);
                    }
                    _val = value;

                }
            }
        }
        public event Action<T> OnChange;
    }
}
