using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CameraScript : MonoBehaviour {
	private Animator camAnim;

    void Awake() {
        camAnim = GetComponent<Animator>();
    }
    public void Shake(int amount) {
        int index = 1;
        while (index <= amount) {
		    camAnim.SetTrigger("Shake");
            index++;
        }
    }
}