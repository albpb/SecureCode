using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class SWCodi : UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
        }

        private string _NomTaula;

        public string NomTaula
        {
            get { return _NomTaula; }
            set { _NomTaula = value; }
        }

        private string _Nomcodi;

        public string Nomcodi
        {
            get { return _Nomcodi; }
            set { _Nomcodi = value; }
        }

        private string _NomDesc;

        public string NomDesc
        {
            get { return _NomDesc; }
            set { _NomDesc = value; }
        }

        private string _NomId;

        public string NomId
        {
            get { return _NomId; }
            set { _NomId = value; }
        }

        private string _FormCS;

        public string FormCS
        {
            get { return _FormCS; }
            set { _FormCS = value; }
        }

        private string _ClasseCS;

        public string ClasseCS
        {
            get { return _ClasseCS; }
            set { _ClasseCS = value; }
        }

        private string _ControlID;

        public string ControlID
        {
            get { return _ControlID; }
            set { _ControlID = value; }
        }
    }
}
