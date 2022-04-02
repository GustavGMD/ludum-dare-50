
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Texting : MonoBehaviour
{
    public TextMeshProUGUI gt;

    //public HorizontalLayoutGroup grid;

    private static readonly HashSet<char> Letters = new HashSet<char>("qwertyuiopasdfghjklçzxcvbnm");

    private ArrayList learned;

    // Start is called before the first frame update
    void Start()
    {
        gt = GetComponent<TextMeshProUGUI>();
        learned = new ArrayList();
        learned.Add(Spell.wat);
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
               Spell myStatus;
               Debug.Log("Try convert");
               if (Enum.TryParse(gt.text.ToLower(), out myStatus)) 
                {
                    if (learned.Contains(myStatus))
                    {
                        Debug.Log("SPELLLL" + myStatus);
                    }
                    
                }
                gt.text = "";
            }
            else if ((Letters.Contains(char.ToLower(c))))
            {
                gt.text += ""+char.ToUpper(c)+"";
            }
        }
    }

    void animateCharacter() {
        var i = gt.text.Length - 1;
        Debug.Log("length " + gt.text.Length + " i: "+ i + "Array " + gt.textInfo.characterInfo);
        TMP_CharacterInfo myCharInfo = gt.textInfo.characterInfo[i];
        Debug.Log("charInfo "+myCharInfo);
        myCharInfo.scale = 200f;
        gt.textInfo.characterInfo[i] = myCharInfo;
        gt.UpdateVertexData();
    }
   
}

public enum Spell {

    wat,
    winto
}