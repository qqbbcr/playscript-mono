//
// System.Net.Configuration.AuthenticationModuleElementCollection.cs
//
// Authors:
//	Tim Coleman (tim@timcoleman.com)
//
// Copyright (C) Tim Coleman, 2004
// (c) 2004 Novell, Inc. (http://www.novell.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#if NET_2_0 && XML_DEP

using System.Configuration;

namespace System.Net.Configuration 
{
	public sealed class AuthenticationModuleElementCollection : ConfigurationElementCollection
	{
		#region Constructors

		[MonoTODO]
		public AuthenticationModuleElementCollection ()
		{
		}

		#endregion // Constructors

		#region Properties

		[MonoTODO]
		public AuthenticationModuleElement this [int index] {
			get { throw new NotImplementedException (); }
			set { throw new NotImplementedException (); }
		}

		[MonoTODO]
		public new AuthenticationModuleElement this [string name] {
			get { return (AuthenticationModuleElement) base [name]; }
			set { base [name] = value; }
		}

		#endregion // Properties

		#region Methods

		[MonoTODO]
		public void Add (AuthenticationModuleElement element)
		{
			BaseAdd (element);
		}

		[MonoTODO]
		public void Clear ()
		{
			BaseClear ();
		}

		[MonoTODO]
		protected override ConfigurationElement CreateNewElement ()
		{
			return new AuthenticationModuleElement ();
		}

		[MonoTODO]
		protected override object GetElementKey (ConfigurationElement element)
		{
			if (!(element is AuthenticationModuleElement))
				throw new ArgumentException ("element");
			throw new NotImplementedException ();
		}

		public int IndexOf (AuthenticationModuleElement element)
		{
			return BaseIndexOf (element);
		}

		public void Remove (AuthenticationModuleElement element)
		{
			BaseRemove (element);
		}

		public void Remove (string name)
		{
			BaseRemove (name);
		}

		public void RemoveAt (int index)
		{
			BaseRemoveAt (index);
		}

		#endregion // Methods
	}
}

#endif
