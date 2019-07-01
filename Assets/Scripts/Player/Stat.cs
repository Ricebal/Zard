using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Stat", menuName = "Zard/Stat", order = 0)]
public class Stat : ScriptableObject
{
    public float minValue;
    public float maxValue;
    public float currentValue;

    public delegate void OnStatChangeDelegate();
    public event OnStatChangeDelegate OnStatChange;

    public void Subtract(float value)
    {
        currentValue = Mathf.Clamp(currentValue - value, minValue, maxValue);
        OnStatChange?.Invoke();
    }

    public void Add(float value)
    {
        currentValue = Mathf.Clamp(currentValue + value, minValue, maxValue);
        OnStatChange?.Invoke();
    }

    public void Reset()
    {
        currentValue = maxValue;
        OnStatChange?.Invoke();
    }
}