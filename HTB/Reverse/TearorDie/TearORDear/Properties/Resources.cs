// Decompiled with JetBrains decompiler
// Type: TearORDear.Properties.Resources
// Assembly: TearORDear, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FAD666A4-4959-43F0-9D38-7FD79F826579
// Assembly location: C:\Users\afuka\Downloads\TearORDear.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TearORDear.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (TearORDear.Properties.Resources.resourceMan == null)
          TearORDear.Properties.Resources.resourceMan = new ResourceManager("TearORDear.Properties.Resources", typeof (TearORDear.Properties.Resources).Assembly);
        return TearORDear.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return TearORDear.Properties.Resources.resourceCulture;
      }
      set
      {
        TearORDear.Properties.Resources.resourceCulture = value;
      }
    }
  }
}
