using ICommand_ex.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ICommand_ex
{
    class MessageViewModel
    {
        // Without parameter
        public string MessageText { get; set;  }
        public MessageCommand DisplayMessageCommand { get; private set; }

        public MessageViewModel()
        {
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
        }

        
        //Without parameter //
        public void DisplayMessage()
        // WITH Paramaeter // public void DisplayMessage( string message)
        {
            //Without parameter //
            MessageBox.Show(MessageText);

            // WITH Paramaeter // //MessageBox.Show(message);
        }

    }
}
