﻿using System;
using System.Runtime.InteropServices;

namespace SharpFont.HarfBuzz
{
	public static partial class HB
	{
		public static string VersionString
		{
			get
			{
				return Marshal.PtrToStringAnsi(hb_version_string());
			}
		}

		public static Version Version
		{
			get
			{
				uint major, minor, micro;
				hb_version(out major, out minor, out micro);
				return new Version((int)major, (int)minor, (int)micro);
			}
		}

		public static bool VersionCheck(Version version)
		{
			return VersionCheck(version.Major, version.Minor, version.Build);
		}

		public static bool VersionCheck(int major, int minor, int micro)
		{
			return hb_version_check((uint)major, (uint)minor, (uint)micro);
		}

		public static void Shape(this Font font, Buffer buffer)
		{
			HB.hb_shape(font.Reference, buffer.Reference, IntPtr.Zero, 0);
		}
	}
}
