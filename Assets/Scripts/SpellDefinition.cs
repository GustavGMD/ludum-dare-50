using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpellDefinitionList", menuName = "spells/definition", order = 100)]
public class SpellDefinition : ScriptableObject
{
    public string spellName;

    public int energyCost;
}

