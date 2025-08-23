using System.Windows;
using Emu.Controls;

namespace Emu.Behaviors;

public record ConnectingState(bool IsDragging, SocketControl? Source, Point Current, bool StartingFromSource)
{
    public ConnectingState()
        : this(false, null, new(), true)
    { }

    public Point SourcePoint => Source?.AbsoluteCenter() ?? new();
    public Point StartPoint => StartingFromSource ? SourcePoint : Current;
    public Point EndPoint => StartingFromSource ? Current : SourcePoint;
}