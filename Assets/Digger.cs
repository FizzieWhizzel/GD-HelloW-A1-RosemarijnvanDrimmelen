using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiggerDialogue : MonoBehaviour
{
    [SerializeField] bool firstInteraction = true;
    [SerializeField] int repeatStartPosition;
    public string npcName;
    public DialogueAsset dialogue;

     [HideInInspector]
    public int StartPosition {
        get
        {
            if (firstInteraction)
            {
                firstInteraction = false;
                return 0;
            }
            else
            {
                return repeatStartPosition;
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
