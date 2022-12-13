using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using NCMB;
using NCMB.Extensions;

namespace naichilab
{
    public class InstructionSceneManager : MonoBehaviour
    {

        public void OnCloseButtonClick()
        {
            //closeButton.interactable = false;
            UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync("Instruction");
        }
    }
}