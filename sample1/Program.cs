using sample1.arrays;
using sample1.@string;
using sample1.ConditionalStatments;
using sample1.Loops;
using sample1.Methods;
using sample1.oops;
using sample1.oops.abstraction;
using sample1.oops.AccessModifiers;
using sample1.oops.constructor;
using sample1.oops.inheritance;
using sample1.oops.interfaces;
using sample1.oops.enums;
using sample1.oops.exceptions;
using sample1.oops.Encapsulations;
using sample1.oops.polymorphism;
using ClassLibrary1.OpenClosedPrinciple;
using sample1.TypeCasting;
using ClassLibrary1.SolidPrincipals.SRP;
using ClassLibrary1.SolidPrincipals.OCP;
using ClassLibrary1.SolidPrincipals.LSP;
using ClassLibrary1.SolidPrincipals.ISP;
using sample1.Variables;
using ClassLibrary1.SolidPrinciples.DIP;

class Program
{
    static void Main()
    {
        // Creating object to 'Variables' class. 
        Variables variableObject = new Variables();
        variableObject.Integer();
        variableObject.DeclearString();
        string[] args = { "Hi", ".Net", "Hlo" };
        variableObject.StringFunction(args);
        variableObject.ConstFun();

        // Creating object to 'MyLoops' class.
        MyLoops myLoopsObject = new MyLoops();
        myLoopsObject.MyFunction();
        myLoopsObject.ForEachLoop();
        myLoopsObject.WhileLoop();

        // Creating object to 'ForLoopClass' class.
        ForLoopClass forLoopClassObject = new ForLoopClass();
        forLoopClassObject.ForLoopFunction();
        forLoopClassObject.AutoIncrementFunction();

        IterativeLoops foreachLoopObject = new IterativeLoops();
        foreachLoopObject.IterateStringArray();
        foreachLoopObject.IterateIntegerArray();

        // Creating object to 'WhileLoopClass' class.
        WhileLoopClass whileLoopObject = new WhileLoopClass();
        whileLoopObject.WhileLoopFunction();
        whileLoopObject.DoWhileLoopFunction();

        // Display text content.
        StringClass textObject = new StringClass();
        textObject.DisplayContent();

        // Creatig object to 'ConditionalLogicClass' class.
        ConditionalLogicClass conditionsStatmentsClassObject = new ConditionalLogicClass();
        conditionsStatmentsClassObject.ConditionalLogic();

        ConditionalExamples caseConditionsObject = new ConditionalExamples();
        caseConditionsObject.DemonstrateSwitchCase();

        // Creating object to 'TernaryOperatorClass' class.
        TernaryOperatorClass ternaryOperatorObject = new TernaryOperatorClass();
        ternaryOperatorObject.TerneryOperatorsFunction();

        // Creating object to 'ArrayClass' class.
        ArrayUtilities arrayObject = new ArrayUtilities();
        arrayObject.ArrayIterationMethod();

        // Cretaing object to 'MethodsClass' class.
        MethodExamples methodsObject = new MethodExamples();
        methodsObject.DisplayGreeting();
        methodsObject.DisplayUserName("Rajesh");
        methodsObject.DisplayNameAndAge("Murali", 16);
        methodsObject.DisplayDefaultMessage("hello");

        // Create an object of ReturnValueMethodClass.
        ReturnValueMethodClass returnValueObject = new ReturnValueMethodClass();

        // Call MyMethod and print the result.
        string fruitName = returnValueObject.MyMethod("Apple");
        Console.WriteLine(fruitName);

        // Call Add method and print the result.
        int sum = returnValueObject.Add(20, 40);
        Console.WriteLine("Sum is: " + sum);

        // Createing object to display animal data.
        Animals animalObject = new Animals("Tiger", "Yello & Black", 150);
        animalObject.DisplayAnimal();

        Animals animalObjecttwo = new Animals("Tiger", "Yello & Black", 150);
        animalObjecttwo.DisplayAnimal();

        Animals lionObject = new Animals("Lion", "Brown", 150);
        lionObject.DisplayAnimal();

        // 
        ConstructorClass constructorObj = new ConstructorClass("Rajesh", 55, 23, "Male");
        constructorObj.DisplayData();

        ChaildClass nameObject = new ChaildClass("Rajesh", 23, "Male", "White");
        nameObject.DisplayData();
        nameObject.ColorFunction();

        AccessModifiersClass fruitObject = new AccessModifiersClass();
        fruitObject.DisplayFruitName();
        fruitObject.DisplayFruitColor();
        // protected throws error.
        // fruitObject.DisplayFruitWeight();


        LionClass newObject = new LionClass();
        newObject.AnimalName();
        newObject.MakeSound();

        Tiger tigerObject = new Tiger();
        tigerObject.MakeSound();
        tigerObject.AnimalName();


        Apple appleObject = new Apple();
        appleObject.FruitName();
        appleObject.FruitDescription();
        appleObject.FruitColor();

        AppleClass mangoObject = new AppleClass();
        mangoObject.FruitName();
        mangoObject.FruitColor();
        mangoObject.FruitWight();


        ExceptionsClass exceptionsObject = new ExceptionsClass();
        exceptionsObject.ExceptionMethod();

        StudentsListClass studentsObject = new StudentsListClass();
        studentsObject.Name = "Rajesh";
        studentsObject.Marks = 60;
        studentsObject.DisplayStudent();
        studentsObject.Group = "Bsc";
        Console.WriteLine(studentsObject.Group);

        // Call the GetEnumsValues method to display customer type messages.
        EnumsClass enumObject = new EnumsClass();
        enumObject.GetEnumsValues(EnumsClass.CustomerType.User);
        enumObject.GetEnumsValues(EnumsClass.CustomerType.Admin);
        enumObject.GetEnumsValues(EnumsClass.CustomerType.Blogs);
        enumObject.GetEnumsValues(EnumsClass.CustomerType.Customers);
        enumObject.DisplayWeek();

        // CreateObjects.CreateObjectMethod(); cerify one and remove the class if it not required.
        MyClass myClass = new MyClass();
        PolymorphismClass myClassTwo = new MyClassTwo();
        PolymorphismClass myClassThree = new MyClassThree();

        myClass.Display();
        myClassTwo.Display();
        myClassThree.Display();

        TypeCastingClass typeCastingObject = new TypeCastingClass();
        typeCastingObject.ImplicitCasting();
        typeCastingObject.ExplicitCasting();

        // Solid principles.
        CreatePaymentObject.ProcessPayments();

        PerametersClass perameterObject = new PerametersClass();
        perameterObject.DisplayMessage("Rajesh");

        perameterObject.FunctionWithPerameters("Rajesh", 23);
        perameterObject.PeramsFunction(1, 2, 3, 4);

        TryCatchClass tryCatchObject = new TryCatchClass();
        tryCatchObject.Division();

        FinallyExceptionClass finallyExceptionObject = new FinallyExceptionClass();
        finallyExceptionObject.FinallyMethod();

        CustomException customExceptionObject = new CustomException();
        customExceptionObject.CheckMethod();


        // Solid principles.
        StudentsDetailsClass studentObject = new StudentsDetailsClass();
        studentObject.StudentName = "Rajesh";
        studentObject.FatherName = "Ramana";
        studentObject.StudentAge = 22;
        studentObject.StudentId = 152;
        studentObject.DisplayStudentDetails();

        StudentsMarksClass studentsMarksClass = new StudentsMarksClass();
        studentsMarksClass.TeluguMarks = 100;
        studentsMarksClass.EnglishMarks = 78;
        studentsMarksClass.MathsMarks = 87;
        studentsMarksClass.PhysicsMarks = 76;

        string result = studentsMarksClass.DisplayAllSubjectMarks();
        Console.WriteLine(result);

        PhonePayClass phonepayObject = new PhonePayClass();
        phonepayObject.UserName = "Rajesh";
        var phonepay = phonepayObject.PaymentMethod(2000);
        Console.WriteLine(phonepay);

        GoolepayPayment goolepayObject = new GoolepayPayment();
        goolepayObject.UserName = "Lokesh";
        var googlepay = goolepayObject.PaymentMethod(2190);
        Console.WriteLine(googlepay);

        AnimalsClass lionsObject = new LionsClass();
        string lionName = lionsObject.AnimalName("Lion");
        string lionColor = lionsObject.AnimalColor("Orange");
        Console.WriteLine(lionName);
        Console.WriteLine(lionColor);

        AnimalsClass tigersObject = new TigerClass();
        string tigerName = tigersObject.AnimalName("Tiger");
        string tigerColor = tigersObject.AnimalColor("Yello & black");
        Console.WriteLine(tigerName);
        Console.WriteLine(tigerColor);

        CarsClass carsClass = new AudiClass();
        string carName = carsClass.CarName("Audi");
        string carColor = carsClass.CarColor("Audi");
        int carCost = carsClass.CarCost(2099922);
        Console.WriteLine(carName);
        Console.WriteLine(carColor);
        Console.WriteLine(carCost);

        CarsBrands carsBrand = new AudiClass();
        string carsBrandName = carsBrand.CarBrandName("Audi");
        Console.WriteLine(carsBrandName);

        CreateObject createObject = new CreateObject();
        createObject.CreateObjectMethod();
    }
}
