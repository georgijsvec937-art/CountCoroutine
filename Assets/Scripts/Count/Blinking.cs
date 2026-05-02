using System.Collections;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    private int _counter = 1;
    private bool _isActive = false;
    private MeshRenderer _render;

    private void Start()
    {
        _render = GetComponent<MeshRenderer>();
        StartCoroutine(CoroutineBlinking());
    }

    private IEnumerator CoroutineBlinking()
    {
        while (_counter <= 5)
        {
            yield return new WaitForSeconds(2f);

            if (_isActive)
            {
                _render.enabled = false;
                _isActive = false;
            }
            else
            {
                _render.enabled = true;
                _isActive = true;
            }

            Debug.Log($"Счет: {_counter}, состояние объекта: {_isActive}");
            _counter++;
        }
    }
}
