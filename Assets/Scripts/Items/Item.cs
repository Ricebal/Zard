using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Zard/Item", order = 0)]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite sprite = null;

    public virtual void Use()
    {
        Debug.Log("Using " + name);
    }
}