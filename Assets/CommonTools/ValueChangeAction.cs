using System.Collections;
using System.Collections.Generic;
using System;

namespace CommonTools
{
    public class ValueChangeAction<T> where T : IComparable<T>
    {
        private T _val = default;
        public T val
        {
            get {
                return _val;
            }
            set {
                if (!_val.Equals(value)) {
                    if (_OnChange != null) {
                        _OnChange(value);
                    }
                    _val = value;

                }
            }
        }
        private event Action<T> _OnChange;
        public event Action<T> OnChange
        {
            add {
                _OnChange += value;
                value(_val);
            }
            remove {
                _OnChange -= value;
            }
        }
    }
}

