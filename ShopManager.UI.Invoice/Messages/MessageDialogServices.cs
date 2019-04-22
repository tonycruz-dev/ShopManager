using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Invoice.Messages
{
    public class MessageDialogServices : IMessageDialogServices
    {
        public Task ShowInfoDialogAsync(string text)
        {
            throw new NotImplementedException();
        }

        public Task<MessageDialogResult> ShowOkCancelDialogAsync(string text, string title)
        {
            throw new NotImplementedException();
        }
    }
}
