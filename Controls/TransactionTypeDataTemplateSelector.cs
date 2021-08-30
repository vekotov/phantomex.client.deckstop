using System;
using Phantomex.Blockchain.Abstract;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Phantomex.Client.Desktop.Services;
using Phantomex.Client.Desktop.ViewModels.TransactionViewModels;
using Avalonia.Markup.Xaml.Templates;

namespace Phantommex.Client.Desktop.Controls
{
    public class TransactionTypeDataTemplateSelector : IDataTemplate
    {
        public bool SupportsRecycling => false;

        public IControl Build(object data)
        {
            return GetTemplate(data)?.Build(data) ?? new TextBlock {Text = "Transaction Template Not Found"};
        }

        private static DataTemplate? GetTemplate(object data)
        {
            if (!(data is TransactionViewModel tx))
                return null;

            if (tx.Type.HasFlag(BlockchainTransactionType.SwapPayment))
                return App.TemplateService.GetTxTypeTemplate(TxTypeTemplate.SwapPaymentTypeTemplate);

            if (tx.Type.HasFlag(BlockchainTransactionType.SwapRefund))
                return App.TemplateService.GetTxTypeTemplate(TxTypeTemplate.SwapRefundTypeTemplate);

            if (tx.Type.HasFlag(BlockchainTransactionType.SwapRedeem))
                return App.TemplateService.GetTxTypeTemplate(TxTypeTemplate.SwapRedeemTypeTemplate);

            if (tx.Type.HasFlag(BlockchainTransactionType.TokenApprove))
                return App.TemplateService.GetTxTypeTemplate(TxTypeTemplate.TokenApproveTypeTemplate);

            if (tx.Type.HasFlag(BlockchainTransactionType.TokenCall))
                return App.TemplateService.GetTxTypeTemplate(TxTypeTemplate.TokenApproveTypeTemplate);

            if (tx.Type.HasFlag(BlockchainTransactionType.SwapCall))
                return App.TemplateService.GetTxTypeTemplate(TxTypeTemplate.TokenApproveTypeTemplate);

            if (tx.Amount <= 0) //tx.Type.HasFlag(BlockchainTransactionType.Output))
                return App.TemplateService.GetTxTypeTemplate(TxTypeTemplate.SentTypeTemplate);

            if (tx.Amount > 0) //tx.Type.HasFlag(BlockchainTransactionType.Input))
                return App.TemplateService.GetTxTypeTemplate(TxTypeTemplate.ReceivedTypeTemplate);

            return App.TemplateService.GetTxTypeTemplate(TxTypeTemplate.UnknownTypeTemplate);
        }

        public bool Match(object data)
        {
            return data is TransactionViewModel;
        }
    }
}