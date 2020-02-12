using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Text", menuName = "Text")]
public class Text : ScriptableObject
{

    [SerializeField] private string text;
    public string TextString => text;
}
