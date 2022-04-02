
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
                    Debug.Log("Spell not learnead");
                }
                gt.text = "";
            }
            else if ((Letters.Contains(char.ToLower(c))))
            {
                gt.text += ""+char.ToUpper(c)+"";
            }
        }
    }
   
   public void learnNewSpell() {
        int index = learned.Count + 1;
        if (index < spellList.Valids.Count) 
        {
            learned.Add(spellList.Valids[index]);
        }
   }
}