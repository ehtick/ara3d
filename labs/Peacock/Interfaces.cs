using System.Numerics;
using System.Windows;
using System.Windows.Media;
using Peacock;

namespace Ara3D.JuicyUI;

public interface INamed
{
    string Name { get; }
}

public interface IRenderContext
{
    ICanvas Canvas { get; }
    Rect CurrentRect { get; }
    IRenderContext UpdateRect(Rect rect);
    IRenderContext PushRect(Rect rect);
    IRenderContext PopRect();
    Transform Transform { get; }
    IRenderContext UpdateTransform(Transform transform);
    IRenderContext PushTransform(Transform transform);
    IRenderContext PopTransform();
}

public class Visual
{
    public Guid Id { get; }
    public Guid ModelId { get; }
    public Guid ViewId { get; }
}

public interface IVisual : INamed
{
    ILayout UpdateLayout(IInput input, ILayout layout);
    IView UpdateView(IInput input, IView view);
    
    IRenderContext Render(
        IRenderContext context, 
        ILayout layout, 
        IVisualGraph graph, 
        IView view, 
        IReadOnlyList<IBehavior> behaviors);
}

public interface IStyle 
{
    IStyle Lerp(IStyle other, float amount);
}

public interface IModel
{
    Guid Id { get; }
}

public interface IView
{
    Guid Id { get; }
}

public interface IBehavior : INamed
{
    IBehavior Start(double currentTime);
    IBehavior Update(double currentTime);
    IVisual Apply(IVisual visual);
    bool Completed(IVisual visual);
}

public interface ITrigger : INamed
{
    bool IsTrue(
        IVisual visual, 
        IModel model, 
        IVisualGraph graph, 
        IInput input);
}

public interface IBehaviorTrigger
{
    ITrigger StartTrigger { get; }
    ITrigger StopTrigger { get; }
    IBehavior Behavior { get; }
}

public interface IVisualGraph
{
    IVisual GetParent(IVisual visual);
    IReadOnlyList<IVisual> GetChildren(IVisual visual);
    IReadOnlyList<IVisual> Visuals { get; }
    IReadOnlyList<IVisual> HitTest(Vector2 p);
    IReadOnlyList<IVisual> HitTest(Rect r);
    IVisual Closest(Vector2 p);
    IVisual Closest(Rect r);
}

public interface ILayout
{
    Rect Rect { get; }
}

/// <summary>
/// This is provided by the user 
/// </summary>
public interface IModelViewUpdater
{
    IView UpdateView(IView view, IModel model);
    IModel UpdateModel(IModel model, IView view);
    IReadOnlyList<IModel> GetChildren(IModel model);
}

/// <summary>
/// This is a mutable data structure that coordinates everything.  
/// </summary>
public interface ICoordinator
{
    IModelViewUpdater ModelViewUpdater { get; }
    IModel Model { get; }
    IVisualGraph VisualGraph { get; }
    IReadOnlyList<IBehavior> GetActiveBehaviors(IVisual visual);
    void UpdateActiveBehaviors(IVisual visual, IReadOnlyList<IBehavior> behaviors);
    IReadOnlyList<IBehaviorTrigger> BehaviorTriggers { get; set; }
    void UpdateTriggers(IReadOnlyList<IBehaviorTrigger> triggers);
    void ProcessInput(IInput previous, IInput current); 
    IRenderContext Draw(IRenderContext context);
}

public interface IInput
{
    double CurrentTime { get; }
    Vector2 MousePosition { get; }
    IReadOnlyList<int> KeysDown { get; }
    IReadOnlyList<int> MouseButtonsDown { get; }
}