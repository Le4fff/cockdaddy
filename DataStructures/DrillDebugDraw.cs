﻿// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.DrillDebugDraw
// Assembly: Terraria, Version=1.4.0.5, Culture=neutral, PublicKeyToken=null
// MVID: 67F9E73E-0A81-4937-A22C-5515CD405A83
// Assembly location: C:\Users\mikeyisbaeyt\Downloads\depotdownloader-2.4.5\depots\105601\6707058\Terraria.exe

using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
  public struct DrillDebugDraw
  {
    public Vector2 point;
    public Color color;

    public DrillDebugDraw(Vector2 p, Color c)
    {
      this.point = p;
      this.color = c;
    }
  }
}