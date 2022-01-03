using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    #region Singleton
    private static SaveManager _instance;
    public static SaveManager Instance { get { return _instance; } }
    #endregion

    #region Variables
    public Transform savePosition;
    public GameObject previousSavePosition;
    #endregion

    #region Unity Methods

    private void Awake()
    {
        // Singleton Region
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        // End Region
    }

    #endregion

    #region Public Methods

    public void SavePlayerPosition(Transform savingPosition, GameObject previousSavingPosition)
    {
        savePosition = savingPosition;
        previousSavePosition = previousSavingPosition;
    }

    #endregion
}
