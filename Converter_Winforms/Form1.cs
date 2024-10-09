namespace Converter_Winforms
{
    public partial class ConversionForm : Form
    {
        public ConversionForm()
        {
            InitializeComponent();
        }

        private void getResultButton_Click(object sender, EventArgs e)
        {
            string conversionType = convertTypeComboBox.SelectedItem.ToString();
            string fromUnit = fromUnitComboBox.SelectedItem.ToString();
            string toUnit = toUnitsComboBox.SelectedItem.ToString();
            double valueToConvert = double.Parse(fromUnitsTextBox.Text);

            double result = ConvertValue(conversionType, fromUnit, toUnit, valueToConvert);

            resultTextBox.Text = result.ToString();
        }

        private double ConvertValue(string conversionType, string fromUnit, string toUnit, double valueToConvert)
        {
            if (conversionType == "Вес")
            {
                if (fromUnit == "Килограмм" && toUnit == "Грамм")
                {
                    return valueToConvert * 1000;
                }
                else if (fromUnit == "Грамм" && toUnit == "Килограмм")
                {
                    return valueToConvert / 1000;
                }
                else if (fromUnit == "Тонна" && toUnit == "Килограмм")
                {
                    return valueToConvert * 1000;
                }
                else if (fromUnit == "Килограмм" && toUnit == "Тонна")
                {
                    return valueToConvert / 1000;
                }
                else if (fromUnit == "Фунт" && toUnit == "Килограмм")
                {
                    return valueToConvert * 0.453592;
                }
                else if (fromUnit == "Килограмм" && toUnit == "Фунт")
                {
                    return valueToConvert / 0.453592;
                }
                else if (fromUnit == "Унция" && toUnit == "Грамм")
                {
                    return valueToConvert * 28.3495;
                }
                else if (fromUnit == "Грамм" && toUnit == "Унция")
                {
                    return valueToConvert / 28.3495;
                }
            }
            else if (conversionType == "Длина")
            {
                if (fromUnit == "Метр" && toUnit == "Сантиметр")
                {
                    return valueToConvert * 100;
                }
                else if (fromUnit == "Сантиметр" && toUnit == "Метр")
                {
                    return valueToConvert / 100;
                }
                else if (fromUnit == "Километр" && toUnit == "Метр")
                {
                    return valueToConvert * 1000;
                }
                else if (fromUnit == "Метр" && toUnit == "Километр")
                {
                    return valueToConvert / 1000;
                }
                else if (fromUnit == "Миля" && toUnit == "Километр")
                {
                    return valueToConvert * 1.60934;
                }
                else if (fromUnit == "Километр" && toUnit == "Миля")
                {
                    return valueToConvert / 1.60934;
                }
                else if (fromUnit == "Фут" && toUnit == "Сантиметр")
                {
                    return valueToConvert * 30.48;
                }
                else if (fromUnit == "Сантиметр" && toUnit == "Фут")
                {
                    return valueToConvert / 30.48;
                }
            }
            else if (conversionType == "Объем")
            {
                if (fromUnit == "Литр" && toUnit == "Миллилитр")
                {
                    return valueToConvert * 1000;
                }
                else if (fromUnit == "Миллилитр" && toUnit == "Литр")
                {
                    return valueToConvert / 1000;
                }
                else if (fromUnit == "Кубометр" && toUnit == "Литр")
                {
                    return valueToConvert * 1000;
                }
                else if (fromUnit == "Литр" && toUnit == "Кубометр")
                {
                    return valueToConvert / 1000;
                }
                else if (fromUnit == "Галлон" && toUnit == "Литр")
                {
                    return valueToConvert * 3.78541;
                }
                else if (fromUnit == "Литр" && toUnit == "Галлон")
                {
                    return valueToConvert / 3.78541;
                }
            }
            return valueToConvert;
        }
    }
}
