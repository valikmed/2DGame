using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHandler : MonoBehaviour
{
    [Header("Main Configuration")]
    public int[] Array;
    [Range(0,10)]
    public float Speed;
    public GameObject Object;
    public TestDate Date;
    [SerializeField]
    private List<TestDate> Dates;
    [HideInInspector]
    public string Text;

    [TextArea(5,25)]
    public string LongText;

}

[System.Serializable]
public class TestDate
{
    public float Health;
    public float Money;
}