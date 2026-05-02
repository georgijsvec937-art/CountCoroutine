using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public event Action MouseClicked;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            MouseClicked?.Invoke();
        }
    }
}