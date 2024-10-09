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
            if (conversionType == "���")
            {
                if (fromUnit == "���������" && toUnit == "�����")
                {
                    return valueToConvert * 1000;
                }
                else if (fromUnit == "�����" && toUnit == "���������")
                {
                    return valueToConvert / 1000;
                }
                else if (fromUnit == "�����" && toUnit == "���������")
                {
                    return valueToConvert * 1000;
                }
                else if (fromUnit == "���������" && toUnit == "�����")
                {
                    return valueToConvert / 1000;
                }
                else if (fromUnit == "����" && toUnit == "���������")
                {
                    return valueToConvert * 0.453592;
                }
                else if (fromUnit == "���������" && toUnit == "����")
                {
                    return valueToConvert / 0.453592;
                }
                else if (fromUnit == "�����" && toUnit == "�����")
                {
                    return valueToConvert * 28.3495;
                }
                else if (fromUnit == "�����" && toUnit == "�����")
                {
                    return valueToConvert / 28.3495;
                }
            }
            else if (conversionType == "�����")
            {
                if (fromUnit == "����" && toUnit == "���������")
                {
                    return valueToConvert * 100;
                }
                else if (fromUnit == "���������" && toUnit == "����")
                {
                    return valueToConvert / 100;
                }
                else if (fromUnit == "��������" && toUnit == "����")
                {
                    return valueToConvert * 1000;
                }
                else if (fromUnit == "����" && toUnit == "��������")
                {
                    return valueToConvert / 1000;
                }
                else if (fromUnit == "����" && toUnit == "��������")
                {
                    return valueToConvert * 1.60934;
                }
                else if (fromUnit == "��������" && toUnit == "����")
                {
                    return valueToConvert / 1.60934;
                }
                else if (fromUnit == "���" && toUnit == "���������")
                {
                    return valueToConvert * 30.48;
                }
                else if (fromUnit == "���������" && toUnit == "���")
                {
                    return valueToConvert / 30.48;
                }
            }
            else if (conversionType == "�����")
            {
                if (fromUnit == "����" && toUnit == "���������")
                {
                    return valueToConvert * 1000;
                }
                else if (fromUnit == "���������" && toUnit == "����")
                {
                    return valueToConvert / 1000;
                }
                else if (fromUnit == "��������" && toUnit == "����")
                {
                    return valueToConvert * 1000;
                }
                else if (fromUnit == "����" && toUnit == "��������")
                {
                    return valueToConvert / 1000;
                }
                else if (fromUnit == "������" && toUnit == "����")
                {
                    return valueToConvert * 3.78541;
                }
                else if (fromUnit == "����" && toUnit == "������")
                {
                    return valueToConvert / 3.78541;
                }
            }
            return valueToConvert;
        }
    }
}
