﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    public class Foo :
        IFoo
    {
        private readonly IFoo _foo;

        public Foo(IFoo foo)
        {
            this._foo = foo;
        }
    }
}
