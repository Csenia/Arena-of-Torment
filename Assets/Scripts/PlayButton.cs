using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private int _index;

    public void OnClic()
    {
        SceneManager.LoadScene(_index);
    }
}
