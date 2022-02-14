using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    void Execute();
    void Undo();
}

public class CommandManager : MonoBehaviour
{

    public static CommandManager Instance { get; private set; }
    private Stack<ICommand> commands = new Stack<ICommand> ();

    private void Awake()
    {
        if(Instance == null)
        Instance = this;
    }

    public void AddCommand(ICommand com)
    {
        com.Execute();
        commands.Push(com);
    }

    public void UndoCommand()
    {
        if(commands.Count > 0)
        {
            var cmd = commands.Pop();
            cmd.Undo(); 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
