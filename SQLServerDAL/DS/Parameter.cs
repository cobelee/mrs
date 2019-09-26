using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL
{
    public class Parameter
    {
        private string mText;

        public string Text
        {
            get { return mText; }
            set { mText = value; }
        }

        public override string ToString()
        {
            return mText;
        }

        public Parameter(string parameterName)
        {
            mText = parameterName;
        }
    }
}
