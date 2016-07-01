using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankManagementSystem.Views.Controls
{
    public class PlaceHolderTextBox : TextBox
    {
        public bool IsPassword { get; set; }
        bool isPlaceHolder = true;
        string _placeHolderText;
        public string PlaceHolderText
        {
            get { return _placeHolderText; }
            set
            {
                _placeHolderText = value;
                SetPlaceholder();
            }
        }

        public void SetPlaceholder()
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                if (IsPassword) PasswordChar = '\0';
                Text = PlaceHolderText;
                ForeColor = Color.Gray;
                Font = new Font(Font, FontStyle.Italic);
                isPlaceHolder = true;
            }
        }

        public void RemovePlaceHolder()
        {
            if (IsPassword) PasswordChar = '*';
            if (isPlaceHolder)
            {
                Text = "";
                ForeColor = System.Drawing.SystemColors.WindowText;
                Font = new Font(Font, FontStyle.Regular);
                isPlaceHolder = false;
            }
        }
        public PlaceHolderTextBox()
        {
            GotFocus += removePlaceHolder;
            LostFocus += setPlaceholder;
        }

        private void setPlaceholder(object sender, EventArgs e)
        {
            SetPlaceholder();
        }

        private void removePlaceHolder(object sender, EventArgs e)
        {
            RemovePlaceHolder();
        }
    }
}
