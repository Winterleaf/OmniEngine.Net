using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WinterLeaf.Engine.Classes.Helpers
    {
    /// <summary>
    /// Internal Use.
    /// </summary>
    internal class LibraryManager
        {
        internal interface DllLoadUtils
            {
            IntPtr LoadLibrary(string fileName);
            void FreeLibrary(IntPtr handle);
            IntPtr GetProcAddress(IntPtr dllHandle, string name);
            }

        internal  class DllLoadUtilsWindows : DllLoadUtils
            {
            void DllLoadUtils.FreeLibrary(IntPtr handle)
                {
                FreeLibrary(handle);
                }

            IntPtr DllLoadUtils.GetProcAddress(IntPtr dllHandle, string name)
                {
                return GetProcAddress(dllHandle, name);
                }

            IntPtr DllLoadUtils.LoadLibrary(string fileName)
                {
                return LoadLibrary(fileName);
                }

            [DllImport("kernel32")]
            private static extern IntPtr LoadLibrary(string fileName);

            [DllImport("kernel32.dll")]
            private static extern int FreeLibrary(IntPtr handle);

            [DllImport("kernel32.dll")]
            private static extern IntPtr GetProcAddress(IntPtr handle, string procedureName);
            }

        internal class DllLoadUtilsLinux : DllLoadUtils
            {
            public IntPtr LoadLibrary(string fileName)
                {
                return dlopen(fileName, RTLD_NOW);
                }

            public void FreeLibrary(IntPtr handle)
                {
                dlclose(handle);
                }

            public IntPtr GetProcAddress(IntPtr dllHandle, string name)
                {
                // clear previous errors if any
                dlerror();
                var res = dlsym(dllHandle, name);
                var errPtr = dlerror();
                if (errPtr != IntPtr.Zero)
                    {
                    throw new Exception("dlsym: " + Marshal.PtrToStringAnsi(errPtr));
                    }
                return res;
                }

            const int RTLD_NOW = 2;

            [DllImport("libdl.so")]
            private static extern IntPtr dlopen(String fileName, int flags);

            [DllImport("libdl.so")]
            private static extern IntPtr dlsym(IntPtr handle, String symbol);

            [DllImport("libdl.so")]
            private static extern int dlclose(IntPtr handle);

            [DllImport("libdl.so")]
            private static extern IntPtr dlerror();
            }

        static internal bool IsLinux()
            {
            var p = (int)Environment.OSVersion.Platform;
            return (p == 4) || (p == 6) || (p == 128);
            }

       
        }
    }
