// Decompiled with JetBrains decompiler
// Type: TearORDear.Program
// Assembly: TearORDear, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FAD666A4-4959-43F0-9D38-7FD79F826579
// Assembly location: C:\Users\afuka\Downloads\TearORDear.exe

using System;
using System.Windows.Forms;

namespace TearORDear
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new LoginForm());
    }
  }
}
