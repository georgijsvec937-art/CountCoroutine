using System.Collections;
using UnityEngine;

public class Count : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;

    private int _counter = 0;
    private Coroutine _counterRoutine;
    private WaitForSeconds wait = new WaitForSeconds(0.5f);

    private void OnEnable()
    {
        _inputReader.MouseClicked += OnMouseCliked;
    }

    private void OnDisable()
    {
        _inputReader.MouseClicked -= OnMouseCliked;
    }

    private void OnMouseCliked()
    {
        if (_counterRoutine == null)
        {
            _counterRoutine = StartCoroutine(TimerRoutine());
        }
        else
        {
            StopCoroutine(_counterRoutine);
            _counterRoutine = null;
        }
    }

    private IEnumerator TimerRoutine()
    {
        Debug.Log("sdfasdf");

        while (enabled)
        {
            yield return wait;
            _counter++;
            Debug.Log($"счетчик: {_counter}");
        }
    }
}