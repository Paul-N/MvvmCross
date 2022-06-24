// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using JavaObject = Java.Lang.Object;

namespace MvvmCross.Platforms.Android
{
    public class MvxJavaContainer : JavaObject
    {
        protected MvxJavaContainer(object theObject)
        {
            Object = theObject;
        }

        public object Object { get; private set; }
    }

    public class MvxJavaContainer<T> : MvxJavaContainer
    {
        public MvxJavaContainer(T theObject)
            : base(theObject)
        {
        }

        public new T Object => (T)base.Object;
    }
}
