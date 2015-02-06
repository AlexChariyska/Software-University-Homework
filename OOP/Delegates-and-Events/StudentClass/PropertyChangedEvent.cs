namespace StudentClass
{
    using System;
    public class PropertyChangedEvent<T> : EventArgs
    {
        public PropertyChangedEvent(string name, T oldValue, T newValue)
        {
            this.PropName = name;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropName { get; set; }

        public T OldValue { get; set; }

        public T NewValue { get; set; }
    }
}
