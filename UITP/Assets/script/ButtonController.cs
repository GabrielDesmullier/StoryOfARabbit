using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonController : MonoBehaviour
{

    [SerializeField] private List<Text> script;
    [SerializeField] private TextMeshProUGUI textMeshProGUI = default;
    private int index = 0;
    // Start is called before the first frame update

    public void Change()
    {
        textMeshProGUI.text = script[index].TextString;

        if (index < script.Count)
        {
            index++;
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
