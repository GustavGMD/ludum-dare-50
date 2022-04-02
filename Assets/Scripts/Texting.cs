
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Texting : MonoBehaviour
{
    public TextMeshProUGUI gt;

    public Spell spellList;

    //public HorizontalLayoutGroup grid;

    private static readonly HashSet<char> Letters = new HashSet<char>("qwertyuiopasdfghjklçzxcvbnm ");

    private ArrayList learned;

    // Start is called before the first frame update
    void Start()
    {
        gt = GetComponent<TextMeshProUGUI>();
        learned = new ArrayList();
        for (int i = 0; i < 2; i++)
        {
            learned.Add(spellList.Valids[i]);
            Debug.Log("Spell lerned "+spellList.Valids[i]);
        }
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
                var i = learned.IndexOf(gt.text.ToLower());
                if (i>=0) {
                    Debug.Log("Spell cast "+spellList.spellDefinitions[i].spellName);
                }
                else
                {
                    Debug.Log("Spell not lernead");
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

public enum SpellOld {

    wat,
    winto,
    blackHole
}