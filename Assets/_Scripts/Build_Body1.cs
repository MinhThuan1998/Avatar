using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_Body1 : MonoBehaviour
{
    [SerializeField] protected List<Transform> models;
    [SerializeField] protected int currentLevel = 0;
    // Start is called before the first frame update
    void Start()
    {

        
    }
    private void OnEnable()
    {
        this.ShowModels();
        InvokeRepeating("ShowNextModels", 3, 2);
        
    }
    void Reset()
    {
        LoadModels();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    protected virtual void LoadModels()
    {
        if (this.models.Count > 0) return;
        Transform buildTran = transform.Find("Body1_Manager");
        foreach (Transform child in buildTran)
        {
            this.models.Add(child);
            child.gameObject.SetActive(false);

        }
    }
    /// <summary>
    /// Check current
    /// </summary>
    protected virtual void ShowModels()
    {
        this.HideModels();
        Transform currentBuild = this.models[this.currentLevel];
        currentBuild.gameObject.SetActive(true);
    }

    protected virtual void ShowNextModels()
    {
        if (this.currentLevel >= this.models.Count - 1) this.currentLevel = 0;

        this.currentLevel++;
        this.ShowModels();
    }

    /// <summary>
    /// Hide last model
    /// </summary>
    protected virtual void HideModels()
    {
        int lastBuildIndex = this.currentLevel - 1;
        if (lastBuildIndex < 0) return;
        Transform lastBuild = this.models[lastBuildIndex];
        lastBuild.gameObject.SetActive(false);
    }
}
