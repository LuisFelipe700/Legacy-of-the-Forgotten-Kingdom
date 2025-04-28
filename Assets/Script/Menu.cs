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
    public void IrahBatalharS1()
    {
        SceneManager.LoadScene("IrahBatalharS1");
    }
    public void EscolhaCaminhoS1()
    {
        SceneManager.LoadScene("EscolhaCaminhoS1");
    }
    public void HistoriaCacada1()
    {
        SceneManager.LoadScene("HistoriaCacada1");
    }
    public void BatalhaSamuraiOrc1()
    {
        SceneManager.LoadScene("BatalhaSamuraiOrc1");
    }
    public void PROIBIDOentra1()
    {
        SceneManager.LoadScene("PROIBIDOentra1");
    }
    public void BatalhaSamuraiSoldado1()
    {
        SceneManager.LoadScene("BatalhaSamuraiSoldado1");
    }
    public void EscolhaArmadura()
    {
        SceneManager.LoadScene("EscolhaArmadura");
    }


    private void OnMouseDown()
    {
        
    }
}
