﻿using System;
using System.Threading.Tasks;

namespace WpfApp3
{
    internal class MessageDialog
    {
        private string v1;
        private string v2;

        public MessageDialog(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal Task ShowAsync()
        {
            throw new NotImplementedException();
        }
    }
}