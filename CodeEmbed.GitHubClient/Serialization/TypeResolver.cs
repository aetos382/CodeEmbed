namespace CodeEmbed.GitHubClient.Serialization
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
                Contract.Ensures(Contract.Result<int>() == this._typeMap.Count);

                return this._typeMap.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                Contract.Ensures(Contract.Result<bool>() == false);

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
                Contract.EnsuresOnThrow<ArgumentNullException>(value == null);
                Contract.EnsuresOnThrow<ArgumentException>(!key.IsAssignableFrom(value));

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
            Contract.Ensures(this.Count >= Contract.OldValue(this.Count));

            this._typeMap[typeof(TRequire)] = typeof(TImplement);
        }

        public void Map(Type requiredType, Type implementType)
        {
            Contract.Requires<ArgumentNullException>(requiredType != null);
            Contract.Requires<ArgumentNullException>(implementType != null);
            Contract.Requires<ArgumentException>(requiredType.IsAssignableFrom(implementType));

            Contract.Ensures(this.Count >= Contract.OldValue(this.Count));

            this._typeMap[requiredType] = implementType;
        }

        public JsonContract ResolveContract(Type type)
        {
            Type concreteType;
            if (this._typeMap.TryGetValue(type, out concreteType))
            {
                type = concreteType;
            }

            return this._baseResolver.ResolveContract(type);
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
            Contract.EnsuresOnThrow<ArgumentNullException>(item.Key == null);
            Contract.EnsuresOnThrow<ArgumentNullException>(item.Value == null);
            Contract.EnsuresOnThrow<ArgumentException>(!item.Key.IsAssignableFrom(item.Value));

            Contract.Assume(this.Count >= Contract.OldValue(this.Count));

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
            Contract.Ensures(Contract.Result<bool>() == this._typeMap.ContainsKey(key));

            return this._typeMap.ContainsKey(key);
        }

        public void Add(
            Type key,
            Type value)
        {
            Contract.EnsuresOnThrow<ArgumentNullException>(key == null);
            Contract.EnsuresOnThrow<ArgumentNullException>(value == null);
            Contract.EnsuresOnThrow<ArgumentException>(!key.IsAssignableFrom(value));

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
            Contract.Ensures(Contract.Result<bool>() == false || Contract.ValueAtReturn(out value) != null);

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
            Contract.Invariant(this.Count == this._typeMap.Count);
        }
    }
}
