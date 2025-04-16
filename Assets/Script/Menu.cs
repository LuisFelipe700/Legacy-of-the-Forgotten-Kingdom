using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private AudioSource audio;
    [SerializeField] private AudioClip som;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       audio = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void Jogar()
    {
        TocarSom();
        Invoke("SelecionaPersonagens", 1f);
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void Druida()
    {
        SceneManager.LoadScene("Druida");
    }
    public void Samurai()
    {
        SceneManager.LoadScene("Samurai");
    }
    public void Bruxo()
    {
        SceneManager.LoadScene("Bruxo");
    }
    public void TocarSom()
    {
        audio.PlayOneShot(som);
    }
    public void SelecionaPersonagens()
    {
        SceneManager.LoadScene("SelecionaPersonagens");
    }
    public void IrahBatalharS()
    {
        SceneManager.LoadScene("IrahBatalharS");
    }
    public void EscolhaCaminhoS()
    {
        SceneManager.LoadScene("EscolhaCaminhoS");
    }

    public void BatalhaSamuraiOrc()
    {
        SceneManager.LoadScene("BatalhaSamuraiOrc");
    }
    
    

    private void OnMouseDown()
    {
        
    }
}
