﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class SWTextbox : TextBox
    {
        public SWTextbox()
        {
            InitializeComponent();
        }

        public enum DataType
        {
            Numero,
            Texte,
            Codi
        }

        private DataType _Data;

        public DataType Data
        {
            get { return _Data; }
            set { _Data = value; }
        }

        private bool _IsEmpty;

        public bool IsEmpty
        {
            get { return _IsEmpty; }
            set { _IsEmpty = value; }
        }

        public enum IsForeign
        {
            Foreign,
            Normal
        }

        private IsForeign _Key;

        public IsForeign Key
        {
            get { return _Key; }
            set { _Key = value; }
        }

        private string _DBName;

        public string DBName
        {
            get { return _DBName; }
            set { _DBName = value; }
        }

        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void SWTextbox_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "";
            bool match;
            Regex rgx;

            if (Data is DataType.Numero)
            {
                pattern = @"^\d{1,}$";
            }

            if (Data is DataType.Codi)
            {
                pattern = @"^[AEIOU][A-Z]{3}\d{2}[13579]$";
            }

            rgx = new Regex(pattern);

            match = rgx.IsMatch(this.Text);

            if (match)
            {
                this.ForeColor = Color.DarkGreen;
            }
            else
            {
                this.ForeColor = Color.DarkRed;
            }
        }
    }
}
