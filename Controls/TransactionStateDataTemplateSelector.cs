using System;
using Phantomex.Blockchain.Abstract;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Phantomex.Client.Desktop.Services;
using Phantomex.Client.Desktop.ViewModels.TransactionViewModels;
using Avalonia.Markup.Xaml.Templates;

namespace Phantomex.Client.Desktop.Controls
{
    public class TransactionStateDataTemplateSelector : IDataTemplate
    {
        public bool SupportsRecycling => false;

        public IControl Build(object data)
        {
            return GetTemplate(data)?.Build(data) ?? new TextBlock {Text = "Transaction Template Not Found"};
        }

        private static DataTemplate? GetTemplate(object data)
        {
            if (!(data is TransactionViewModel transaction))
                return null;

            switch (transaction.State)
            {
                case BlockchainTransactionState.Unknown:
                    return App.TemplateService.GetTxStateTemplate(TxStateTemplate.UnknownStateTemplate);
                case BlockchainTransactionState.Pending:
                    return App.TemplateService.GetTxStateTemplate(TxStateTemplate.PendingStateTemplate);
                case BlockchainTransactionState.Confirmed:
                    return App.TemplateService.GetTxStateTemplate(TxStateTemplate.ConfirmedStateTemplate);
                case BlockchainTransactionState.Unconfirmed:
                    return App.TemplateService.GetTxStateTemplate(TxStateTemplate.UnconfirmedStateTemplate);
                case BlockchainTransactionState.Failed:
                    return App.TemplateService.GetTxStateTemplate(TxStateTemplate.FailedStateTemplate);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public bool Match(object data)
        {
            return data is TransactionViewModel;
        }
    }
}