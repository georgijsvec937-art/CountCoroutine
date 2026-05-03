using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;

    private int _counter = 0;
    private Coroutine _counterRoutine;
    private WaitForSeconds _timeDelay = new WaitForSeconds(0.5f);

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
        while (enabled)
        {
            yield return _timeDelay;
            _counter++;
            Debug.Log($"счетчик: {_counter}");
        }
    }
}