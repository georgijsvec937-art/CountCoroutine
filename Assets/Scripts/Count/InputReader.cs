using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const KeyCode CommandLeftMouseClicked = KeyCode.Mouse0;

    public event Action MouseClicked;

    private void Update()
    {
        if (Input.GetKeyDown(CommandLeftMouseClicked))
        {
            MouseClicked?.Invoke();
        }
    }
}