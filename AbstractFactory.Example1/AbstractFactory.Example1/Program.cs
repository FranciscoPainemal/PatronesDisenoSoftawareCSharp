using AbstractFactory.Example1.Factories;
using AbstractFactory.Example1;

IThemeFactory themeFactory = new WinFactory();
IThemeFactory themeFactory2 = new MacFactory();
IThemeFactory themeFactory3 = new LinuxFactory();


///////////////////////////////////////////////
IButton button = themeFactory.CreateButton();
button.Render();

IDropDown dropDown = themeFactory.CreateDropDown();
dropDown.Render();

ITextBox textBox = themeFactory.CreateTextBox();
textBox.Render();

///////////////////////////////////////////////
IButton button2 = themeFactory2.CreateButton();
button2.Render();

IDropDown dropDown2 = themeFactory2.CreateDropDown();
dropDown2.Render();

ITextBox textBox2 = themeFactory2.CreateTextBox();
textBox2.Render();

///////////////////////////////////////////////
IButton button3 = themeFactory3.CreateButton();
button3.Render();

IDropDown dropDown3 = themeFactory3.CreateDropDown();
dropDown3.Render();

ITextBox textBox3 = themeFactory3.CreateTextBox();
dropDown3.Render();






