using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCommand : ICommand
{
    // Start is called before the first frame update
    private SpriteRenderer r;
    private Color c;
    public ColorCommand(SpriteRenderer renderer, Color color)
    {
        this.r = renderer;
        this.c = color;
    }

    public void Execute()
    {
        r.color = c;
    }
    public void Undo()
    {

    }
}
