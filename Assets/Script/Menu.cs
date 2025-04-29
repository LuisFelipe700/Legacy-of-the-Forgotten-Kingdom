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
    public void HistoriaCacada2()
    {
        SceneManager.LoadScene("HistoriaCacada2");
    }
    public void EscolhaCaminhoS2()
    {
        SceneManager.LoadScene("EscolhaCaminhoS2");
    }
    public void IrahBatalharS2()
    {
        SceneManager.LoadScene("IrahBatalharS2");
    }
    public void PROIBIDOentra2()
    {
        SceneManager.LoadScene("PROIBIDOentra2");
    }
    public void BatalhaSamuraiOrc2()
    {
        SceneManager.LoadScene("BatalhaSamuraiOrc2");
    }
    public void BatalhaSamuraiSoldado2()
    {
        SceneManager.LoadScene("BatalhaSamuraiSoldado2");
    }
    public void HistoriaCacada3()
    {
        SceneManager.LoadScene("HistoriaCacada3");
    }
    public void EscolhaCaminhoS3()
    {
        SceneManager.LoadScene("EscolhaCaminhoS3");
    }
    public void IrahBatalharS3()
    {
        SceneManager.LoadScene("IrahBatalharS3");
    }
    public void PROIBIDOentra3()
    {
        SceneManager.LoadScene("PROIBIDOentra3");
    }
    public void BatalhaSamuraiOrc3()
    {
        SceneManager.LoadScene("BatalhaSamuraiOrc3");
    }
    public void BatalhaSamuraiSoldado3()
    {
        SceneManager.LoadScene("BatalhaSamuraiSoldado3");
    }
    private void OnMouseDown()
    {
        
    }
}
