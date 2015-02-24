namespace DeserializeTest
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using Newtonsoft.Json.Serialization;

    public class TypeResolver :
        IContractResolver,
        IDictionary<Type, Type>
    {
        [ContractPublicPropertyName("BaseResolver")]
        private readonly IContractResolver _baseResolver = null;

        private readonly IDictionary<Type, Type> _typeMap = new Dictionary<Type, Type>();

        public TypeResolver()
            : this(false)
        {
        }

        public TypeResolver(bool shareCache)
        {
            this._baseResolver = new DefaultContractResolver(shareCache);
        }

        public TypeResolver(IContractResolver baseResolver)
        {
            Contract.Requires<ArgumentNullException>(baseResolver != null);

            this._baseResolver = baseResolver;
        }

        public IContractResolver BaseResolver
        {
            get
            {
                Contract.Ensures(Contract.Result<IContractResolver>() != null);

                return this._baseResolver;
            }
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

        public Type this[Type key]
        {
            get
            {
                return this._typeMap[key];
            }

            set
            {
                if (key == null)
                {
                    throw new ArgumentNullException("key");
                }

                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (!key.IsAssignableFrom(value))
                {
                    throw new ArgumentException();
                }

                this._typeMap[key] = value;
            }
        }

        public void Map<TRequire, TImplement>()
            where TImplement : TRequire
        {
            this._typeMap[typeof(TRequire)] = typeof(TImplement);
        }

        public JsonContract ResolveContract(Type type)
        {
            Type concreteType;
            if (this._typeMap.TryGetValue(type, out concreteType))
            {
                type = concreteType;
            }

            var contract = this._baseResolver.ResolveContract(type);

            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IOutputDictionary<,>))
            {
                contract.Converter = new OutputDictionaryCoverter<>
            }

            return contract;
        }

        public IEnumerator<KeyValuePair<Type, Type>> GetEnumerator()
        {
            return this._typeMap.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(KeyValuePair<Type, Type> item)
        {
            if (item.Key == null || item.Value == null)
            {
                throw new ArgumentNullException("item");
            }

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

        public bool ContainsKey(Type key)
        {
            return this._typeMap.ContainsKey(key);
        }

        public void Add(
            Type key,
            Type value)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }

            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (!key.IsAssignableFrom(value))
            {
                throw new ArgumentException();
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

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._baseResolver != null);

            Contract.Invariant(this._typeMap != null);
        }
    }
}
