using System;
using Drawie.Numerics;

namespace PixiEditor.ChangeableDocument.Changeables.Graph.Interfaces;

internal interface ICelLayer
{
    public string CelDataKey { get; }
    public object? CreateEmptyCelData(VecI documentSize);
    public object? CloneCelDataAtFrame(int frame);

    public bool FallbackAnimationToLayerImage { get; set; }
}
