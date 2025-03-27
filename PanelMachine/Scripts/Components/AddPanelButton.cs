using UnityEngine;
using UnityEngine.UI;

namespace Game.Mephistoss.PanelMachine.Scripts
{
    [RequireComponent(typeof(Button))]
    public class AddPanelButton : MonoBehaviour
    {
        [SerializeField] private PanelMachine _panelMachine;
        [SerializeField] private PanelBase _panelBase;

        public PanelMachine PanelMachine => _panelMachine;
        public PanelBase PanelBase => _panelBase;

        private Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(AddPanel);
        }

        public void AddPanel() =>
            _panelMachine.AddPanel(_panelBase);
    }
}