using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.State
{
    public class ClientCode
    {
        public void Main()
        {
            AppBar appBar = new AppBar();
            appBar.InitState("My App");
            appBar.Build();
            appBar.SetState("My App #1");
            appBar.Build();
            appBar.Dispose();
            TextField textField = new TextField();
            textField.InitState("email");
            textField.Build();
            textField.SetState("email@gmail.com");
            textField.Build();
            textField.Dispose();
        }
    }
}
