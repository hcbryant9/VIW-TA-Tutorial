using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropApples : MonoBehaviour
{
    public Animator btnAnim;
    public Animator dropAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            Debug.Log("button clicked");
            btnAnim.Play("btnPress");
            dropAnim.Play("appleFall");
        }
    }
}
