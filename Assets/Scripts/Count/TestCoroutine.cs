using System;
using System.Collections;
using UnityEngine;

public class TestCoroutine : MonoBehaviour
{
    private int _counter = 5;

    void Start()
    {
        Debug.Log("Началось!");
        StartCoroutine(CountRoutine());
    }

    private IEnumerator CountRoutine()
    {
        Debug.Log("Запуск!");

        while (_counter > 0)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log($"Счет: {_counter}");
            _counter--;
        }
    }
}