using System;
using UnityEditor.Search;
using UnityEngine;

public enum MathsOperation
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

[System.Serializable]
public class Problem : MonoBehaviour
{
    public float firstNumber;
    public float secondNumber;

    public MathsOperation operation;
    public float[] answers;
    public int correctTube;

    bool IsGameOver(int score)
    {
        return score == 10;
    }
}
