// Copyright 2007-2008 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Magnum.Common.Serialization
{
	using System;
	using System.IO;

	public class BinarySerializationWriter :
		ISerializationWriter
	{
		private readonly BinaryWriter _writer;

		public BinarySerializationWriter(BinaryWriter writer)
		{
			_writer = writer;
		}

		public void Write(long value)
		{
			_writer.Write(value);
		}

		public void Write(string value)
		{
			_writer.Write(value ?? string.Empty);
		}

		public void Write(float value)
		{
			_writer.Write(value);
		}

		public void Write(short value)
		{
			_writer.Write(value);
		}

		public void Write(ushort value)
		{
			_writer.Write(value);
		}

		public void Write(ulong value)
		{
			_writer.Write(value);
		}

		public void Write(uint value)
		{
			_writer.Write(value);
		}

		public void Write(double value)
		{
			_writer.Write(value);
		}

		public void Write(int value)
		{
			_writer.Write(value);
		}

		public void Write(bool value)
		{
			_writer.Write(value);
		}

		public void Write(DateTime value)
		{
			_writer.Write(value.ToBinary());
		}

		public void Write(decimal value)
		{
			_writer.Write(value);
		}
	}
}