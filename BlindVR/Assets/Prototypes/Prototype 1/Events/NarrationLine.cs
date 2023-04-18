using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Narration/Line")]
public class NarrationLine : ScriptableObject
{
    public int allowActionSecondsEarlier = 0;
    public AudioClip clip;
}
