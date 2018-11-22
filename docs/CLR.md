# CLR
1. Compile code in CLR, JitCompilation flow
 CLR ищет нужную сборку сначала в глобальном кэше сборок (GAC), а затем последовательно в базовом каталоге приложения, каталогах закрытых путей и каталоге, указанном в элементе codeBase конфигурационного файла. Если методу Load передается сборка с нестрогим именем, он не применяет к ней политику, и CLR не ищет ее в GAC.
2. FCL Framework Class Library contains assemblies with different types which help with application creation (ASP.NET,Console, Windows Forms)
3. CTS (Common Type System), которая описывает способ определения и поведение типов. Позволяет коду, написанному на одном языке программирования, взаимодействовать с кодом, написанным на другом CLR языке. CTS также задает правила видимости типов и доступа к членам типа.
CLS
4. CLS (Common Language Specification); в ней перечислен минимальный набор возможностей, которые должны поддерживаться компилятором для генерирования типов, совместимых с другими компонентами, написанными на других CLS-совместимых языках на базе CLR.CLS определяет правила, которым должны соответствовать типы и методы с внешней видимостью, для того чтобы они могли использоваться в любом CLS-совместимом языке программирования
5. COM specifies an object model and programming requirements that enable COM objects (also called COM components, or sometimes simply objects) to interact with other objects. These objects can be within a single process, in other processes, and can even be on remote computers. They can be written in different languages, and they may be structurally quite dissimilar, which is why COM is referred to as a binary standard; a standard that applies after a program has been translated to binary machine code.
6. (Рихтер стр. 133) Как разные компоненты взаимодействуют во время выполнения
7. [Статические классы и члены статических](https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)
8. (Рихтер стр. 150) Ссылочные/значимые типы
 Если тип называют классом (class), речь идет о ссылочном типе.
 Если тип называют структурой (struct) или перечислениями (enumeration), речь идет о значимом типе.
 Все структуры являются прямыми потомками абстрактного типа System.ValueType, который, в свою очередь, является производным от типа System.Object. CLR значимый тип является изолированным, то есть он не может служить базовым типом для какого-либо другого ссылочного
