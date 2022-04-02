using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpellList", menuName = "spells", order = 100)]
public class Spell : ScriptableObject
{
    [SerializeField]
    private List<string> valids;

    public List<string> Valids => valids;

    [SerializeField]
    public List<SpellDefinition> spellDefinitions;
}
