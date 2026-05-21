using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject panelMenu;
    public GameObject panelCloset;
    public GameObject panelHacerOutfit;
    public GameObject panelInspo;

    public void MostrarMenu()
    {
        ApagarPaneles();
        panelMenu.SetActive(true);
    }

    public void MostrarCloset()
    {
        ApagarPaneles();
        panelCloset.SetActive(true);
    }

    public void MostrarHacerOutfit()
    {
        ApagarPaneles();
        panelHacerOutfit.SetActive(true);
    }

    public void MostrarInspo()
    {
        ApagarPaneles();
        panelInspo.SetActive(true);
    }

    private void ApagarPaneles()
    {
        panelMenu.SetActive(false);
        panelCloset.SetActive(false);
        panelHacerOutfit.SetActive(false);
        panelInspo.SetActive(false);
    }
}