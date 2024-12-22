using Date;
using UnityEngine;

public class ChoiceIconsScript : MonoBehaviour
{ 
    public Sprite[] sprites;

    public void ChoiceIcon(int num)
    {
        GameData.sprite = sprites[num];
    }
}
