using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : ICommand
{
    // Start is called before the first frame update
    private Transform t;
    private Vector3 moveTo;
    private Vector3 pastPos;

    public MoveLeft(Transform transform, float moveDis)
    {
        this.t = transform;
        this.moveTo.x = moveDis;
    }

    public void Execute()
    {
        pastPos = t.position;
        moveTo.z = t.position.z;
        t.position += new Vector3(moveTo.x, 0, 0);
    }

    public void Undo()
    {
        t.position = pastPos;
    }
}
