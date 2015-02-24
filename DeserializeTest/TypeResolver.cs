namespace DeserializeTest
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json.Serialization;

    public class TypeResolver :
        DefaultContractResolver,
        IDictionary<Type, Type>
    {
        private readonly IDictionary<Type, Type> _typeMap = new Dictionary<Type, Type>(); 

        public void Map<TRequire, TImplement>()
            where TImplement : TRequire
        {
            this._typeMap[typeof(TRequire)] = typeof(TImplement);
        }

        public override JsonContract ResolveContract(Type type)
        {
            Type concreteType;
            if (this._typeMap.TryGetValue(type, out concreteType))
            {
                type = concreteType;
            }

            return base.ResolveContract(type);
        }

        public IEnumerator<KeyValuePair<Type, Type>> GetEnumerator()
        {
            return _typeMap.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(KeyValuePair<Type, Type> item)
        {
            if (!item.Key.IsAssignableFrom(item.Value))
            {
                throw new ArgumentException();
            }

            this._typeMap.Add(item);
        }

        public void Clear()
        {
            this._typeMap.Clear();
        }

        public bool Contains(KeyValuePair<Type, Type> item)
        {
            return this._typeMap.Contains(item);
        }

        public void CopyTo(
            KeyValuePair<Type, Type>[] array,
            int arrayIndex)
        {
            this._typeMap.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<Type, Type> item)
        {
            return this._typeMap.Remove(item);
        }

        public int Count
        {
            get
            {
                return this._typeMap.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool ContainsKey(Type key)
        {
            return this._typeMap.ContainsKey(key);
        }

        public void Add(
            Type key,
            Type value)
        {
            if (!key.IsAssignableFrom(value))
            {
                throw new ArgumentNullException();
            }

            this._typeMap.Add(key, value);
        }

        public bool Remove(Type key)
        {
            return this._typeMap.Remove(key);
        }

        public bool TryGetValue(
            Type key,
            out Type value)
        {
            return this._typeMap.TryGetValue(key, out value);
        }

        public Type this[Type key]
        {
            get
            {
                return this._typeMap[key];
            }

            set
            {
                if (!key.IsAssignableFrom(value))
                {
                    throw new ArgumentException();
                }

                this._typeMap[key] = value;
            }
        }

        public ICollection<Type> Keys
        {
            get
            {
                return this._typeMap.Keys;
            }
        }

        public ICollection<Type> Values
        {
            get
            {
                return this._typeMap.Values;
            }
        }
    }
}
