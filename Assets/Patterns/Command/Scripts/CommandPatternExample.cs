using System;
using System.Collections.Generic;
using Patterns.Command.PaintCommands;
using UnityEngine;
using UnityEngine.Serialization;

namespace Patterns.Command
{
    public class CommandPatternExample : MonoBehaviour
    {
        [FormerlySerializedAs("_moveObject")] [SerializeField] private ExampleObject exampleObject;

        private Stack<ICommand> _commandsToUndo = new Stack<ICommand>();
        private Dictionary<KeyCode, ICommand> _buttonsBindsMap = new Dictionary<KeyCode, ICommand>();

        private void Start()
        {
            _buttonsBindsMap.Add(KeyCode.W, new MoveUpCommand(exampleObject));
            _buttonsBindsMap.Add(KeyCode.A, new MoveLeftCommand(exampleObject));
            _buttonsBindsMap.Add(KeyCode.S, new MoveDownCommand(exampleObject));
            _buttonsBindsMap.Add(KeyCode.D, new MoveRightCommand(exampleObject));
            _buttonsBindsMap.Add(KeyCode.R, new PaintRedCommand(exampleObject));
            _buttonsBindsMap.Add(KeyCode.G, new PaintGreenCommand(exampleObject));
            _buttonsBindsMap.Add(KeyCode.B, new PaintBlueCommand(exampleObject));
        }

        private void Update()
        {
            foreach (KeyValuePair<KeyCode, ICommand> buttonBind in _buttonsBindsMap)
            {
                if (Input.GetKeyDown(buttonBind.Key))
                {
                    ExecuteCommand(buttonBind.Value);
                }
            }

            if (Input.GetKeyDown(KeyCode.U))
            {
                UndoLastCommand();
            }
        }

        private void ExecuteCommand(ICommand command)
        {
            command.Execute();
            
            _commandsToUndo.Push(command);
        }

        private void UndoLastCommand()
        {
            if (_commandsToUndo.Count == 0)
            {
                Debug.LogError("No commands to undo");
                return;
            }
            
            ICommand commandToUndo = _commandsToUndo.Pop();
            
            commandToUndo.Undo();
        }
    }
}