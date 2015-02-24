namespace DeserializeTest
{
    using System;
    using System.Linq;

    public interface IRepositoryUser<out TFoo>
        where TFoo : IFoo
    {
        string Name { get; }

        TFoo Foo { get; }
    }
}
