using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace Phantomex.Client.Desktop.Helpers
{
    public class AmountTextBoxHelper : Visual
    {
        static AmountTextBoxHelper()
        {
            AffectsRender<AmountTextBoxHelper>(
                CurrencyCodeProperty,
                AmountInBaseProperty,
                BaseCurrencyCodeProperty,
                CurrencyCodeFontSizeProperty,
                AmountInBaseFontSizeProperty,
                BaseCurrencyCodeFontSizeProperty
            );
        }

        public static readonly StyledProperty<string> CurrencyCodeProperty =
            AvaloniaProperty.Register<AmountTextBoxHelper, string>("CurrencyCode", string.Empty);

        public static readonly StyledProperty<string> AmountInBaseProperty =
            AvaloniaProperty.Register<AmountTextBoxHelper, string>("AmountInBase", string.Empty);

        public static readonly StyledProperty<string> BaseCurrencyCodeProperty =
            AvaloniaProperty.Register<AmountTextBoxHelper, string>("BaseCurrencyCode", string.Empty);

        public static readonly StyledProperty<double> CurrencyCodeFontSizeProperty =
            AvaloniaProperty.Register<AmountTextBoxHelper, double>("CurrencyCodeFontSize", 12.0d);

        public static readonly StyledProperty<double> AmountInBaseFontSizeProperty =
            AvaloniaProperty.Register<AmountTextBoxHelper, double>("AmountInBaseFontSize", 15.0d);

        public static readonly StyledProperty<double> BaseCurrencyCodeFontSizeProperty =
            AvaloniaProperty.Register<AmountTextBoxHelper, double>("BaseCurrencyCodeFontSize", 10.0d);


        public static string GetCurrencyCode(TextBox textBox) =>
            (string) textBox.GetValue(CurrencyCodeProperty);

        public static void SetCurrencyCode(TextBox textBox, string value) =>
            textBox.SetValue(CurrencyCodeProperty, value);

        public static string GetAmountInBase(TextBox textBox) =>
            (string) textBox.GetValue(AmountInBaseProperty);

        public static void SetAmountInBase(TextBox textBox, string value) =>
            textBox.SetValue(AmountInBaseProperty, value);

        public static string GetBaseCurrencyCode(TextBox textBox) =>
            (string) textBox.GetValue(BaseCurrencyCodeProperty);

        public static void SetBaseCurrencyCode(TextBox textBox, string value) =>
            textBox.SetValue(BaseCurrencyCodeProperty, value);

        public static double GetCurrencyCodeFontSize(TextBox textBox) =>
            (double) textBox.GetValue(CurrencyCodeFontSizeProperty);

        public static void SetCurrencyCodeFontSize(TextBox textBox, double value) =>
            textBox.SetValue(CurrencyCodeFontSizeProperty, value);

        public static double GetAmountInBaseFontSize(TextBox textBox) =>
            (double) textBox.GetValue(AmountInBaseFontSizeProperty);

        public static void SetAmountInBaseFontSize(TextBox textBox, double value) =>
            textBox.SetValue(AmountInBaseFontSizeProperty, value);

        public static double GetBaseCurrencyCodeFontSize(TextBox textBox) =>
            (double) textBox.GetValue(BaseCurrencyCodeFontSizeProperty);

        public static void SetBaseCurrencyCodeFontSize(TextBox textBox, double value) =>
            textBox.SetValue(BaseCurrencyCodeFontSizeProperty, value);
    }
}