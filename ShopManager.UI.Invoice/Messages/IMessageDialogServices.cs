using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.UI.Invoice.Messages
{
    public interface IMessageDialogServices
    {
        Task<MessageDialogResult> ShowOkCancelDialogAsync(string text, string title);
        Task ShowInfoDialogAsync(string text);
    }
}
