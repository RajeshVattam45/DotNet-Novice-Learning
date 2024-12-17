using sample1.arrays;
using sample1.@string;
using sample1.ConditionalStatments;
using sample1.Loops;
using sample1.Methods;
using sample1.oops;
using sample1.oops.AnimalAbstraction;
using sample1.oops.StringAccessModifiers;
using sample1.oops.PersonsConstructor;
using sample1.oops.PersonInheritance;
using sample1.oops.interfaces;
using sample1.oops.enums;
using sample1.oops.ExceptionHandler;
using sample1.oops.StudentEncapsulations;
using sample1.oops.polymorphism;
using sample1.TypeCasting;
using ClassLibrary.SolidPrincipals.SRP;
using ClassLibrary.SolidPrincipals.OCP;
using ClassLibrary.SolidPrincipals.LSP;
using ClassLibrary.SolidPrincipals.ISP;
using sample1.Variables;
using ClassLibrary.SolidPrinciples.DIP;

class Program
{
    static void Main()
    {
        // Creating object to demonstrate the implementation of variables. 
        Variables variableObject = new Variables();
        variableObject.Integer();
        variableObject.DeclearString();
        string[] args = { "Hi", ".Net", "Hlo" };
        variableObject.StringFunction(args);
        variableObject.ConstFun();

        // Creating object to demonstrate the implementation of for loop.
        NumbersClass forLoopClassObject = new NumbersClass();
        forLoopClassObject.IterateNumbers();
        forLoopClassObject.AutoIncrementFunction();

        // Createing object to demonstrate the implementation of foreach loop.
        IterativeLoops tterateStringObject = new IterativeLoops();
        tterateStringObject.IterateStringArray();
        tterateStringObject.IterateIntegerArray();

        // Creating object to demonstrate the implementation of while & do while loops.
        WhileLoopClass whileLoopObject = new WhileLoopClass();
        whileLoopObject.IterateNumbersFunction();
        whileLoopObject.IterateFunction();

        // Display text content to demonstrate the implementation of string.
        StringContentClass textObject = new StringContentClass();
        textObject.DisplayContent();

        // Creating object to demonstrate the implementation of if else.
        ConditionalLogicClass conditionsStatmentsClassObject = new ConditionalLogicClass();
        conditionsStatmentsClassObject.ConditionalLogic();

        // Creating object to demonstrate the implementation of switch case.
        ConditionalExamples caseConditionsObject = new ConditionalExamples();
        caseConditionsObject.DemonstrateSwitchCase();

        // Creating object to demonstrate the implementation of ternary operator.
        TernaryOperatorClass ternaryOperatorObject = new TernaryOperatorClass();
        ternaryOperatorObject.TerneryOperatorsFunction();

        // Creating object to 'ArrayClass' to demonstrate the implementation of arrays.
        FruitsArrayUtilities arrayObject = new FruitsArrayUtilities();
        arrayObject.ArrayIterationMethod();

        // Cretaing object to demonstrate the implementation of different types of methods.
        DemonstrateMethodExamples methodsObject = new DemonstrateMethodExamples();
        methodsObject.DisplayGreeting();
        methodsObject.DisplayUserName("Rajesh");
        methodsObject.DisplayNameAndAge("Murali", 16);
        methodsObject.DisplayDefaultMessage("hello");

        // Create an object to demonstrate the implementation of return methods.
        ReturnValueClass returnValueObject = new ReturnValueClass();
        string fruitName = returnValueObject.ReturnFruitName("Apple");
        int addingNumber = returnValueObject.Add(3, 6);
        Console.WriteLine(fruitName);
        Console.WriteLine(addingNumber);

        // Createing object to display animal data.
        Animals animalObject = new Animals("Tiger", "Yello & Black", 150);
        animalObject.DisplayAnimal();

        Animals animalObjecttwo = new Animals("Tiger", "Yello & Black", 150);
        animalObjecttwo.DisplayAnimal();

        Animals lionObject = new Animals("Lion", "Brown", 150);
        lionObject.DisplayAnimal();

        // Creating object of PersonsDetails class to demonstrates the use of a constructor.
        PersonsDetails constructorObj = new PersonsDetails("Rajesh", 55, 23, "Male");
        constructorObj.DisplayPersonsData();

        // Creating object of ExtendedPerson to demonstrate the implementation of interface.
        ExtendedPerson personObject = new ExtendedPerson("Rajesh", 23, "Male", "White");
        personObject.DisplayData();
        personObject.ColorFunction();

        // Create object of StringLiteratures to demonstrate the implementation of access modifiers.
        StringLiteratures fruitObject = new StringLiteratures();
        fruitObject.DisplayFruitName();
        fruitObject.DisplayFruitColor();
        // protected throws error.
        // fruitObject.DisplayFruitWeight();

        // Creating objects of LionClass and Tiger to demonstrate the implementation of abstract methods.
        LionClass newObject = new LionClass();
        newObject.AnimalName();
        newObject.MakeSound();

        Tiger tigerObject = new Tiger();
        tigerObject.MakeSound();
        tigerObject.AnimalName();

        // Create object to Apple class to demonstrate the implementation of interface.
        Apple appleObject = new Apple();
        appleObject.FruitName();
        appleObject.FruitDescription();
        appleObject.FruitColor();

        // Create object to demonstrate the implementation of multiple interface.
        AppleClass mangoObject = new AppleClass();
        mangoObject.FruitName();
        mangoObject.FruitColor();
        mangoObject.FruitWight();

        // Create object to demonstrate the implementation of encapsulations.
        StudentsListClass studentsObject = new StudentsListClass();
        studentsObject.Name = "Rajesh";
        studentsObject.Marks = 60;
        studentsObject.DisplayStudent();
        studentsObject.Group = "Bsc";
        Console.WriteLine(studentsObject.Group);

        // Call the GetEnumsValues method to display customer type messages.
        // To demonstrate the implementation enums.
        EnumOperations enumObject = new EnumOperations();
        enumObject.GetUserValues(EnumOperations.CustomerType.User);
        enumObject.GetUserValues(EnumOperations.CustomerType.Admin);
        enumObject.GetUserValues(EnumOperations.CustomerType.Blogs);
        enumObject.GetUserValues(EnumOperations.CustomerType.Customers);
        enumObject.DisplaySelectedDay();

        // Creating objects of LionClass and Tiger to demonstrate the implementation of polymorphism.
        MyClass myClass = new MyClass();
        BaseClass myClassTwo = new MyClassTwo();
        BaseClass myClassThree = new MyClassThree();

        myClass.DisplayContent();
        myClassTwo.DisplayContent();
        myClassThree.DisplayContent();

        // Create object to demonstrate the implementation of typecasting.
        DemonstrateTypeCasting typeCastingObject = new DemonstrateTypeCasting();
        typeCastingObject.DemonstrateImplicitCasting();
        typeCastingObject.DemonstrateExplicitCasting();

        // Create object to demonstrate the implementation of method with perameters.
        NamePerametersClass perameterObject = new NamePerametersClass();
        perameterObject.DisplayMessage("Rajesh");
        perameterObject.FunctionWithPerameters("Rajesh", 23);
        perameterObject.PeramsFunction(1, 2, 3, 4);

        // Create object to demonstrate the implementation of try/catch exception.
        DivisionByZeroHandler divisionObject = new DivisionByZeroHandler();
        divisionObject.Division();

        // Create object to demonstrate the implementation of finally exception.
        DemonstrateExceptionHandling finallyExceptionObject = new DemonstrateExceptionHandling();
        finallyExceptionObject.DemonstrateContent();

        // Create object to demonstrate the implementation of custom exception handling.
        StringInputExceptionHandler checkInputTextObject = new StringInputExceptionHandler();
        checkInputTextObject.CheckInputValue();


        // Solid principles.
        // creating object to demonstrate the implementation of Single Responsibility Principle.
        StudentsDetailsClass studentObject = new StudentsDetailsClass();
        studentObject.StudentName = "Rajesh";
        studentObject.FatherName = "Ramana";
        studentObject.StudentAge = 22;
        studentObject.StudentId = 152;
        studentObject.DisplayStudentDetails();

        // Creating object to demonstrate the implementation of Single Responsibility Principle.
        StudentsMarksClass studentsMarksClass = new StudentsMarksClass();
        studentsMarksClass.TeluguMarks = 100;
        studentsMarksClass.EnglishMarks = 78;
        studentsMarksClass.MathsMarks = 87;
        studentsMarksClass.PhysicsMarks = 76;

        string result = studentsMarksClass.DisplayAllSubjectMarks();
        Console.WriteLine(result);

        // Creating object to demonstrate the implementation of Open-Closed Principle.
        PhonePayClass phonepayObject = new PhonePayClass();
        phonepayObject.UserName = "Rajesh";
        var phonepay = phonepayObject.PaymentMethod(2000);
        Console.WriteLine(phonepay);

        GoolepayPayment goolepayObject = new GoolepayPayment();
        goolepayObject.UserName = "Lokesh";
        var googlepay = goolepayObject.PaymentMethod(2190);
        Console.WriteLine(googlepay);

        // Creating object to demonstrate the implementation of Liskov Substitution Principle.
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

        // Creating object to demonstrate the implementation of Interface Segregation Principle.
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

        // Creating object to demonstrate the implementation of Dependency Inversion Principle.
        // Use Credit Card for payment.
        IPaymentMethod creditCard = new CreditCardPayments();
        PaymentProcessors processor1 = new PaymentProcessors(creditCard);
        processor1.MakePayment(100.00m);

        // Use PayPal for payment.
        IPaymentMethod payPal = new PayPalPayment();
        PaymentProcessors processor2 = new PaymentProcessors(payPal);
        processor2.MakePayment(200.00m);
    }
}
