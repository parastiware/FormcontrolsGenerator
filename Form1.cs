using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formcontrols
{
    public partial class Form1 : Form
    {
        int a;
        Random X = new Random();
       public enum ToolOptions
        {
            TextBox,Button,Label,CheckBox,RadioButton
        }
        public Form1()
        {
            InitializeComponent();
            setValue();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        void setValue()
        {
           
            foreach(var option in Enum.GetValues(typeof(ToolOptions)))
            OptionsCollection.Items.Add(option);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            ToolOptions selectedOption = (ToolOptions)OptionsCollection.SelectedItem;
            var selectedValue = numericUpDown.Value;

            createTool(selectedOption, selectedValue);
        }

        private void createTool(ToolOptions selectedOption, decimal selectedValue)

        {
          
            
            switch (selectedOption)
            {

                case ToolOptions.TextBox: for(int i=0;i<selectedValue;i++)
                                             {
                                                    createTextBox();
                                              }
                                                break;
                case ToolOptions.Label: for (int i = 0; i < selectedValue; i++)
                                        {
                                                     createLabel();
                                         }
                                                break;

                case ToolOptions.Button:
                    for (int i = 0; i < selectedValue; i++)
                    {
                        createButton();
                    }
                    break;

                case ToolOptions.CheckBox:
                    for (int i = 0; i < selectedValue; i++)
                    {
                        cretecheckBox();
                    }
                    break;
                case ToolOptions.RadioButton:
                    for (int i = 0; i < selectedValue; i++)
                    {
                        createRadioButton();
                    }
                    break;

            }

        }
        void createTextBox()
        {

            TextBox textBox = new TextBox();
            textBox.Location = new Point(X.Next(0, 300), X.Next(0, 300));
            textBox.Visible = true;
            textBox.Name = "textbox" + a.ToString();
            Controls.Add(textBox);
            a++;
        }
        void createLabel()
        {
            Label label = new Label();
            label.Location = new Point(X.Next(0, 300), X.Next(0, 300));
            label.Text = "Label";
            label.Visible = true;
            label.Name = "label" + a.ToString();
            Controls.Add(label);
            a++;
        }
        void createButton()
        {
            Button newButton = new Button();
            newButton.Location = new Point(X.Next(0, 300), X.Next(0, 300));
            newButton.Text = "Button";
            newButton.Visible = true;
            newButton.Name = "btn" + a.ToString();
            Controls.Add(newButton);
            a++;
        }
        void cretecheckBox()
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Location = new Point(X.Next(0, 300), X.Next(0, 300));
            checkBox.Name = "Check box";
            checkBox.Text = "Check box Option 1";
            checkBox.Name = "chk" + a.ToString();
            checkBox.Checked = true;
            Controls.Add(checkBox);
            a++;


        }
        void createRadioButton()
        {
            RadioButton radioButton = new RadioButton();
            radioButton.Location = new Point(X.Next(0, 300), X.Next(0, 300));
            radioButton.Name = "radioButton";
            radioButton.Text = "radio Option 1";
            radioButton.Name = "rb" + a.ToString();
            radioButton.Visible = true;
            Controls.Add(radioButton);
            a++;

        }
        //void createCalender()
        //{
        //    MonthCalendar monthCalendar = new MonthCalendar();
        //    monthCalendar.Location = new Point(X.Next(0, 300), X.Next(0, 300));
        //    monthCalendar.Visible = true;
        //    monthCalendar.Name = "mthcldr" + a.ToString();
        //    Controls.Add(monthCalendar);
        //    a++;
        //}

        void clear()
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You surely want to clear the form", "Alert!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clear();
            }
        }
    }
}
