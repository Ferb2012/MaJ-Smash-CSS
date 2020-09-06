using UnityEngine;
using System.Collections;

[System.Serializable]
[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject
{
    public string characterName;
    public Sprite characterSprite;
    public Sprite characterIcon;
    public float zoom = 1;
}
