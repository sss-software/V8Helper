

using System;
using System.Runtime.InteropServices;

namespace V8Helper.NET
{
	internal static partial class NativeMethods
	{
#if !MAC
		[DllImport("V8Helper.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		public static extern SafeJavaScriptContextHandle JavaScriptContext_New();

		[DllImport("V8Helper.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public static extern string JavaScriptContext_ExecuteReturnString(SafeJavaScriptContextHandle ptr, [MarshalAs(UnmanagedType.LPWStr)] string source, [MarshalAs(UnmanagedType.LPWStr)] string name, [MarshalAs(UnmanagedType.BStr)] out string error);

		[DllImport("V8Helper.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		public static extern void JavaScriptContext_Delete(IntPtr ptr);

#else

		[DllImport("libV8Helper.dylib", CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern SafeJavaScriptContextHandle JavaScriptContext_New();

		[DllImport("libV8Helper.dylib", CharSet = CharSet.Ansi, ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.LPWStr)]
		public static extern string JavaScriptContext_ExecuteReturnString(SafeJavaScriptContextHandle ptr, [MarshalAs(UnmanagedType.LPWStr)] string source, [MarshalAs(UnmanagedType.LPWStr)] string name, [MarshalAs(UnmanagedType.LPWStr)] out string error);

		[DllImport("libV8Helper.dylib", CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void JavaScriptContext_Delete(IntPtr ptr);

#endif
	}
}
