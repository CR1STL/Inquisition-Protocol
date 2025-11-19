using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadScreen : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Slider scale;
    public int Scene;
    public void Loading()
    {
        LoadingScreen.SetActive(true);
        StartCoroutine(LoadAsync());
    }
    vpn://AAAA_3icdY07C8IwFEb_SsmsQh06uJVSFFEoonMI6W2MNQ_yqNTS_26SIk5OF-45fGdCkghAuwyVQsKbk6wxILgXaJWhFiw1XDuu5B-DKtlxhgcwdpG24Uk0xwsIjwlZMAOngN2oU4gsM2v9m_kq2iinqHom7cUi8oGFNS-dGcNt04TxaI4h7-64JY6kTsz2MEY-1kdB_eO42ctLkRNbwOlWHdz5SnmdU0Z8VbIub_oKzfMHSoVXM==
    IEnumerator LoadAsync()
    {
        AsyncOperation loadAsync = SceneManager.LoadSceneAsync(Scene);
        loadAsync.allowSceneActivation = false;
        while (!loadAsync.isDone)
        {
            scale.value = loadAsync.progress;

            if (loadAsync.progress >= .9f && !loadAsync.allowSceneActivation)
            {
                yield return new WaitForSeconds(1f);
                loadAsync.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
