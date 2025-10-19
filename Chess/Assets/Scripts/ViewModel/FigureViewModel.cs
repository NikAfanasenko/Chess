using UnityEngine;

namespace Assets.Scripts.ViewModel
{
    public class FigureViewModel : MonoBehaviour
    {
        private Figure _figure; 

        public FigureViewModel(Figure figure)
        {
            _figure = figure;
        }        
    }
}
