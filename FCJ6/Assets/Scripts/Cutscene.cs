using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Cutscene : MonoBehaviour
{
    string boy1 = "Grandson: Ugh. It's so annoying, it's so hard to wake up on time and I'm always late to school.";
    string grandpa1 = "Grandpa: Bah! Back in my day, we were late to school even if we woke up two hours too early!";
    public string nextScene;
    public TMP_Text subtitle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoCutscene());
    }

    IEnumerator DoCutscene()
    {
        subtitle.text = boy1;
        yield return new WaitForSeconds(8f);
        subtitle.text = grandpa1;
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene(nextScene);
    }

    
}
