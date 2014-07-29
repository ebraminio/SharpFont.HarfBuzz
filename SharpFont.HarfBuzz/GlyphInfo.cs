﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpFont.HarfBuzz
{
	[StructLayout(LayoutKind.Sequential)]
	public class GlyphInfo
	{
		public uint codepoint;
		public uint mask;
		public uint cluster;
	}
}
