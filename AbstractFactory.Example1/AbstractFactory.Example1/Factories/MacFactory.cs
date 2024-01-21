using AbstractFactory.Example1.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example1.Factories
{
    public class MacFactory : IThemeFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public IDropDown CreateDropDown()
        {
            return new MacDropDown();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
}
