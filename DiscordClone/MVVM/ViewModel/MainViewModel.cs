using DiscordClone.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordClone.MVVM.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }
        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel
            {
                Username = "Spake",
                UsernameColor = "#403f2f",
                ImageSource = "https://cataas.com/cat/610917d25bd94e00182d213f/says/I%20am%20spake",
                Message = "TEST",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Spake",
                    UsernameColor = "#403f2f",
                    ImageSource = "https://cataas.com/cat/610917d25bd94e00182d213f/says/I%20am%20spake",
                    Message = "TEST",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Satan",
                    UsernameColor = "#403f2f",
                    ImageSource = "https://cataas.com/cat/610f082c029b39001141db53/says/I%20am%20satan",
                    Message = "TEST",
                    Time = DateTime.Now,
                    IsNativeOrigin = false
                });
            }

            Messages.Add(new MessageModel
            {
                Username = "Satan",
                UsernameColor = "#403f2f",
                ImageSource = "https://cataas.com/cat/610f082c029b39001141db53/says/I%20am%20satan",
                Message = "Last Message",
                Time = DateTime.Now,
                IsNativeOrigin = false
            });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Person {i}",
                    ImageSource = "https://cataas.com/cat/611c6a42f97b85001827cfce",
                    Messages = Messages
                });
            }
        }
    }
}
