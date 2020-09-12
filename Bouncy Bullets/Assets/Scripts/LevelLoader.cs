using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    public Animator transitionAnimate;
    public float animTime;

    public IEnumerator Fade(int index) {
        transitionAnimate.SetTrigger("Start");

        yield return new WaitForSeconds(animTime);

        SceneManager.LoadScene(index);
    }
}