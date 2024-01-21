using Builder.Example2;

BurgerDirector chef = new BurgerDirector();
ClassicBurgerBuilder classicBurgerBuilder = new ClassicBurgerBuilder();
chef.MakeBurger(classicBurgerBuilder);
Burger classicBurger = classicBurgerBuilder.GetBurger();
Console.WriteLine("Hamburguesa clásica:");
classicBurger.DisplayBurgerInfo();

Console.WriteLine("");

VeggieBurgerBuilder veggieBurgerBuilder = new VeggieBurgerBuilder();
chef.MakeBurger(veggieBurgerBuilder);
Burger veggieBurger = veggieBurgerBuilder.GetBurger();
Console.WriteLine("Hamburguesa Vegana:");
veggieBurger.DisplayBurgerInfo();



//IBurgerBuilder ClassicBurgerBuilder = new ClassicBurgerBuilder();
//IBurgerBuilder VeggieBurgerBuilder  = new VeggieBurgerBuilder();

//BurgerDirector burgerDirector  = new BurgerDirector(ClassicBurgerBuilder);
//BurgerDirector burgerDirector2 = new BurgerDirector(VeggieBurgerBuilder);


//burgerDirector.ConstructBurger();
//burgerDirector2.ConstructBurger();

//Burger burger1 = ClassicBurgerBuilder.GetBurger();
//Burger burger2 = VeggieBurgerBuilder.GetBurger();


//burger1.DisplayBurgerInfo();
//burger2.DisplayBurgerInfo();


