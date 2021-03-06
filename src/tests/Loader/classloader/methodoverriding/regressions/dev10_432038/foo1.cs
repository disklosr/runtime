// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

public class Foo1
{
    public virtual int A() { Console.WriteLine("\nin Foo1::A()"); return 1; }
}

public class Bar1<T>
{
    public virtual int A<U>() { Console.WriteLine("\nin Foo1::A() with T=" + typeof(T) + " and U=" + typeof(U)); return 1; }
}
