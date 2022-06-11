using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutomize : MonoBehaviour
{
    [SerializeField] private GameObject[] cloth;

    [SerializeField] private GameObject characterFemale;
    [SerializeField] private GameObject characterMale;

    [SerializeField] private GameObject btn_LoadFemale;
    [SerializeField] private GameObject btn_LoadMale;

    [SerializeField] protected int currentCloth = 0;





    void Start()
    {
        
        characterFemale.SetActive(false);
        characterMale.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        displayCurrent();

    }
    /// <summary>
    /// Checking index of list
    /// </summary>
    protected virtual void displayCurrent()
    {
        for (int i = 0; i < cloth.Length; i++)
        {
            if (i == currentCloth)
            {
                cloth[i].SetActive(true);
            }
            else
            {
                cloth[i].SetActive(false);
            }
        }
    }
    #region
    /// <summary>
    /// Load next character
    /// </summary>
    public void onNextButton()
    {
        if(currentCloth == cloth.Length - 1)
        {
            currentCloth = 0;
        }
        else
        {
            currentCloth++;
        }
    }
    /// <summary>
    /// Load previous character
    /// </summary>
    public void onPreviousButton()
    {
        if (currentCloth == 0)
        {
            currentCloth = cloth.Length - 1;
        }
        else
        {
            currentCloth--;
        }
    }
    /// <summary>
    /// Set active female character
    /// </summary>
    public void onLoadFemale()
    {
        characterFemale.SetActive(true);
        cloth = GameObject.FindGameObjectsWithTag("Player");
        btn_LoadFemale.SetActive(false);
        
    }
    /// <summary>
    /// Set active male character
    /// </summary>
    public void onLoadMale()
    {
        characterMale.SetActive(true);
        cloth = GameObject.FindGameObjectsWithTag("Player1");
        btn_LoadMale.SetActive(false);

    }
    #endregion
}
