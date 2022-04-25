using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Template
{
    public partial class AppViewModel : Observable
    {

        private Timer timer;
        private bool timerInvoked = false;


        //*****************************  App View model  ******************************************// 
        public AppViewModel()                     
        {

            try
            {
               
            }
            catch(Exception e)
            {

            }

            timer = new Timer(onTimer);                                                                           
            timer.Change(0, 100);                                                                                 // Kijk voor change 
        }

        private bool CanCalcSum()
        {
            return true;
        }

        private void CalcSum()
        {
            result = 5;
            return;
        }






        //*****************************  Timer for the GUI update ******************************************//  
        private void onTimer(object StateInfo)                                                                     // On timer methode omn GUI te updaten 
        {
            if (!timerInvoked)
            {
                timerInvoked = true;

                try
                {


                    // Take in the load cells
                    value1 = 10;
                    value2 = 5;


                }
                catch (Exception ex)
                {
                  
                }

                timerInvoked = false;
            }
        }

    }
}
