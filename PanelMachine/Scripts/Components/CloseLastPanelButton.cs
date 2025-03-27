using UnityEngine;
using UnityEngine.UI;

namespace Game.Mephistoss.PanelMachine.Scripts
{
    [RequireComponent(typeof(Button))]
    public class CloseLastPanelButton : MonoBehaviour
    {
        [SerializeField] private PanelMachine _panelMachine;

        public PanelMachine PanelMachine => _panelMachine;

        private Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(ClosePanel);
        }

        public void ClosePanel() =>
            _panelMachine.CloseLastPanel();
    }
}