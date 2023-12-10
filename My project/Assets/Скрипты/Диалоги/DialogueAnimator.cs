using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    public Animator startAnim;
    public DialogueManager dm;

    public void OnTtriggerEnter2D(Collider2D collider)
    {
        startAnim.SetBool("startOpen", true);
    }
    public void OnTtriggerExit2D(Collider2D collider)
    {
        startAnim.SetBool("startOpen", false);
        dm.EndDialogue();
    }
}
