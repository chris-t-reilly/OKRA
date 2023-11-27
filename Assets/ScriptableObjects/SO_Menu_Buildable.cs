using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BuildableDescription {
    public string description;
    public string blueprintName;

    public bool IsEmpty => this == Empty;

    public static readonly BuildableDescription Empty = new BuildableDescription(); 
}

[CreateAssetMenu(menuName = "OKRA/Buildable")]
public class SO_Menu_Buildable : ScriptableObject
{
    [SerializeField]
    public List<BuildableDescription> buildables = new List<BuildableDescription>();


}
