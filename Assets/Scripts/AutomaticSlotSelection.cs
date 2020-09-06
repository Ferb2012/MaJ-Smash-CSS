using UnityEngine;
using System.Collections;

public class AutomaticSlotSelection : MonoBehaviour
{
    void Start()
    {
        Vector2 artworkOriginalSize = transform.Find("artwork").GetComponent<RectTransform>().sizeDelta;

        int random = Random.Range(0, SmashCSS.instance.characters.Count - 1);

        Character randomChar = SmashCSS.instance.characters[random];

        SmashCSS.instance.ShowCharacterInSlot(transform.GetSiblingIndex(), randomChar);

        transform.Find("artwork").GetComponent<RectTransform>().sizeDelta = artworkOriginalSize * randomChar.zoom;
    }
}
