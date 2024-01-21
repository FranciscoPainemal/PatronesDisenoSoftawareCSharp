using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example1
{
    // interfaza que tendrá que implementar cada Factory
    public interface IThemeFactory
    {
        IButton CreateButton();

        IDropDown CreateDropDown();

        ITextBox CreateTextBox();
    }
}
