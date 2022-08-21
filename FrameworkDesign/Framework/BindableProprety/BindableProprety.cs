using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace FrameworkDesign
{
    public class BindableProprety <T> where T : IEquatable<T>
    {
        private T mValue=default;
        public T Value
        {
            get
            {
                return mValue;
            }
            set
            {
                if (!value.Equals(mValue))
                {
                    mValue = value;
                    OnValueChanged?.Invoke(value);
                }
            }
        }
        public Action<T> OnValueChanged;
    }
}
