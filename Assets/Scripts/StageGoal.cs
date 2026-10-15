using TMPro;
using UnityEngine;

public class StageGoal : MonoBehaviour
{
    //SerializeField -> 
    [SerializeField]
    private TextMeshProUGUI goalText;

    //IsTrigger‚É”½‰‚ª‚ ‚é‚©Šm”F
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        // Canvas‚ÉƒS[ƒ‹‚µ‚½î•ñ‚ğ‘—‚é
        goalText.enabled = true;
    }
}