или значимого типа, может наследоваться от интерфейса.
Значимый тип является неявно запечатанным.
Значимый тип копируется по значению, ссылочный тип по ссылке
Нельзя наследоваться от значимого типа.
Значимый тип можно разширять интерфейсом.
9. ***Equals и GetHashCode***, — состоит в том, что реализация типов System.Collections.
Hashtable, System.Collections.Generic.Dictionary и любых других коллекций
требует, чтобы два равных объекта имели одинаковые значения хеш-кодов. По-
этому, переопределяя Equals, нужно переопределить GetHashCode и обеспечить
соответствие алгоритма
10. [Events vs Delegate](https://dzone.com/articles/event-vs-delegate)
11. Контравариантные и ковариантные аргументы-типы в делегатах и интерфейсах (рихтер 317)
12. [Collections](http://geekswithblogs.net/BlackRabbitCoder/archive/2011/06/16/c.net-fundamentals-choosing-the-right-collection-class.aspx)
13. ***GC roots***    
are not objects in themselves but are instead references to objects. Any object referenced by a GC root will automatically survive the next garbage collection. There are four main kinds of root in .NET:

***A local variable*** in a method that is currently running is considered to be a GC root. The objects referenced by these variables can always be accessed immediately by the method they are declared in, and so they must be kept around. The lifetime of these roots can depend on the way the program was built. In debug builds, a local variable lasts for as long as the method is on the stack. In release builds, the JIT is able to look at the program structure to work out the last point within the execution that a variable can be used by the method and will discard it when it is no longer required. This strategy isn’t always used and can be turned off, for example, by running the program in a debugger.

***Static variables*** are also always considered GC roots. The objects they reference can be accessed at any time by the class that declared them (or the rest of the program if they are public), so .NET will always keep them around. Variables declared as ‘thread static’ will only last for as long as that thread is running.

If a ***managed object is passed to an unmanaged COM+ library through interop***, then it will also become a GC root with a reference count. This is because COM+ doesn’t do garbage collection: It uses, instead, a reference counting system; once the COM+ library finishes with the object by setting the reference count to 0 it ceases to be a GC root and can be collected again.

If ***an object has a finalizer***, it is not immediately removed when the garbage collector decides it is no longer ‘live’. Instead, it becomes a special kind of root until .NET has called the finalizer method. This means that these objects usually require more than one garbage collection to be removed from memory, as they will survive the first time they are found to be unused.

[Garbage collection occurs when one of the following conditions is true](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals)

***The system has low physical memory.*** This is detected by either the low memory notification from the OS or low memory indicated by the host.

***The memory that is used by allocated objects on the managed heap surpasses an acceptable threshold***. This threshold is continuously adjusted as the process runs.

The ***GC.Collect method is called***. In almost all cases, you do not have to call this method, because the garbage collector runs continuously. This method is primarily used for unique situations and testing.

14. ***Exceptions*** 
* Активно используйте блоки finally
* Не надо перехватывать все исключения
* Корректное восстановление после исключения
* Отмена незавершенных операций при невосстановимых исключениях
* Сокрытие деталей реализации для сохранения контракта. Иногда бывает полезно после перехвата одного исключения сгенерировать исключение другого типа. throw new NameNotFoundException(name, e);
* Есть CLR совместимые исключения и CLR не совместимые, CLR несовместимые исключения оборачиваются в WraperException и перехватываются CLR (реализовано c версии 2.0). Все исключения перехватываются типом Exception.   
* При появлении исключения CLR обнуляет его начальную точку. То есть CLR запоминает только место появления самого последнего исключения.
```
private void SomeMethod() {
try { ... }
catch (Exception e) {
  ...
  throw e; // CLR считает, что исключение возникло тут
  // FxCop сообщает об ошибке
}
}
```
```
private void SomeMethod() {
try { ... }
catch (Exception e) {
  ...
  throw; // CLR не меняет информацию о начальной точке исключения.
  // FxCop НЕ сообщает об ошибке
}
}
```

15. ***Code Contracts***
The benefits of code contracts include the following:

* Improved testing: Code contracts provide static contract verification, runtime checking, and documentation generation.

* Automatic testing tools: You can use code contracts to generate more meaningful unit tests by filtering out meaningless test arguments that do not satisfy preconditions.

* Static verification: The static checker can decide whether there are any contract violations without running the program. It checks for implicit contracts, such as null dereferences and array bounds, and explicit contracts.

* Reference documentation: The documentation generator augments existing XML documentation files with contract information. There are also style sheets that can be used with Sandcastle so that the generated documentation pages have contract sections.

16. ***ref vs out*** keywords Passing an argument by reference
```
class Product
{
    public Product(string name, int newID)
    {
        ItemName = name;
        ItemID = newID;
    }

    public string ItemName { get; set; }
    public int ItemID { get; set; }
}

private static void ModifyProductsByReference()
{
    // Declare an instance of Product and display its initial values.
    Product item = new Product("Fasteners", 54321);
    System.Console.WriteLine("Original values in Main.  Name: {0}, ID: {1}\n",
        item.ItemName, item.ItemID);

    // Pass the product instance to ChangeByReference.
    ChangeByReference(ref item);
    System.Console.WriteLine("Back in Main.  Name: {0}, ID: {1}\n",
        item.ItemName, item.ItemID);
}

private static void ChangeByReference(ref Product itemRef)
{
    // Change the address that is stored in the itemRef parameter.   
    itemRef = new Product("Stapler", 99999);

    // You can change the value of one of the properties of
    // itemRef. The change happens to item in Main as well.
    itemRef.ItemID = 12345;
}
```
