﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;

namespace SpacerUnion.Common
{
    public partial class Imports
    {

        public static string PtrWToString(IntPtr ptr)
        {
            return Marshal.PtrToStringUni(ptr);
        }

        public static string PtrAToString(IntPtr ptr)
        {
            return Marshal.PtrToStringAnsi(ptr);
        }

        public static IntPtr StringToPtrA(string str)
        {
            return Marshal.StringToHGlobalAnsi(str);
        }


        public static IntPtr StringToPtrW(string str)
        {
            return Marshal.StringToHGlobalUni(str);
        }


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Stack_PushString(IntPtr v);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Stack_PushStringWide(IntPtr v);



        public static void Stack_PushString(string source)
        {
  
            IntPtr ptr = StringToPtrA(source);
            Stack_PushString(ptr);
            Marshal.FreeHGlobal(ptr);
        }

        public static void Stack_PushStringWide(string source)
        {
            IntPtr ptr = StringToPtrW(source);
            Stack_PushStringWide(ptr);
            Marshal.FreeHGlobal(ptr);
        }

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Stack_PushBool(bool v);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Stack_PushInt(int v);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Stack_PushLong(long v);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Stack_PushUInt(uint v);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Stack_PushULong(ulong v);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Stack_PushFloat(float v);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Stack_PushDouble(double v);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Stack_PeekString_S();


        public static string Stack_PeekString()
        {
            IntPtr ptr = Stack_PeekString_S();
            string v = PtrAToString(ptr);
            Stack_Pop();
            return v;
        }


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool Stack_PeekBool();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Stack_PeekInt();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern long Stack_PeekLong();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint Stack_PeekUInt();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong Stack_PeekULong();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern float Stack_PeekFloat();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern double Stack_PeekDouble();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Stack_Pop();
    }
}
