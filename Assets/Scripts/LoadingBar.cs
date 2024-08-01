using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] private float timeToLoad = 3f;
    private void Start() {
        slider.value = 0;
        StartCoroutine(LoadProgressBar());
    }

    private IEnumerator LoadProgressBar() {
        float time = 0;
        while (time < timeToLoad) {
            time += Time.deltaTime;
            slider.value = time / timeToLoad;
            if (slider.value >= 1) {
                CheckTutorialData();
            }

            yield return null;
        }
    }

    public void CheckTutorialData() {
        //if(tutorialData.firstTimePlaying) {
        //} else {
        SceneManager.LoadScene("MainMenu");
        // }
    }
}
