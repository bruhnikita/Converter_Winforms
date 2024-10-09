namespace Converter_Winforms
{
    partial class ConversionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            convertTypeComboBox = new ComboBox();
            fromUnitComboBox = new ComboBox();
            fromUnitsTextBox = new TextBox();
            getResultButton = new Button();
            resultTextBox = new TextBox();
            toUnitsComboBox = new ComboBox();
            SuspendLayout();
            // 
            // convertTypeComboBox
            // 
            convertTypeComboBox.FormattingEnabled = true;
            convertTypeComboBox.Items.AddRange(new object[] { "Длина", "Вес", "Объём" });
            convertTypeComboBox.Location = new Point(12, 12);
            convertTypeComboBox.Name = "convertTypeComboBox";
            convertTypeComboBox.Size = new Size(439, 23);
            convertTypeComboBox.TabIndex = 0;
            convertTypeComboBox.Text = "Выберите тип преобразования...";
            // 
            // fromUnitComboBox
            // 
            fromUnitComboBox.FormattingEnabled = true;
            fromUnitComboBox.Location = new Point(12, 41);
            fromUnitComboBox.Name = "fromUnitComboBox";
            fromUnitComboBox.Size = new Size(439, 23);
            fromUnitComboBox.TabIndex = 1;
            fromUnitComboBox.Text = "Преобразовать из...";
            // 
            // fromUnitsTextBox
            // 
            fromUnitsTextBox.Location = new Point(12, 102);
            fromUnitsTextBox.Name = "fromUnitsTextBox";
            fromUnitsTextBox.PlaceholderText = "Введите количество...";
            fromUnitsTextBox.Size = new Size(439, 23);
            fromUnitsTextBox.TabIndex = 2;
            // 
            // getResultButton
            // 
            getResultButton.Location = new Point(12, 331);
            getResultButton.Name = "getResultButton";
            getResultButton.Size = new Size(439, 39);
            getResultButton.TabIndex = 3;
            getResultButton.Text = "Результат";
            getResultButton.UseVisualStyleBackColor = true;
            getResultButton.Click += getResultButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(12, 280);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.PlaceholderText = "Здесь будет результат...";
            resultTextBox.Size = new Size(439, 23);
            resultTextBox.TabIndex = 4;
            // 
            // toUnitsComboBox
            // 
            toUnitsComboBox.FormattingEnabled = true;
            toUnitsComboBox.Location = new Point(12, 70);
            toUnitsComboBox.Name = "toUnitsComboBox";
            toUnitsComboBox.Size = new Size(439, 23);
            toUnitsComboBox.TabIndex = 5;
            toUnitsComboBox.Text = "Преобразовать в...";

            convertTypeComboBox.Items.AddRange(new object[] { "Длина", "Вес", "Объём" });
            convertTypeComboBox.Text = "Выберите тип преобразования...";

            fromUnitComboBox.Items.AddRange(new object[] {
                "Метр", "Сантиметр", "Километр", "Миля", "Фут",
                "Килограмм", "Грамм", "Тонна", "Фунт", "Унция",
                "Литр", "Миллилитр", "Кубометр", "Галлон"
            });
            fromUnitComboBox.Text = "Преобразовать из...";

            toUnitsComboBox.Items.AddRange(new object[] {
                "Метр", "Сантиметр", "Километр", "Миля", "Фут",
                "Килограмм", "Грамм", "Тонна", "Фунт", "Унция",
                "Литр", "Миллилитр", "Кубометр", "Галлон"
            });
            // 
            // ConversionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 416);
            Controls.Add(toUnitsComboBox);
            Controls.Add(resultTextBox);
            Controls.Add(getResultButton);
            Controls.Add(fromUnitsTextBox);
            Controls.Add(fromUnitComboBox);
            Controls.Add(convertTypeComboBox);
            Name = "ConversionForm";
            Text = "Конвертер единиц измерения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox convertTypeComboBox;
        private ComboBox fromUnitComboBox;
        private TextBox fromUnitsTextBox;
        private Button getResultButton;
        private TextBox resultTextBox;
        private ComboBox toUnitsComboBox;
    }
}
