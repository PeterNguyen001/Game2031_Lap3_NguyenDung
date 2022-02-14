using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    // Start is called before the first frame update
    private Transform t;
    private Vector3 moveTo;
    private Vector3 pastPos;

    public MoveCommand(Transform transform, Vector3 moveTo)
    {
        this.t = transform;
        this.moveTo = moveTo;
    }

    public void Execute()
    {
        pastPos = t.position;
        moveTo.z = t.position.z;
        t.position = moveTo;
    }

    public void Undo()
    {
        t.position = pastPos;
    }
}
