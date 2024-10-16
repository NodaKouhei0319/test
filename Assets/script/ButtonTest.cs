using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    [SerializeField] GameObject _testObject;

    private test _test;

    public void Start()
    {
        _test = _testObject.GetComponent<test>();
    }
    public void Fuuzin()
    {
        _test.Toto();
        Debug.Log("ïóê_YT");
    }

    public void Enulu()
    {
        Debug.Log("UltimateïΩê¨");
    }
}
