using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : ICommand
{
    // Start is called before the first frame update
    private Transform t;
    private Vector3 moveTo;
    private Vector3 pastPos;

    public MoveDown(Transform transform, float moveDis)
    {
        this.t = transform;
        this.moveTo.y = moveDis;
    }

    public void Execute()
    {
        pastPos = t.position;
        moveTo.z = t.position.z;
        t.position += new Vector3(0, moveTo.y, 0);
    }

    public void Undo()
    {
        t.position = pastPos;
    }
}
