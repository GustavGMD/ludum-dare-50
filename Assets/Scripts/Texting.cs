
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Texting : MonoBehaviour
{
    public TextMeshProUGUI gt;

    private static readonly HashSet<char> Letters = new HashSet<char>("qwertyuiopasdfghjklçzxcvbnm");

    // Start is called before the first frame update
    void Start()
    {
        gt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (char c in Input.inputString)
        {
            if (c == '\b') // has backspace/delete been pressed?
            {
                if (gt.text.Length != 0)
                {
                    gt.text = gt.text.Substring(0, gt.text.Length - 1);
                }
            }
            else if ((c == '\n') || (c == '\r')) // enter/return
            {
               // CAST SPELL
            }
            else if ((Letters.Contains(c)))
            {
                gt.text += c;
            }
        }
    }
}
