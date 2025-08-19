// See https://aka.ms/new-console-template for more information


//--- Behavioral Pattern --- /
//1 - State Pattern
/* Bad Example */
//var doc = new Document();
//doc.State = DocumentStatus.Moderation;
//doc.CurrentUserRole = UserRoles.Admin;
//doc.Publish();
//Console.WriteLine(doc.State);

/* Good Example */
using Design_Patteren_C_Sharp_Course.Behavioral_Design.Command.Good;
using Design_Patteren_C_Sharp_Course.Behavioral_Design.Iterator;
using Design_Patteren_C_Sharp_Course.Behavioral_Design.State.GoodSolution;
using Design_Patteren_C_Sharp_Course.Behavioral_Design.Strategy.Good;
using Design_Patteren_C_Sharp_Course.Behavioral_Design.Template.TemplateMethod;
using Design_Patteren_C_Sharp_Course.Behavioral_Design.TemplateMethod.Strategy.Bad;

var doc = new Document(UserRoles.Admin);
Console.WriteLine(doc.State);

doc.Publish();
Console.WriteLine(doc.State);
doc.Publish();

Console.WriteLine(doc.State);

Console.WriteLine("\n\n******* Strategy Pattern***********");

Console.WriteLine();
//2 - Strategy Pattern
// Pass different alogriths or behaviours to an object
var videoStorage = new VideoStorage(new CompressorMOV(), new OverLayBlackWhite());
videoStorage.Store("/Videos/some-moivew");

Console.WriteLine("\n\n******* Iterator Pattern***********");
//Employ the iterator pattern when your collction possessess a complex data structure or data structure that likely to change.

var shoppingList = new ShoppingList();
shoppingList.AddToCart("Milk");
shoppingList.AddToCart("Cream");
shoppingList.AddToCart("Bread");

var iterator = shoppingList.GetIterator();
while (iterator.HasNext())
{
    Console.WriteLine("Product in cart = {0}", iterator.Current());
    iterator.Next();
}

Console.WriteLine("\n\n******* Command Pattern***********");

Console.WriteLine();

//var light = new Light();
//var remotControl = new RemoteControl_Bad(light);
//remotControl.PressButton(true);
//remotControl.PressButton(false);

var light = new Light();
var remote = new RemoteControl(new TurnOnCommand(light));
remote.PressButton();


Console.WriteLine("\n\n******* Template Method Pattern***********");

Console.WriteLine();

/*
 * Template Method defines the skeleton of an algorithm in a base class, but lets subclasses override specific steps without changing the overall structure.
 * Like if we have common structure and some steps may vary
 */

var tea = new BadTea();
tea.MakeBeverage();
// Solution 1 - Using polymorphism and strategy patteren
//var beverageMaker = new BeverageMaker(new Tea());
//beverageMaker.MakeBeverage();

// Solution 2 - Inheritance
var teatemplate = new Tea();
teatemplate.Prepare();

