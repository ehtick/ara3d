using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Emu.Controls;
using Peacock;

namespace Emu.Behaviors;

public static class ConnectingBehaviorExtensions
{
    public static double Sqr(double x)
        => x * x;

    public static double DistanceSqr(this Point a, Point b)
        => Sqr(a.X - b.X) + Sqr(a.Y - b.Y);

    public static double Distance(this Point a, Point b)
        => Math.Sqrt(DistanceSqr(a, b));

    public static bool CloseEnough(this SocketControl s, Point p)
        => Distance(s.AbsoluteCenter(), p) <= s.View.Style.ClickRadius;

    public static bool CanConnect(this SocketControl socket, ConnectingState state)
        => state.Source != null 
           && CloseEnough(socket, state.Current) 
           && Semantics.CanConnect(state.Source.View.Socket, socket.View.Socket);

    public static IEnumerable<SocketControl> GetSockets(this IControl control)
        => control.Descendants().OfType<SocketControl>();

    public static SocketControl? GetSocket(this IControl control, Func<SocketControl, bool> predicate)
        => control.GetSockets().FirstOrDefault(predicate);

    public static SocketControl? ConnectableSocket(this IControl control, ConnectingState state)
        => control.GetSocket(s => s.CanConnect(state));

    public static SocketControl? HitSocket(this IControl control, Point p)
        => control.GetSocket(s => s.CloseEnough(p));
}