using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace INotifyExample.ViewModels
{
   public class MainViewModel: ObservableObject
    {
        public PersonViewModel Person { get; private set; }
        public BackGroundViewModel BackGround { get; private set; }


        public MainViewModel()
        {
            Person = new PersonViewModel();
            BackGround = new BackGroundViewModel();

        }


        public void SetBackGround(Brush brushColor)
        {
            BackGround.Color = brushColor;
        }
    }
}
